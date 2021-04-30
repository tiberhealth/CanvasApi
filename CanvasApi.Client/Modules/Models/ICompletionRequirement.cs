using CanvasApi.Client.Modules.Enums;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface ICompletionRequirement
    {
        /// <summary>
        /// one of 'must_view', 'must_submit', 'must_contribute', 'min_score',
        /// 'must_mark_done'
        /// </summary>
        [Multipart("completed")] public bool? Completed { get; }
        /// <summary>
        /// minimum score required to complete (only present when type == 'min_score')
        /// </summary>
        [Multipart("min_score")] public int? MinScore { get; }
        /// <summary>
        /// whether the calling user has met this requirement (Optional; present only if
        /// the caller is a student or if the optional parameter 'student_id' is
        /// included)
        /// </summary>
        [Multipart("type")] public CompletionRequirementTypes Type { get; }
    }
}