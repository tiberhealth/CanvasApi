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
        [Multipart("id")] long? Id { get; set; }
        [Multipart("items")] IEnumerable<IModuleItem> Items { get; set; }
        [Multipart("items_count")] int? ItemsCount { get; set; }
        [Multipart("items_url")] string ItemsUrl { get; set; }
        [Multipart("name")] string Name { get; set; }
        [Multipart("position")] int? Position { get; set; }
        [Multipart("prerequisite_module_ids")] IEnumerable<int> PrerequisiteModuleIds { get; set; }
        [Multipart("published")] bool? Published { get; set; }
        [Multipart("publish_final_grade")] bool? PublishFinalGrade { get; set; }
        [Multipart("require_sequential_progress")] bool? RequireSequentialProgression { get; set; }
        [Multipart("state")] IEnumerable<ModuleState> State { get; set; }
        [Multipart("unlock_at", DateTimeFormat = "yyyy-MM-dd HH:mm:sszzz")] DateTime? UnlockAt { get; set; }
        [Multipart("workflow_state")] IEnumerable<ModuleWorkflowState> WorkflowState { get; set; }
    }
}