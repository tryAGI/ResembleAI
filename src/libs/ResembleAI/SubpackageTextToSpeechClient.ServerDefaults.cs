namespace ResembleAI;

public sealed partial class SubpackageTextToSpeechClient
{
    partial void PrepareArguments(HttpClient client)
    {
        ResembleAIServerDefaults.SelectClusterServer(AutoSDKServerConfiguration, TrySelectServer);
    }
}
