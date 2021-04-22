using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models
{
    internal class CompletionRequirement : ICompletionRequirement
    {
        [JsonProperty("type")] public IEnumerable<CompletionRequirementTypes> Type { get; set; }
        [JsonProperty("min_score")] public int MinScore { get; set; }
        [JsonProperty("completed")] public bool Completed { get; set; }
    }
}
