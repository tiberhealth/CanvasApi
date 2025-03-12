﻿using SubmissionTypes = CanvasApi.Client.Submissions.Enums.SubmissionTypes;

namespace CanvasApi.Client.Submissions.Models;

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