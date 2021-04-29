using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModule
    {
        /// <summary>
        /// the unique identifier for the module
        /// </summary>
        [Multipart("id")] long Id { get; }
        /// <summary>
        /// the state of the module: 'active', 'deleted'
        /// </summary>
        [Multipart("workflow_state")] IEnumerable<ModuleWorkflowState> WorkflowState { get; }
        /// <summary>
        /// the position of this module in the course (1-based)
        /// </summary>
        [Multipart("position")] int? Position { get; }
        /// <summary>
        /// the name of this module
        /// </summary>
        [Multipart("name")] string Name { get; }
        /// <summary>
        /// (Optional) the date this module will unlock
        /// </summary>
        [Multipart("unlock_at", DateTimeFormat = "yyyy-MM-dd HH:mm:sszzz")] DateTime? UnlockAt { get; }
        /// <summary>
        /// Whether module items must be unlocked in order
        /// </summary>
        [Multipart("require_sequential_progress")] bool? RequireSequentialProgression { get; }
        /// <summary>
        /// IDs of Modules that must be completed before this one is unlocked
        /// </summary>
        [Multipart("prerequisite_module_ids")] IEnumerable<int> PrerequisiteModuleIds { get; }
        /// <summary>
        /// The number of items in the module
        /// </summary>
        [Multipart("items_count")] int? ItemsCount { get; }
        /// <summary>
        /// The API URL to retrive this module's items
        /// </summary>
        [Multipart("items_url")] string ItemsUrl { get; }
        /// <summary>
        /// The contents of this module, as an array of Module Items. (Present only if
        /// requested via include[]=items AND the module is not deemed too large by
        /// Canvas.)
        /// </summary>
        [Multipart("items")] IEnumerable<IModuleItem> Items { get; }
        /// <summary>
        /// The state of this Module for the calling user one of 'locked', 'unlocked',
        /// 'started', 'completed' (Optional; present only if the caller is a student or
        /// if the optional parameter 'student_id' is included)
        /// </summary>
        [Multipart("state")] IEnumerable<ModuleState> State { get; }
        /// <summary>
        /// the date the calling user completed the module (Optional; present only if the
        /// caller is a student or if the optional parameter 'student_id' is included)
        /// </summary>
        [Multipart("completed_at", DateTimeFormat = "yyyy-MM-dd HH:mm:sszzz")] DateTime? CompletedAt { get; }
        /// <summary>
        /// if the student's final grade for the course should be published to the SIS
        /// upon completion of this module
        /// </summary>
        [Multipart("publish_final_grade")] bool? PublishFinalGrade { get; }
        /// <summary>
        /// (Optional) Whether this module is published. This field is present only if
        /// the caller has permission to view unpublished modules.
        /// </summary>
        [Multipart("published")] bool? Published { get; }
        
        
    }
}