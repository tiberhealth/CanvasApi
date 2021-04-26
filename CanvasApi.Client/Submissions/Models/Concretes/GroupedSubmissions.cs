using System.Collections.Generic;

namespace CanvasApi.Client.Submissions.Models.Concretes
{
    internal class GroupedSubmissions : IGroupedSubmissions
    {
        public long UserId { get; set; }
        public IEnumerable<Submission> Submissions { get; set; }
        IEnumerable<ISubmission> IGroupedSubmissions.Submissions => this.Submissions;
    }
}
