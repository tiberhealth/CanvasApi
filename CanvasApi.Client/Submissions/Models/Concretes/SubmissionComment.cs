using System;
using CanvasApi.Client.Users.Models;
using CanvasApi.Client.Users.Models.Concretes;

namespace CanvasApi.Client.Submissions.Models.Concretes
{
    internal class SubmissionComment : ISubmissionComment
    {
        public long Id { get; set; }
        public long? AuthorId { get; set; }
        public string AuthorName { get; set; }

        public UserDisplay Author { get; set; }
        IUserDisplay ISubmissionComment.Author => this.Author;

        public string Comment { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? EditedAt { get; set; }
        public string MediaComment { get; set; }
    }
}
