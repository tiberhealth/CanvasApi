namespace CanvasApi.Client.Submissions.Models;

/// <summary>
/// Inner submission[*] fields for the "Grade or comment on a submission"
/// Canvas endpoint.
/// Used by:
///     PUT /api/v1/courses/:course_id/assignments/:assignment_id/submissions/:user_id
/// </summary>
public interface ISubmissionGradeDetail
{
    /// <summary>
    /// The grade to assign the student. May be a numeric score, a letter grade,
    /// or a percent (e.g. "85.5%"). Required for grading.
    /// </summary>
    string PostedGrade { get; set; }

    /// <summary>
    /// Whether the assignment is excused for this student. If <c>true</c>,
    /// <see cref="PostedGrade"/> is ignored.
    /// </summary>
    bool? Excuse { get; set; }

    /// <summary>
    /// Late-policy override: "late", "missing", "extended", "none", or null.
    /// </summary>
    string LatePolicyStatus { get; set; }

    /// <summary>
    /// Number of seconds late if <see cref="LatePolicyStatus"/> is "late".
    /// </summary>
    int? SecondsLateOverride { get; set; }

    /// <summary>
    /// Sticker emoji code (Canvas custom-grade-status feature). Optional.
    /// </summary>
    string Sticker { get; set; }
}
