using System;
namespace CanvasApi.Client.Submissions.Models
{
    public class SubmissionSubmit : ISubmissionSubmit
    {
        public ISubmissionSubmitComment Comment { get; set; }
        public ISubmissionSubmitDetail Submission { get; set; }
    }
}
