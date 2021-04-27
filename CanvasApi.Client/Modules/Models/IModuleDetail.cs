using System;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    public interface IModuleDetail
    {
        [Multipart("name")] string Name { get; set; }
        [Multipart("position")] int? Position { get; set; }
        [Multipart("prerequisite_id_modules")] IEnumerable<int> PrerequisiteModuleIds { get; set; }
        [Multipart("published")] bool? Published { get; set; }
        [Multipart("publish_final_grade")] bool? PublishFinalGrade { get; set; }
        [Multipart("require_sequential_progress")] bool? RequireSequentialProgress { get; set; }
        [Multipart("unlock_at")] DateTime? UnlockAt { get; set; }
    }
}