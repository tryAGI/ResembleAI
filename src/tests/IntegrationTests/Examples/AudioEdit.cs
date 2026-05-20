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
        var fixture = GetPrimaryAudioFixture();
        var selectedVoice = await GetEditableVoiceAsync(client);
        var audioBytes = await LoadAudioFixtureAsync(fixture);

        try
        {
            //// Submit an edit request that replaces the spoken text with new content.
            var audioEdit = await client.SubpackageAudioEdit.CreateAudioEditAsync(
                inputAudio: audioBytes,
                inputAudioname: fixture.FileName,
                originalTranscript: fixture.Transcript,
                targetTranscript: fixture.EditedTranscript,
                voiceUuid: selectedVoice.Uuid);

            Console.WriteLine($"Audio edit job: {audioEdit.Item?.Uuid}");

            audioEdit.Success.Should().BeTrue();
            audioEdit.Item?.Uuid.Should().NotBeNullOrWhiteSpace();
            audioEdit.Item?.TargetTranscript.Should().Be(fixture.EditedTranscript);
        }
        catch (ApiException ex)
        {
            AssertFeatureAvailable(ex, "audio edit");
        }
    }
}
