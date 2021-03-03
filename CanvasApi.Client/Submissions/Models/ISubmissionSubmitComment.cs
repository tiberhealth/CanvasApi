using System;
using Newtonsoft.Json;

namespace CanvasApi.Client.Submissions.Models
{
    public interface ISubmissionSubmitComment
    {
        /// <summary>
        /// Include a textual comment with the submission
        /// </summary>
        [JsonProperty("text_comment")] string TextComment { get; set; }
    }
}
