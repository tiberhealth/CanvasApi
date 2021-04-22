using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CanvasApi.Client.Modules.Models
{
    public interface ICompletionRequirement
    {
        [JsonProperty("completed")] public bool Completed { get; set; }
        [JsonProperty("min_score")] public int MinScore { get; set; }
        [JsonProperty("type")] public IEnumerable<CompletionRequirementTypes> Type { get; set; }
    }
}