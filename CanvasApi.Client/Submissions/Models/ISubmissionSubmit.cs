namespace CanvasApi.Client.Submissions.Models;

public interface ISubmissionSubmit
{
    ISubmissionSubmitComment Comment { get; set; }
    ISubmissionSubmitDetail Submission { get; set; }
}

public static class ISubmissionSubmitHelpers
{
    /// <summary>
    /// Gets the comment record attached to the submission or creates a new one
    /// </summary>
    /// <param name="submission">Submission to get comment from</param>
    /// <param name="attachNew">If a new comment is generated, automatically attach it to the submission. (default true)</param>
    /// <returns>The submission comment</returns>
    public static ISubmissionSubmitComment GetComment(this ISubmissionSubmit submission, bool attachNew = true)
    {
        var comment = submission.Comment ?? new SubmissionSubmitComment();
        if (attachNew && submission.Comment == null) { submission.Comment = comment;  }

        return comment;
    }

    public static ISubmissionSubmitDetail GetSubmissionDetail(this ISubmissionSubmit submission, bool attachNew = true)
    {
        var submissionDetail = submission.Submission ?? new SubmissionSubmitDetail();
        if (attachNew && submission.Submission == null) submission.Submission = submissionDetail;

        return submissionDetail;
    }
}