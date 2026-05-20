namespace ResembleAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Live_SpeechToText_TranscribesBundledFixtures()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            foreach (var fixture in GetBundledAudioFixtures())
            {
                var audioBytes = await LoadAudioFixtureAsync(fixture).ConfigureAwait(false);
                var createdTranscript = await client.SubpackageSpeechToText.CreateTranscriptAsync(
                    file: audioBytes,
                    filename: fixture.FileName).ConfigureAwait(false);

                var transcript = await WaitForTranscriptCompletionAsync(client, createdTranscript.Item!.Uuid!.Value).ConfigureAwait(false);
                AssertTranscriptLooksReasonable(transcript.Item?.Text, fixture);
            }
        }
        catch (ApiException ex)
        {
            AssertFeatureAvailable(ex, "speech-to-text");
        }
    }

    [TestMethod]
    public async Task Live_AudioEdit_AcceptsBundledFixtures()
    {
        using var client = GetAuthenticatedClient();
        var selectedVoice = await GetEditableVoiceAsync(client);

        try
        {
            foreach (var fixture in GetBundledAudioFixtures())
            {
                var audioBytes = await LoadAudioFixtureAsync(fixture).ConfigureAwait(false);
                var audioEdit = await client.SubpackageAudioEdit.CreateAudioEditAsync(
                    inputAudio: audioBytes,
                    inputAudioname: fixture.FileName,
                    originalTranscript: fixture.Transcript,
                    targetTranscript: fixture.EditedTranscript,
                    voiceUuid: selectedVoice.Uuid).ConfigureAwait(false);

                audioEdit.Success.Should().BeTrue();
                audioEdit.Item?.TargetTranscript.Should().Be(fixture.EditedTranscript);
            }
        }
        catch (ApiException ex)
        {
            AssertFeatureAvailable(ex, "audio edit");
        }
    }
}
