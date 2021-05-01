using CanvasApi.Client.Modules.Enums;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface ICompletionRequirementDetail
    {
        /// <summary>
        /// Completion requirement for this module item. “must_view”: Applies to all item types “must_contribute”: Only applies to “Assignment”, “Discussion”, and “Page” types “must_submit”, “min_score”: Only apply to “Assignment” and “Quiz” types “must_mark_done”: Only applies to “Assignment” and “Page” types Inapplicable types will be ignored
        /// 
        /// Allowed values: <see cref="CompletionRequirementTypes"/>
        /// </summary>
        [Multipart("type")] CompletionRequirementTypes Type { get; set; }
        /// <summary>
        /// Minimum score required to complete. Required for completion_requirement type 'min_score'.
        /// </summary>
        [Multipart("min_score")] int? MinScore { get; set; }
    }
}