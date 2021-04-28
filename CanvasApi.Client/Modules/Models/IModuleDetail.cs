using System;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    public interface IModuleDetail
    {
        /// <summary>
        /// The name of the module
        /// </summary>
        [Multipart("name")] string Name { get; set; }
        /// <summary>
        /// The position of this module in the course (1-based)
        /// </summary>
        [Multipart("position")] int? Position { get; set; }
        /// <summary>
        /// IDs of Modules that must be completed before this one is unlocked. Prerequisite modules must precede this module (i.e. have a lower position value), otherwise they will be ignored
        /// </summary>
        [Multipart("prerequisite_id_modules")] IEnumerable<int> PrerequisiteModuleIds { get; set; }
        /// <summary>
        /// Whether the module is published and visible to students
        /// </summary>
        [Multipart("published")] bool? Published { get; set; }
        /// <summary>
        /// Whether to publish the student's final grade for the course upon completion of this module.
        /// </summary>
        [Multipart("publish_final_grade")] bool? PublishFinalGrade { get; set; }
        /// <summary>
        /// Whether module items must be unlocked in order
        /// </summary>
        [Multipart("require_sequential_progress")] bool? RequireSequentialProgress { get; set; }
        /// <summary>
        /// The date the module will unlock
        /// </summary>
        [Multipart("unlock_at")] DateTime? UnlockAt { get; set; }
    }
}