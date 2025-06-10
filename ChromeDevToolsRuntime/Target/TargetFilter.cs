namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// The entries in TargetFilter are matched sequentially against targets and
    /// the first entry that matches determines if the target is included or not,
    /// depending on the value of `exclude` field in the entry.
    /// If filter is not specified, the one assumed is
    /// [{type: "browser", exclude: true}, {type: "tab", exclude: true}, {}]
    /// (i.e. include everything but `browser` and `tab`).
    /// </summary>
    [Obsolete("Experimental")]
    public sealed class TargetFilter : List<FilterEntry>
    {
    }
}