namespace CanvasApi.Client.Submissions.Models;

internal class SubmissionSubmit : ISubmissionSubmit
{
    public ISubmissionSubmitComment Comment { get; set; }
    public ISubmissionSubmitDetail Submission { get; set; }
}