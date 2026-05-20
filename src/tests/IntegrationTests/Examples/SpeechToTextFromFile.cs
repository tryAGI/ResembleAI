/*
order: 50
title: Speech to text from a file
slug: speech-to-text-from-a-file

Upload a local WAV file, poll until the transcript completes, and print the recognized text.
*/

namespace ResembleAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SpeechToTextFromFile()
    {
        using var client = GetAuthenticatedClient();
        var fixture = GetPrimaryAudioFixture();
        var audioBytes = await LoadAudioFixtureAsync(fixture);

        try
        {
            //// Submit a small local WAV file for transcription.
            var createdTranscript = await client.SubpackageSpeechToText.CreateTranscriptAsync(
                file: audioBytes,
                filename: fixture.FileName);

            //// Poll the transcript until it reaches a terminal state.
            var transcript = await WaitForTranscriptCompletionAsync(client, createdTranscript.Item!.Uuid!.Value);
            Console.WriteLine(transcript.Item?.Text);

            createdTranscript.Success.Should().BeTrue();
            createdTranscript.Item?.Uuid.Should().NotBeNull();
            transcript.Success.Should().BeTrue();
            AssertTranscriptLooksReasonable(transcript.Item?.Text, fixture);
        }
        catch (ApiException ex)
        {
            AssertFeatureAvailable(ex, "speech-to-text");
        }
    }
}
