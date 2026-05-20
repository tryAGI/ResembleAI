using System.Net;
using System.Text.Json;

namespace ResembleAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private const string SampleAudioFileName = "resembleai-sample.wav";
    private const string SampleTranscript = "Hello from the Resemble AI SDK integration tests.";
    private static int _isDotEnvLoaded;

    private static ResembleAIClient GetAuthenticatedClient()
    {
        LoadDotEnv();

        var apiKey =
            Environment.GetEnvironmentVariable("RESEMBLEAI_API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            Environment.GetEnvironmentVariable("API_KEY") is { Length: > 0 } fallbackApiKeyValue ? fallbackApiKeyValue :
            throw new AssertInconclusiveException(
                "RESEMBLEAI_API_KEY environment variable is not found. Set RESEMBLEAI_API_KEY or add a repo-root .env file.");

        return new ResembleAIClient(apiKey);
    }

    private static async Task<ResembleVoiceInfo> GetReadyVoiceAsync(ResembleAIClient client)
    {
        var configuredVoiceUuid = Environment.GetEnvironmentVariable("RESEMBLEAI_VOICE_UUID");
        if (configuredVoiceUuid is { Length: > 0 })
        {
            return new ResembleVoiceInfo(configuredVoiceUuid, "Configured voice", SupportsSync: true, SupportsStreaming: true);
        }

        var voices = await client.SubpackageVoices.ListVoicesAsync(page: 1, pageSize: 25).ConfigureAwait(false);

        var voice = voices.Items?
            .Select(item => ResembleVoiceInfo.FromAdditionalProperties(item.AdditionalProperties))
            .FirstOrDefault(candidate => candidate is { SupportsSync: true, SupportsStreaming: true });

        return voice ??
               throw new AssertInconclusiveException("No TTS-capable voice was returned by the ResembleAI account.");
    }

    private static async Task<IDictionary<string, object>> GetFirstTeamAsync(ResembleAIClient client)
    {
        var teams = await client.SubpackageAccount.GetTeamsAsync().ConfigureAwait(false);
        var team = teams.Items?
            .Select(item => item.AdditionalProperties)
            .FirstOrDefault(properties => properties.Count > 0);

        return team ?? throw new AssertInconclusiveException("No team details were returned by the ResembleAI account.");
    }

    private static async Task<SpeechToTextGetTranscriptResponse200> WaitForTranscriptCompletionAsync(
        ResembleAIClient client,
        Guid transcriptUuid,
        CancellationToken cancellationToken = default)
    {
        for (var attempt = 0; attempt < 30; attempt++)
        {
            var transcript = await client.SubpackageSpeechToText.GetTranscriptAsync(transcriptUuid, cancellationToken: cancellationToken)
                .ConfigureAwait(false);

            switch (transcript.Item?.Status)
            {
                case SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus.Completed:
                    return transcript;
                case SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus.Failed:
                    Assert.Fail($"Transcript job {transcriptUuid} failed.");
                    break;
            }

            await Task.Delay(TimeSpan.FromSeconds(2), cancellationToken).ConfigureAwait(false);
        }

        throw new AssertInconclusiveException($"Transcript job {transcriptUuid} did not complete within the polling window.");
    }

    private static async Task<byte[]> LoadSampleAudioAsync()
    {
        var resourcePath = Path.Combine(GetRepositoryRoot(), "src", "tests", "IntegrationTests", "Resources", SampleAudioFileName);
        return await File.ReadAllBytesAsync(resourcePath).ConfigureAwait(false);
    }

    private static string GetRepositoryRoot()
    {
        foreach (var startDirectory in new[] { Directory.GetCurrentDirectory(), AppContext.BaseDirectory })
        {
            var repoRoot = FindDirectoryContaining(startDirectory, "ResembleAI.slnx");
            if (repoRoot is not null)
            {
                return repoRoot;
            }
        }

        throw new DirectoryNotFoundException("Unable to locate the ResembleAI repository root.");
    }

    private static void LoadDotEnv()
    {
        if (Interlocked.Exchange(ref _isDotEnvLoaded, 1) == 1)
        {
            return;
        }

        foreach (var startDirectory in new[] { Directory.GetCurrentDirectory(), AppContext.BaseDirectory })
        {
            var dotEnvPath = FindFileInAncestors(startDirectory, ".env");
            if (dotEnvPath is null)
            {
                continue;
            }

            foreach (var rawLine in File.ReadLines(dotEnvPath))
            {
                var line = rawLine.Trim();
                if (line.Length == 0 || line.StartsWith('#'))
                {
                    continue;
                }

                if (line.StartsWith("export ", StringComparison.Ordinal))
                {
                    line = line["export ".Length..].TrimStart();
                }

                var separatorIndex = line.IndexOf('=');
                if (separatorIndex <= 0)
                {
                    continue;
                }

                var key = line[..separatorIndex].Trim();
                if (key.Length == 0 || Environment.GetEnvironmentVariable(key) is not null)
                {
                    continue;
                }

                var value = line[(separatorIndex + 1)..].Trim();
                if (value.Length >= 2 &&
                    ((value[0] == '"' && value[^1] == '"') || (value[0] == '\'' && value[^1] == '\'')))
                {
                    value = value[1..^1];
                }

                Environment.SetEnvironmentVariable(key, value);
            }

            return;
        }
    }

    private static string? FindFileInAncestors(string startDirectory, string fileName)
    {
        var directory = new DirectoryInfo(Path.GetFullPath(startDirectory));
        while (directory is not null)
        {
            var candidate = Path.Combine(directory.FullName, fileName);
            if (File.Exists(candidate))
            {
                return candidate;
            }

            directory = directory.Parent;
        }

        return null;
    }

    private static string? FindDirectoryContaining(string startDirectory, string fileName)
    {
        var directory = new DirectoryInfo(Path.GetFullPath(startDirectory));
        while (directory is not null)
        {
            if (File.Exists(Path.Combine(directory.FullName, fileName)))
            {
                return directory.FullName;
            }

            directory = directory.Parent;
        }

        return null;
    }

    private static void AssertFeatureAvailable(ApiException ex, string featureName)
    {
        if (!IsPlanOrCreditLimit(ex))
        {
            throw ex;
        }

        var message = ex.ResponseBody ?? ex.Message;
        Assert.Inconclusive($"{featureName} is not available for this token: {message[..Math.Min(message.Length, 220)]}");
    }

    private static bool IsPlanOrCreditLimit(ApiException ex)
    {
        var responseText = $"{ex.Message}\n{ex.ResponseBody}";

        return ex.StatusCode is HttpStatusCode.PaymentRequired or HttpStatusCode.TooManyRequests ||
               ex.StatusCode == HttpStatusCode.UnprocessableEntity &&
               responseText.Contains("Invalid voice UUID", StringComparison.OrdinalIgnoreCase) ||
               ex.StatusCode == HttpStatusCode.Unauthorized &&
               (responseText.Contains("credits", StringComparison.OrdinalIgnoreCase) ||
                responseText.Contains("unauthorized", StringComparison.OrdinalIgnoreCase)) ||
               responseText.Contains("usage limit", StringComparison.OrdinalIgnoreCase) ||
               responseText.Contains("upgrade to continue", StringComparison.OrdinalIgnoreCase) ||
               responseText.Contains("add funds", StringComparison.OrdinalIgnoreCase);
    }

    private sealed record ResembleVoiceInfo(
        string Uuid,
        string Name,
        bool SupportsSync,
        bool SupportsStreaming)
    {
        public static ResembleVoiceInfo FromAdditionalProperties(IDictionary<string, object> properties)
        {
            var apiSupport = properties.GetObject("api_support");

            return new ResembleVoiceInfo(
                Uuid: properties.GetString("uuid") ?? throw new InvalidOperationException("Voice UUID is missing."),
                Name: properties.GetString("name") ?? "Unnamed voice",
                SupportsSync: apiSupport?.GetBooleanProperty("sync") ?? false,
                SupportsStreaming: apiSupport?.GetBooleanProperty("streaming") ?? false);
        }
    }
}
