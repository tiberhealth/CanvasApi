using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModule
    {
        [Multipart("completed_at", DateTimeFormat = "yyyy-MM-dd HH:mm:sszzz")] DateTime? CompletedAt { get; set; }
        [JsonProperty("id")] long? Id { get; set; }
        [JsonProperty("items")] IEnumerable<IModuleItem> Items { get; set; }
        [JsonProperty("items_count")] int? ItemsCount { get; set; }
        [JsonProperty("items_url")] string ItemsUrl { get; set; }
        [JsonProperty("name")] string Name { get; set; }
        [JsonProperty("position")] int? Position { get; set; }
        [JsonProperty("prerequisite_module_ids")] IEnumerable<int> PrerequisiteModuleIds { get; set; }
        [JsonProperty("published")] bool? Published { get; set; }
        [JsonProperty("publish_final_grade")] bool? PublishFinalGrade { get; set; }
        [JsonProperty("require_sequential_progress")] bool? RequireSequentialProgression { get; set; }
        [JsonProperty("state")] IEnumerable<ModuleState> State { get; set; }
        [Multipart("unlock_at", DateTimeFormat = "yyyy-MM-dd HH:mm:sszzz")] DateTime? UnlockAt { get; set; }
        [JsonProperty("workflow_state")] IEnumerable<ModuleWorkflowState> WorkflowState { get; set; }
    }
}