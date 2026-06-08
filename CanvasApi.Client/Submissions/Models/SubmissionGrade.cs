namespace CanvasApi.Client.Submissions.Models;

internal class SubmissionGrade : ISubmissionGrade
{
    public ISubmissionGradeDetail Submission { get; set; }
    public ISubmissionSubmitComment Comment { get; set; }
}
