using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    internal class Module : IModule
    {
        [Multipart("id")] public long? Id { get; set; }
        [Multipart("wokflow_state")] public IEnumerable<ModuleWorkflowState> WorkflowState { get; set; }
        [Multipart("position")] public int? Position { get; set; }
        [Multipart("name")] public string Name { get; set; }
        [Multipart("unlock_at")] public DateTime? UnlockAt { get; set; }
        [Multipart("require_sequential_progression")] public bool? RequireSequentialProgression { get; set; }
        [Multipart("prerequisite_module_ids")] public IEnumerable<int> PrerequisiteModuleIds { get; set; }
        [Multipart("items_count")] public int? ItemsCount { get; set; }
        [Multipart("items_url")] public string ItemsUrl { get; set; }
        [Multipart("items")] public IEnumerable<ModuleItem> Items { get; set; }
        IEnumerable<IModuleItem> IModule.Items => this.Items;
        [Multipart("state")] public IEnumerable<ModuleState> State { get; set; }
        [Multipart("completed_at")] public DateTime? CompletedAt { get; set; }
        [Multipart("publish_final_grade")] public bool? PublishFinalGrade { get; set; }
        [Multipart("published")] public bool? Published { get; set; }
    }
}
