namespace ResembleAI;

public sealed partial class SubpackageVoicesClient
{
    partial void PrepareArguments(HttpClient client)
    {
        ResembleAIServerDefaults.SelectAppApiServer(AutoSDKServerConfiguration, TrySelectServer);
    }
}
