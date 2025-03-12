namespace CanvasApi.Client.Assignments.Models;

public interface IAssignmentGetOptions
{
    /// <summary>
    /// sociations to include with the group. “discussion_topic” and “assignment_visibility” and “submission” are only valid if “assignments” is also included. “score_statistics” is only valid if “submission” and “assignments” are also included. The “assignment_visibility” option additionally requires that the Differentiated Assignments course feature be turned on.
    ///
    /// Allowed values:
    /// assignments, discussion_topic, assignment_visibility, submission, score_statistics
    /// </summary>
    IEnumerable<AssignmentGetIncludes> Include { get; set; }

    /// <summary>
    /// Apply assignment overrides for each assignment, defaults to true
    /// </summary>
    bool? OverrideAssignmentDates { get; set; }

    /// <summary>
    /// Split up “needs_grading_count” by sections into the “needs_grading_count_by_section” key, defaults to false
    /// </summary>
    bool? NeedsGradingCountBySection { get; set; }

    /// <summary>
    /// All dates associated with the assignment, if applicable
    /// </summary>
    bool? AllDates { get; set; }
}
