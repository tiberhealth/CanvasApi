using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CanvasApi.Client.AssignmentGroups.Models.Concrete
{
    internal class GradingRules : IGradingRules
    {
        [JsonProperty("drop_lowest")] public int DropLowest { get; set; }
        [JsonProperty("drop_highest")] public int DropHighest { get; set; }
        [JsonProperty("never_drop")] public IEnumerable<long> NeverDrop { get; set; }
    }
}
