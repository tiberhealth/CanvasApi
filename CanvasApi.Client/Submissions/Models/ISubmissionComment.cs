using System;
using CanvasApi.Client.Users.Models;

namespace CanvasApi.Client.Submissions.Models
{
    public interface ISubmissionComment
    {
        long Id { get; }
        long? AuthorId { get; }
        string AuthorName { get; }
        /// <summary>
        /// Abbreviated user object UserDisplay (see users API). 
        /// </summary>
        IUserDisplay Author { get; }
        string Comment { get; }
        DateTime? CreatedAt { get; }
        DateTime? EditedAt { get; }
        string MediaComment { get; }
    }
}
