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
                var createdTranscript = await client.SpeechToText.CreateTranscriptAsync(
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
    [Ignore("Audio edit endpoint is no longer present in the current OpenAPI spec.")]
    public void Live_AudioEdit_AcceptsBundledFixtures()
    {
        Assert.Inconclusive("Audio edit endpoint is no longer present in the current OpenAPI spec.");
    }
}
