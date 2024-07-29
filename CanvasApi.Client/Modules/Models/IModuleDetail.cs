using System;
using System.Collections.Generic;

namespace CanvasApi.Client.Modules.Models
{
    public interface IModuleDetail
    {
        /// <summary>
        /// The name of the module
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// The position of this module in the course (1-based)
        /// </summary>
        int? Position { get; set; }
        /// <summary>
        /// IDs of Modules that must be completed before this one is unlocked. Prerequisite modules must precede this module (i.e. have a lower position value), otherwise they will be ignored
        /// </summary>
        IEnumerable<int> PrerequisiteModuleIds { get; set; }
        /// <summary>
        /// Whether the module is published and visible to students
        /// </summary>
        bool? Published { get; set; }
        /// <summary>
        /// Whether to publish the student's final grade for the course upon completion of this module.
        /// </summary>
        bool? PublishFinalGrade { get; set; }
        /// <summary>
        /// Whether module items must be unlocked in order
        /// </summary>
        bool? RequireSequentialProgress { get; set; }
        /// <summary>
        /// The date the module will unlock
        /// </summary>
        DateTime? UnlockAt { get; set; }
    }
}