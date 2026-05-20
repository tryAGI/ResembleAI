/*
order: 20
title: List voices
slug: list-voices

List ready-to-use voices and pick one that supports both sync and streaming TTS.
*/

namespace ResembleAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListVoices()
    {
        using var client = GetAuthenticatedClient();

        //// Fetch the first page of available voices from the management API.
        var voices = await client.SubpackageVoices.ListVoicesAsync(page: 1, pageSize: 10);
        var selectedVoice = await GetReadyVoiceAsync(client);

        Console.WriteLine($"Selected voice: {selectedVoice.Name} ({selectedVoice.Uuid})");

        voices.Success.Should().BeTrue();
        voices.Items.Should().NotBeNullOrEmpty();
        selectedVoice.Uuid.Should().NotBeNullOrWhiteSpace();
    }
}
