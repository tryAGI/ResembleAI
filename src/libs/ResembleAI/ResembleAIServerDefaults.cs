namespace ResembleAI;

internal static class ResembleAIServerDefaults
{
    internal const string ClusterServerId = "https-f-cluster-resemble-ai";
    internal const string AppApiServerId = "https-app-resemble-ai-api-v2";

    internal static void SelectClusterServer(
        AutoSDKServerConfiguration serverConfiguration,
        Func<string, bool> trySelectServer)
    {
        if (serverConfiguration.ExplicitBaseUri is not null)
        {
            return;
        }

        trySelectServer(ClusterServerId);
    }

    internal static void SelectAppApiServer(
        AutoSDKServerConfiguration serverConfiguration,
        Func<string, bool> trySelectServer)
    {
        if (serverConfiguration.ExplicitBaseUri is not null)
        {
            return;
        }

        trySelectServer(AppApiServerId);
    }
}
