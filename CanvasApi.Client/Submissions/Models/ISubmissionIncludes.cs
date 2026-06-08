namespace CanvasApi.Client.Submissions.Models;

public interface ISubmissionIncludes
{
    IEnumerable<SubmissionListInclude> Includes { get; set; }
    bool? Grouped { get; }
}