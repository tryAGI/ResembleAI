using System.Net;
using System.Text;

namespace ResembleAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Routing_UsesPerOperationServersAndClusterAuthorization()
    {
        var handler = new RecordingHandler();
        using var httpClient = new HttpClient(handler);
        using var client = new ResembleAIClient(
            apiKey: "test-token",
            httpClient: httpClient,
            disposeHttpClient: false);

        var selectedVoice = await GetReadyVoiceAsync(client);
        var synthResponse = await client.TextToSpeech.SynthesizeAsync(
            voiceUuid: selectedVoice.Uuid,
            data: "hello from routing coverage");
        var streamResponse = await client.TextToSpeech.StreamSynthesizeAsync(
            voiceUuid: selectedVoice.Uuid,
            data: "hello from stream routing coverage");

        synthResponse.AudioContent.Should().NotBeNull();
        synthResponse.AudioContent.Should().Equal([1, 2, 3]);
        streamResponse.Should().Equal([4, 5, 6]);
        httpClient.BaseAddress.Should().BeNull();

        handler.Requests.Should().HaveCount(3);
        handler.Requests[0].Host.Should().Be("app.resemble.ai");
        handler.Requests[0].Path.Should().Be("/api/v2/voices");
        handler.Requests[0].Authorization.Should().Be("Bearer test-token");

        handler.Requests[1].Host.Should().Be("f.cluster.resemble.ai");
        handler.Requests[1].Path.Should().Be("/synthesize");
        handler.Requests[1].Authorization.Should().Be("test-token");

        handler.Requests[2].Host.Should().Be("f.cluster.resemble.ai");
        handler.Requests[2].Path.Should().Be("/stream");
        handler.Requests[2].Authorization.Should().Be("test-token");
    }

    private sealed class RecordingHandler : HttpMessageHandler
    {
        public List<CapturedRequest> Requests { get; } = [];

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Requests.Add(new CapturedRequest(
                Host: request.RequestUri?.Host ?? string.Empty,
                Path: request.RequestUri?.AbsolutePath ?? string.Empty,
                Authorization: request.Headers.TryGetValues("Authorization", out var values)
                    ? values.SingleOrDefault()
                    : null));

            return Task.FromResult(CreateResponse(request));
        }

        private static HttpResponseMessage CreateResponse(HttpRequestMessage request)
        {
            return request.RequestUri?.AbsolutePath switch
            {
                "/api/v2/voices" => CreateJsonResponse(
                    """
                    {
                      "success": true,
                      "page": 1,
                      "num_pages": 1,
                      "page_size": 1,
                      "items": [
                        {
                          "uuid": "voice-1",
                          "name": "Fixture Voice",
                          "source": "Library",
                          "api_support": {
                            "sync": true,
                            "streaming": true
                          }
                        }
                      ]
                    }
                    """),
                "/synthesize" => CreateJsonResponse(
                    """
                    {
                      "success": true,
                      "audio_content": "AQID",
                      "duration": 0.1,
                      "synth_duration": 0.1,
                      "output_format": "wav",
                      "sample_rate": 22050
                    }
                    """),
                "/stream" => new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent([4, 5, 6]),
                },
                _ => throw new InvalidOperationException($"Unexpected request: {request.Method} {request.RequestUri}"),
            };
        }

        private static HttpResponseMessage CreateJsonResponse(string json)
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };
        }
    }

    private sealed record CapturedRequest(
        string Host,
        string Path,
        string? Authorization);
}
