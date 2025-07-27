namespace CanvasApi.Client.Enrollments.Models;

internal class Enrollment : IEnrollment
{
    public long Id { get; set; }
    public long CourseId { get; set; }
    public string SisCourseId { get; set; }
    public string CourseIntegrationId { get; set; }
    public int? CourseSectionId { get; set; }
    public string SectionIntegrationId { get; set; }
    public string SisAccountId { get; set; }
    public string SisSectionId { get; set; }
    public string SisUserId { get; set; }
    public string EnrollmentState { get; set; }
    public bool? LimitPrivilegesToCourseSection { get; set; }
    public long? SisImportId { get; set; }
    public long? RootAccountId { get; set; }
    public string Type { get; set; }
    public long? UserId { get; set; }
    public string AssociatedUserId { get; set; }
    public string Role { get; set; }
    public long? RoleId { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? StartAt { get; set; }
    public DateTime? EndAt { get; set; }
    public DateTime? LastActivityAt { get; set; }
    public DateTime? LastAttendedAt { get; set; }
    public long? TotalActivityTime { get; set; }
    public string HtmlUrl { get; set; }
    public Grade Grades { get; set; }
    public UserDisplay User { get; set; }
    public string OverrideGrade { get; set; }
    public decimal? OverrideScore { get; set; }
    public string UnpostedCurrentGrade { get; set; }
    public string UnpostedFinalGrade { get; set; }
    public string UnpostedCurrentScore { get; set; }
    public string UnpostedFinalScore { get; set; }
    public bool? HasGradingPeriods { get; set; }
    public bool? TotalsForAllGradingPeriodsOption { get; set; }
    public string CurrentGradingPeriodTitle { get; set; }
    public long? CurrentGradingPeriodId { get; set; }
    public string CurrentPeriodOverrideGrade { get; set; }
    public decimal? CurrentPeriodOverrideScore { get; set; }
    public decimal? CurrentPeriodUnpostedCurrentScore { get; set; }
    public decimal? CurrentPeriodUnpostedFinalScore { get; set; }
    public string CurrentPeriodUnpostedCurrentGrade { get; set; }
    public string CurrentPeriodUnpostedFinalGrade { get; set; }

    IGrade IEnrollment.Grades => this.Grades;
    IUserDisplay IEnrollment.User => this.User;
}