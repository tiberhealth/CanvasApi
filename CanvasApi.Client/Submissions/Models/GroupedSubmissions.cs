namespace CanvasApi.Client.Submissions.Models;

internal class GroupedSubmissions : IGroupedSubmissions
{
    public long UserId { get; set; }
    public IEnumerable<Submission> Submissions { get; set; }
    IEnumerable<ISubmission> IGroupedSubmissions.Submissions => Submissions;
}