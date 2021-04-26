namespace CanvasApi.Client.Submissions.Models.Concretes
{
    internal class SubmissionSubmit : ISubmissionSubmit
    {
        public ISubmissionSubmitComment Comment { get; set; }
        public ISubmissionSubmitDetail Submission { get; set; }
    }
}
