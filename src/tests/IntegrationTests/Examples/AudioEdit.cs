/*
order: 60
title: Audio edit
slug: audio-edit

Replace part of a short WAV clip by submitting the original and target transcript text.
*/

namespace ResembleAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_AudioEdit()
    {
        using var client = GetAuthenticatedClient();
        var selectedVoice = await GetReadyVoiceAsync(client);
        var audioBytes = await LoadSampleAudioAsync();
        const string targetTranscript = "Hello again from the Resemble AI SDK integration tests.";

        try
        {
            //// Submit an edit request that replaces the spoken text with new content.
            var audioEdit = await client.SubpackageAudioEdit.CreateAudioEditAsync(
                inputAudio: audioBytes,
                inputAudioname: SampleAudioFileName,
                originalTranscript: SampleTranscript,
                targetTranscript: targetTranscript,
                voiceUuid: selectedVoice.Uuid);

            Console.WriteLine($"Audio edit job: {audioEdit.Item?.Uuid}");

            audioEdit.Success.Should().BeTrue();
            audioEdit.Item?.Uuid.Should().NotBeNullOrWhiteSpace();
            audioEdit.Item?.TargetTranscript.Should().Be(targetTranscript);
        }
        catch (ApiException ex)
        {
            AssertFeatureAvailable(ex, "audio edit");
        }
    }
}
