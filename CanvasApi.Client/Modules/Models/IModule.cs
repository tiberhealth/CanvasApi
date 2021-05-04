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
        long Id { get; }
        /// <summary>
        /// the state of the module: 'active', 'deleted'
        /// </summary>
        IEnumerable<ModuleWorkflowState> WorkflowState { get; }
        /// <summary>
        /// the position of this module in the course (1-based)
        /// </summary>
        int? Position { get; }
        /// <summary>
        /// the name of this module
        /// </summary>
        string Name { get; }
        /// <summary>
        /// (Optional) the date this module will unlock
        /// </summary>
        DateTime? UnlockAt { get; }
        /// <summary>
        /// Whether module items must be unlocked in order
        /// </summary>
        bool? RequireSequentialProgression { get; }
        /// <summary>
        /// IDs of Modules that must be completed before this one is unlocked
        /// </summary>
        IEnumerable<int> PrerequisiteModuleIds { get; }
        /// <summary>
        /// The number of items in the module
        /// </summary>
        int? ItemsCount { get; }
        /// <summary>
        /// The API URL to retrive this module's items
        /// </summary>
        string ItemsUrl { get; }
        /// <summary>
        /// The contents of this module, as an array of Module Items. (Present only if
        /// requested via include[]=items AND the module is not deemed too large by
        /// Canvas.)
        /// </summary>
        IEnumerable<IModuleItem> Items { get; }
        /// <summary>
        /// The state of this Module for the calling user one of 'locked', 'unlocked',
        /// 'started', 'completed' (Optional; present only if the caller is a student or
        /// if the optional parameter 'student_id' is included)
        /// </summary>
        IEnumerable<ModuleState> State { get; }
        /// <summary>
        /// the date the calling user completed the module (Optional; present only if the
        /// caller is a student or if the optional parameter 'student_id' is included)
        /// </summary>
        DateTime? CompletedAt { get; }
        /// <summary>
        /// if the student's final grade for the course should be published to the SIS
        /// upon completion of this module
        /// </summary>
        bool? PublishFinalGrade { get; }
        /// <summary>
        /// (Optional) Whether this module is published. This field is present only if
        /// the caller has permission to view unpublished modules.
        /// </summary>
        bool? Published { get; }
        
        
    }
}