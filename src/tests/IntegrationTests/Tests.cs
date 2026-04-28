namespace ResembleAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ResembleAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("RESEMBLEAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("RESEMBLEAI_API_KEY environment variable is not found.");

        var client = new ResembleAIClient(apiKey);
        
        return client;
    }
}
