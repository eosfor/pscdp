using BaristaLabs.ChromeDevTools.Runtime.Network;

public class TrackedRequest
{
    public RequestWillBeSentEvent Request { get; init; }
    public DateTime Started { get; init; } = DateTime.UtcNow;
    public DateTime LastActivity { get; set; } = DateTime.UtcNow;
}