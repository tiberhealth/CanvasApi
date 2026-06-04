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

public static class ISubmissionGradeHelpers
{
    public static ISubmissionGradeDetail GetSubmission(this ISubmissionGrade body, bool attachNew = true)
    {
        var detail = body.Submission ?? new SubmissionGradeDetail();
        if (attachNew && body.Submission == null) body.Submission = detail;
        return detail;
    }

    public static ISubmissionSubmitComment GetComment(this ISubmissionGrade body, bool attachNew = true)
    {
        var comment = body.Comment ?? new SubmissionSubmitComment();
        if (attachNew && body.Comment == null) body.Comment = comment;
        return comment;
    }
}
