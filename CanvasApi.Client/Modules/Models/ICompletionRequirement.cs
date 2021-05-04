using CanvasApi.Client.Modules.Enums;

namespace CanvasApi.Client.Modules.Models
{
    public interface ICompletionRequirement
    {
        /// <summary>
        /// one of 'must_view', 'must_submit', 'must_contribute', 'min_score',
        /// 'must_mark_done'
        /// </summary>
        CompletionRequirementTypes? CompletionType { get; set; }

        /// <summary>
        /// minimum score required to complete (only present when type == 'min_score')
        /// </summary>
        int? MinScore { get; set; }

        /// <summary>
        /// whether the calling user has met this requirement (Optional; present only if
        /// the caller is a student or if the optional parameter 'student_id' is
        /// included)
        /// </summary>
        bool? Completed { get; set; }

    }
}
