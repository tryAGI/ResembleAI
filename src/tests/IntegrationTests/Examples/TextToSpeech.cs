/*
order: 30
title: Text to speech
slug: text-to-speech

Synthesize a short WAV clip and save it to disk using one of the ready voices.
*/

namespace ResembleAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TextToSpeech()
    {
        using var client = GetAuthenticatedClient();
        var selectedVoice = await GetReadyVoiceAsync(client);

        try
        {
            //// Synthesize a short clip to WAV audio.
            var response = await client.SubpackageTextToSpeech.SynthesizeAsync(
                voiceUuid: selectedVoice.Uuid,
                data: "Hello from the Resemble AI SDK integration tests.",
                title: "resembleai-sync-sample",
                outputFormat: SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat.Wav,
                sampleRate: SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate.x22050);

            //// Persist the decoded audio payload to disk.
            await File.WriteAllBytesAsync("resembleai-sync.wav", response.AudioContent!);
            Console.WriteLine($"Saved {response.AudioContent?.Length ?? 0} bytes using {selectedVoice.Name}.");

            response.Success.Should().BeTrue();
            response.AudioContent.Should().NotBeNull();
            response.AudioContent!.Length.Should().BeGreaterThan(0);
        }
        catch (ApiException ex)
        {
            AssertFeatureAvailable(ex, "text-to-speech");
        }
    }
}
