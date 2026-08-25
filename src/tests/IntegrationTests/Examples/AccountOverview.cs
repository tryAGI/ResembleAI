/*
order: 10
title: Account overview
slug: account-overview

Inspect the authenticated account, current team plan, and default project.
*/

namespace ResembleAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_AccountOverview()
    {
        using var client = GetAuthenticatedClient();

        //// Load the signed-in account profile.
        var account = await client.Account.GetAccountAsync();
        var email = account.Item?.Email;

        //// Load the first team record returned by the account API.
        var team = await GetFirstTeamAsync(client);
        var teamName = team.Name;
        var teamPlan = team.Plan;

        //// Load the default project to confirm project management responses are typed.
        var project = await GetFirstProjectAsync(client);
        var projectName = project.Name;
        var projectUuid = project.Uuid;

        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Team: {teamName} ({teamPlan})");
        Console.WriteLine($"Project: {projectName} [{projectUuid}]");

        account.Success.Should().BeTrue();
        email.Should().NotBeNullOrWhiteSpace();
        teamPlan.Should().NotBeNullOrWhiteSpace();
        projectName.Should().NotBeNullOrWhiteSpace();
        projectUuid.Should().NotBeNullOrWhiteSpace();
    }
}
