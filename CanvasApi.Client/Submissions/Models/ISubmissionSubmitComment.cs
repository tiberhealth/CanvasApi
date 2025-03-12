namespace CanvasApi.Client.Submissions.Models;

public interface ISubmissionSubmitComment
{
    /// <summary>
    /// Include a textual comment with the submission
    /// </summary>
    string TextComment { get; set; }
}