namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when 103 Early Hints headers is received in addition to the common response.
    /// Not every responseReceived event will have an responseReceivedEarlyHints fired.
    /// Only one responseReceivedEarlyHints may be fired for eached responseReceived event.
    /// </summary>
    public sealed class ResponseReceivedEarlyHintsEvent : IEvent
    {
        /// <summary>
        /// Request identifier. Used to match this information to another responseReceived event.
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
        /// <summary>
        /// Raw response headers as they were received over the wire.
        /// Duplicate headers in the response are represented as a single key with their values
        /// concatentated using `\n` as the separator.
        /// See also `headersText` that contains verbatim text for HTTP/1.*.
        /// </summary>
        [JsonProperty("headers")]
        public Headers Headers
        {
            get;
            set;
        }
    }
}