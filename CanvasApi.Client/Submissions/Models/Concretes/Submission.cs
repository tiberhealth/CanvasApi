using System;
using System.Collections;
using System.Collections.Generic;
using CanvasApi.Client.Assignments.Models;
using CanvasApi.Client.Assignments.Models.Concretes;
using CanvasApi.Client.Courses.Models;
using CanvasApi.Client.Users.Models;
using CanvasApi.Client.Users.Models.Concretes;
using Newtonsoft.Json;

namespace CanvasApi.Client.Submissions.Models.Concretes
{
    internal class Submission : ISubmission
    {
        [JsonProperty("assignment_id")] public long AssignmentId { get; set; }

        [JsonProperty("assignment")] public Assignment Assignment { get; set; }
        IAssignment ISubmission.Assignment => this.Assignment;

        [JsonProperty("course")] public ICourse Course { get; set; }
        ICourse ISubmission.Course => this.Course;

        [JsonProperty("attempt")] public int? Attempt { get; set; }
        [JsonProperty("body")] public string Body { get; set; }
        [JsonProperty("grade")] public string Grade { get; set; }
        [JsonProperty("grade_matches_current_submission")] public bool? GradeMatchesCurrentSubmission { get; set; }
        [JsonProperty("html_url")] public string HtmlUrl { get; set; }
        [JsonProperty("preview_url")] public string PreviewUrl { get; set; }
        [JsonProperty("score")] public decimal? Score { get; set; }

        [JsonProperty("submission_comments")] public IEnumerable<SubmissionComment> SubmissionComments { get; set; }
        IEnumerable<ISubmissionComment> ISubmission.SubmissionComments => this.SubmissionComments;

        [JsonProperty("submission_type")] public string SubmissionType { get; set; }
        [JsonProperty("submitted_at")] public DateTime? SubmittedAt { get; set; }
        [JsonProperty("url")] public string Url { get; set; }
        [JsonProperty("user_id")] public long? UserId { get; set; }
        [JsonProperty("grader_id")] public long? GraderId { get; set; }
        [JsonProperty("graded_at")] public DateTime? GradedAt { get; set; }

        [JsonProperty("user")] public UserDisplay User { get; set; }
        IUserDisplay ISubmission.User => this.User;

        [JsonProperty("late")] public bool? Late { get; set; }
        [JsonProperty("assignment_visible")] public bool? AssignmentVisible { get; set; }
        [JsonProperty("excused")] public bool? Excused { get; set; }
        [JsonProperty("missing")] public bool? Missing { get; set; }
        [JsonProperty("late_policy_status")] public string LatePolicyStatus { get; set; }
        [JsonProperty("points_deducted")] public decimal? PointsDeducted { get; set; }
        [JsonProperty("seconds_late")] public long? SecondsLate { get; set; }
        [JsonProperty("workflow_state")] public string WorkflowState { get; set; }
        [JsonProperty("extra_attempts")] public int? ExtraAttempts { get; set; }
        [JsonProperty("anonymous_id")] public string AnonymousId { get; set; }
        [JsonProperty("posted_at")] public DateTime? PostedAt { get; set; }
    }
}
