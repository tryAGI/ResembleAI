namespace ResembleAI;

public sealed partial class SubpackageAccountClient
{
    partial void PrepareArguments(HttpClient client)
    {
        ResembleAIServerDefaults.SelectAppApiServer(AutoSDKServerConfiguration, TrySelectServer);
    }
}
