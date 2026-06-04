namespace CanvasApi.Client.Submissions.Models;

/// <summary>
/// Extension helpers for <see cref="ISubmissionGrade"/>.
/// Lives in its own file (and uses a non-I-prefixed class name) so each file
/// has exactly one top-level type.
/// </summary>
public static class SubmissionGradeExtensions
{
    /// <summary>Returns the inner submission detail, attaching a fresh one if missing.</summary>
    public static ISubmissionGradeDetail GetSubmission(this ISubmissionGrade body, bool attachNew = true)
    {
        var detail = body.Submission ?? new SubmissionGradeDetail();
        if (attachNew && body.Submission == null) body.Submission = detail;
        return detail;
    }

    /// <summary>Returns the optional comment record, attaching a fresh one if missing.</summary>
    public static ISubmissionSubmitComment GetComment(this ISubmissionGrade body, bool attachNew = true)
    {
        var comment = body.Comment ?? new SubmissionSubmitComment();
        if (attachNew && body.Comment == null) body.Comment = comment;
        return comment;
    }
}
