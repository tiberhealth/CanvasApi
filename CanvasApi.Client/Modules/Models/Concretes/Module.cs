using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models
{
    internal class Module : IModule
    {
        [JsonProperty("id")] public long? Id { get; set; }
        [JsonProperty("wokflow_state")] public IEnumerable<ModuleWorkflowState> WorkflowState { get; set; }
        [JsonProperty("position")] public int? Position { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("unlock_at")] public DateTime? UnlockAt { get; set; }
        [JsonProperty("require_sequential_progression")] public bool? RequireSequentialProgression { get; set; }
        [JsonProperty("prerequisite_module_ids")] public IEnumerable<Int32> PrerequisiteModuleIds { get; set; }
        [JsonProperty("items_count")] public int? ItemsCount { get; set; }
        [JsonProperty("items_url")] public string ItemsUrl { get; set; }
        [JsonProperty("items")] public IEnumerable<IModuleItem> Items { get; set; }
        [JsonProperty("state")] public IEnumerable<ModuleState> State { get; set; }
        [JsonProperty("completed_at")] public DateTime? CompletedAt { get; set; }
        [JsonProperty("publish_final_grade")] public bool? PublishFinalGrade { get; set; }
        [JsonProperty("published")] public bool? Published { get; set; }
    }
}
