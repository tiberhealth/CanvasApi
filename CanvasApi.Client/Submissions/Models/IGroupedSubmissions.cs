using System.Collections.Generic;

namespace CanvasApi.Client.Submissions.Models
{
    public interface IGroupedSubmissions
    {
        long UserId { get; }
        IEnumerable<ISubmission> Submissions { get; }
     }
}
