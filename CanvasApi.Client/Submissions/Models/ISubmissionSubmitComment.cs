using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Models
{
    public interface ISubmissionSubmitComment
    {
        /// <summary>
        /// Include a textual comment with the submission
        /// </summary>
        [Multipart("text_comment")] string TextComment { get; set; }
    }
}
