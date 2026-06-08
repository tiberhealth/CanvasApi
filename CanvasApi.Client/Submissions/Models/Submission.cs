namespace CanvasApi.Client.Submissions.Models;

internal class Submission : ISubmission
{
    public long AssignmentId { get; set; }

    public Assignment Assignment { get; set; }
    IAssignment ISubmission.Assignment => this.Assignment;

    public ICourse Course { get; set; }
    ICourse ISubmission.Course => this.Course;

    public int? Attempt { get; set; }
    public string Body { get; set; }
    public string Grade { get; set; }
    public bool? GradeMatchesCurrentSubmission { get; set; }
    public string HtmlUrl { get; set; }
    public string PreviewUrl { get; set; }
    public decimal? Score { get; set; }

    public IEnumerable<SubmissionComment> SubmissionComments { get; set; }
    IEnumerable<ISubmissionComment> ISubmission.SubmissionComments => this.SubmissionComments;

    public string SubmissionType { get; set; }
    public DateTime? SubmittedAt { get; set; }
    public string Url { get; set; }
    public long? UserId { get; set; }
    public long? GraderId { get; set; }
    public DateTime? GradedAt { get; set; }

    public UserDisplay User { get; set; }
    IUserDisplay ISubmission.User => this.User;

    public bool? Late { get; set; }
    public bool? AssignmentVisible { get; set; }
    public bool? Excused { get; set; }
    public bool? Missing { get; set; }
    public string LatePolicyStatus { get; set; }
    public decimal? PointsDeducted { get; set; }
    public long? SecondsLate { get; set; }
    public string WorkflowState { get; set; }
    public int? ExtraAttempts { get; set; }
    public string AnonymousId { get; set; }
    public DateTime? PostedAt { get; set; }
}