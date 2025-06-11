namespace quickcrawl.tests;

using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

public class BrowserControllerIntegrationTests
{
    [Fact]
    public async Task GetWebsocketDebugTargets_ReturnsTargets()
    {
        // Arrange
        var targets = await BrowserController.GetWebsocketDebugTargets();

        // Assert
        Assert.NotNull(targets);
        Assert.NotEmpty(targets);
        Assert.All(targets, t =>
        {
            Assert.False(string.IsNullOrEmpty(t.Id));
            Assert.False(string.IsNullOrEmpty(t.WebSocketDebuggerUrl));
        });
    }

    [Fact]
    public async Task NewBrowserTab_CreatesTabSuccessfully()
    {
        // Arrange
        var testUrl = "about:blank";

        // Act
        var newTab = await BrowserController.NewBrowserTab(testUrl);

        // Assert
        Assert.NotNull(newTab);

        var targets = await BrowserController.GetWebsocketDebugTargets();
        var createdTab = targets.FirstOrDefault(t => t.WebSocketDebuggerUrl == newTab.WebSocketDebuggerUrl);

        Assert.NotNull(createdTab);
    }

    [Fact]
    public async Task CloseBrowserTab_ClosesTabSuccessfully()
    {
        // Arrange
        var testUrl = "https://example.com";
        var newTab = await BrowserController.NewBrowserTab(testUrl);
        Assert.NotNull(newTab);

        // Act
        var result = await BrowserController.CloseBrowserTab(newTab.Id);

        // Assert
        Assert.Equal("Tab closed successfully.", result);

        // Verify the tab is no longer listed
        var tabs = await BrowserController.GetWebsocketDebugTargets();
        var closedTab = tabs.FirstOrDefault(t => t.Id == newTab.Id);

        Assert.Null(closedTab);
    }
}
