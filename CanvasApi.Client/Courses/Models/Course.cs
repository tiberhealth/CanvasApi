namespace CanvasApi.Client.Courses.Models;

internal class Course : ICourse
{
    public long Id { get; set; }
    public string SisCourseId { get; set; }
    public string Uuid { get; set; }
    public string IntegrationId { get; set; }
    public long? SisImportId { get; set; }
    public string Name { get; set; }
    public string CourseCode { get; set; }
    public string WorkflowState { get; set; }
    public long? AccountId { get; set; }
    public long? RootAccountId { get; set; }
    public long? EnrollmentTermId { get; set; }
    public long? GradingStandardId { get; set; }
    public string GradePassbackSetting { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? StartAt { get; set; }
    public DateTime? EndAt { get; set; }
    public string Locale { get; set; }

    public IEnumerable<Enrollment> Enrollments { get; set; }
    IEnumerable<IEnrollment> ICourse.Enrollments => Enrollments;

    public int? TotalStudents { get; set; }

    public CalendarLink Calendar { get; set; }
    ICalendarLink ICourse.Calendar => Calendar;

    public string DefaultView { get; set; }
    public string SyllabusBody { get; set; }
    public int? NeedsGradingCount { get; set; }

    public EnrollmentTerm Term { get; set; }
    IEnrollmentTerm ICourse.EnrollmentTerm => Term;

    public ICourseProgress CourseProgress { get; set; }
    ICourseProgress ICourse.CourseProgress => CourseProgress;

    public bool? ApplyAssignmentGroupWeights { get; set; }
    public JObject Permissions { get; set; }
    public bool? IsPublic { get; set; }
    public bool? IsPublicToAuthUsers { get; set; }
    public bool? PublicSyllabus { get; set; }
    public bool? PublicSyllabusToAuth { get; set; }
    public string PublicDescription { get; set; }
    public decimal? StorageQuotaMb { get; set; }
    public decimal? StorageQuotaUsedMb { get; set; }
    public bool? HideFinalGrades { get; set; }
    public string License { get; set; }
    public bool? AllowStudentAssignmentEdits { get; set; }
    public bool? AllowWikiComments { get; set; }
    public bool? AllowStudentForumAttachments { get; set; }
    public bool? OpenEnrollment { get; set; }
    public bool? SelfEnrollment { get; set; }
    public bool? RestrictEnrollmentsToCourseDates { get; set; }
    public string CourseFormat { get; set; }
    public bool? AccessRestrictedByDate { get; set; }
    public string TimeZone { get; set; }
    public bool? Blueprint { get; set; }
    public JObject BlueprintRestrictions { get; set; }
    public JObject BlueprintRestrictionsByObjectType { get; set; }
}