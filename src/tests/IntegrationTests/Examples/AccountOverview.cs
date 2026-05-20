/*
order: 10
title: Account overview
slug: account-overview

Inspect the authenticated account, current team plan, and billing usage.
*/

namespace ResembleAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_AccountOverview()
    {
        using var client = GetAuthenticatedClient();

        //// Load the signed-in account profile.
        var account = await client.SubpackageAccount.GetAccountAsync();
        var email = account.Item?.AdditionalProperties.GetString("email");

        //// Load the first team record returned by the account API.
        var team = await GetFirstTeamAsync(client);
        var teamName = team.GetString("name");
        var teamPlan = team.GetString("plan");

        //// Inspect current usage buckets reported by the billing endpoint.
        var billingUsage = await client.SubpackageAccount.GetBillingUsageAsync();
        var synthesisUsage = billingUsage.Item?.AdditionalProperties.GetString("synth");
        var detectionUsage = billingUsage.Item?.AdditionalProperties.GetString("detect");

        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Team: {teamName} ({teamPlan})");
        Console.WriteLine($"Usage: synth={synthesisUsage}, detect={detectionUsage}");

        account.Success.Should().BeTrue();
        email.Should().NotBeNullOrWhiteSpace();
        teamPlan.Should().NotBeNullOrWhiteSpace();
        billingUsage.Success.Should().BeTrue();
    }
}
