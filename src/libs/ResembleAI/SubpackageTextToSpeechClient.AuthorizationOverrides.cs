namespace ResembleAI;

#pragma warning disable CA1822
public sealed partial class TextToSpeechClient
{
    partial void PrepareSynthesizeRequest(
        HttpClient httpClient,
        HttpRequestMessage httpRequestMessage,
        SynthesizeRequest request) =>
        NormalizeClusterAuthorizationHeader(httpRequestMessage);

    partial void PrepareStreamSynthesizeRequest(
        HttpClient httpClient,
        HttpRequestMessage httpRequestMessage,
        StreamSynthesizeRequest request) =>
        NormalizeClusterAuthorizationHeader(httpRequestMessage);

    private static void NormalizeClusterAuthorizationHeader(HttpRequestMessage request)
    {
        if (!string.Equals(request.RequestUri?.Host, "f.cluster.resemble.ai", StringComparison.OrdinalIgnoreCase) ||
            request.Headers.Authorization is not { Scheme: var scheme, Parameter: { Length: > 0 } token } ||
            !string.Equals(scheme, "Bearer", StringComparison.OrdinalIgnoreCase))
        {
            return;
        }

        request.Headers.Remove("Authorization");
        request.Headers.TryAddWithoutValidation("Authorization", token);
    }
}
#pragma warning restore CA1822
