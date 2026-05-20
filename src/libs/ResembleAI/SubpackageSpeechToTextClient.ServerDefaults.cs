namespace ResembleAI;

public sealed partial class SubpackageSpeechToTextClient
{
    partial void PrepareArguments(HttpClient client)
    {
        ResembleAIServerDefaults.SelectAppApiServer(AutoSDKServerConfiguration, TrySelectServer);
    }
}
