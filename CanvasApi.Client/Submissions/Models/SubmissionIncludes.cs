namespace CanvasApi.Client.Submissions.Models;

internal class SubmissionIncludes : ISubmissionIncludes
{
    public SubmissionIncludes() { }

    public IEnumerable<SubmissionListInclude> Includes { get; set; }
    public bool? Grouped { get; set; }
}