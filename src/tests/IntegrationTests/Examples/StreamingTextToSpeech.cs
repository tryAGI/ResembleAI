/*
order: 40
title: Streaming text to speech
slug: streaming-text-to-speech

Stream a short WAV response and save the resulting bytes to disk.
*/

namespace ResembleAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_StreamingTextToSpeech()
    {
        using var client = GetAuthenticatedClient();
        var selectedVoice = await GetReadyVoiceAsync(client);

        try
        {
            //// Stream synthesized audio as a WAV byte buffer.
            var audioBytes = await client.TextToSpeech.StreamSynthesizeAsync(
                voiceUuid: selectedVoice.Uuid,
                data: "This is a streaming text to speech check for the Resemble AI SDK.",
                sampleRate: StreamPostRequestBodyContentApplicationJsonSchemaSampleRate.x22050);

            await File.WriteAllBytesAsync("resembleai-stream.wav", audioBytes);
            Console.WriteLine($"Saved {audioBytes.Length} streamed bytes using {selectedVoice.Name}.");

            audioBytes.Should().NotBeNull();
            audioBytes.Length.Should().BeGreaterThan(0);
        }
        catch (ApiException ex)
        {
            AssertFeatureAvailable(ex, "streaming text-to-speech");
        }
    }
}
