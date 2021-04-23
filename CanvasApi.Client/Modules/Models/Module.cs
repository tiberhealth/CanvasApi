using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models
{
    internal class Module
    {
        [JsonProperty("id")] public long Id { get; set; }
        //[JsonProperty("wokflow_state")] public IEnumerable<ModuleWorkflowState> WorkflowState { get; set; }
        [JsonProperty("position")] public int Position { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("require_sequential_progression")] public bool RequireSequentialProgression { get; set; }
        [JsonProperty("prerequisite_module_ids")] public int[] PrerequisiteModuleIds { get; set; }
        [JsonProperty("items_count")] public int ItemsCount { get; set; }
        [JsonProperty("items_url")] public string ItemsUrl { get; set; }
        //[JsonProperty("items")] public IModuleItem[] Items { get; set; }
        [JsonProperty("publish_final_grade")] public bool PublishFinalGrade { get; set; }
    }
}
