namespace CanvasApi.Client.Submissions.Models;

/// <summary>
/// Top-level body for the "grade or comment on a submission" Canvas endpoint.
/// Wraps an <see cref="ISubmissionGradeDetail"/> so the multipart serializer
/// emits <c>submission[posted_grade]</c>, <c>submission[excuse]</c>, etc.
/// </summary>
public interface ISubmissionGrade
{
    /// <summary>
    /// The submission fields. Serialized as <c>submission[posted_grade]</c>, etc.
    /// </summary>
    ISubmissionGradeDetail Submission { get; set; }

    /// <summary>
    /// Optional grader comment posted alongside the grade.
    /// </summary>
    ISubmissionSubmitComment Comment { get; set; }
}
