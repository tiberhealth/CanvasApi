using System;
using System.Collections.Generic;
using CanvasApi.Client.Submissions.Enums;

namespace CanvasApi.Client.Submissions.Models.Concretes
{
    internal class SubmissionSubmitDetail : ISubmissionSubmitDetail
    {
        public SubmissionTypes SubmissionType { get; set; }
        public string Body { get; set; }
        public string Url { get; set; }
        public IEnumerable<long> FileIds { get; set; }
        public string MediaCommentId { get; set; }
        public MediaCommentTypes? MediaCommentType { get; set; }
        public long? UserId { get; set; }
        public DateTime? SubmittedAt { get; set; }
    }
}
