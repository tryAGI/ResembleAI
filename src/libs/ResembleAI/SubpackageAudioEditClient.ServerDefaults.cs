namespace ResembleAI;

public sealed partial class SubpackageAudioEditClient
{
    partial void PrepareArguments(HttpClient client)
    {
        ResembleAIServerDefaults.SelectAppApiServer(AutoSDKServerConfiguration, TrySelectServer);
    }
}
