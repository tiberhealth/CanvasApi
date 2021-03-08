using System.Collections.Generic;
using CanvasApi.Client.Assignments.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.AssignmentGroups.Models
{
    internal class AssignmentGroup : IAssignmentGroup
    {
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("position")] public int? Position { get; set; }
        [JsonProperty("group_weight")] public decimal? GroupWeight { get; set; }
        [JsonProperty("sis_source_id")] public string SisSourceId { get; set; }
        [JsonProperty("integration_data")] public JObject IntegrationData { get; set; }

        [JsonProperty("assignments")] public IEnumerable<Assignment> Assignments { get; set; }
        IEnumerable<IAssignment> IAssignmentGroup.Assignments => this.Assignments;

        [JsonProperty("rules")] public GradingRules Rules { get; set; }
        IGradingRules IAssignmentGroup.Rules => this.Rules;
    }
}
