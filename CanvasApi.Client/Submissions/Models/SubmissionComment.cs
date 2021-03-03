using System;
using CanvasApi.Client.Users.Models;
using Newtonsoft.Json;

namespace CanvasApi.Client.Submissions.Models
{
    internal class SubmissionComment : ISubmissionComment
    {
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("author_id")] public long? AuthorId { get; set; }
        [JsonProperty("author_name")] public string AuthorName { get; set; }

        [JsonProperty("author")] public UserDisplay Author { get; set; }
        IUserDisplay ISubmissionComment.Author => this.Author;

        [JsonProperty("comment")] public string Comment { get; set; }
        [JsonProperty("created_at")] public DateTime? CreatedAt { get; set; }
        [JsonProperty("edited_at")] public DateTime? EditedAt { get; set; }
        [JsonProperty("media_comment")] public string MediaComment { get; set; }
    }
}
