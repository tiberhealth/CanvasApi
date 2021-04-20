using System;
using System.Collections.Generic;
using CanvasApi.Client.Enrollments.Models;
using CanvasApi.Client.EnrollmentTerms.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.Courses.Models
{
    internal class Course : ICourse
    {
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("sis_course_id")] public string SisCourseId { get; set; }
        [JsonProperty("uuid")] public string Uuid { get; set; }
        [JsonProperty("integration_id")] public string IntegrationId { get; set; }
        [JsonProperty("sis_import_id")] public long? SisImportId { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("course_code")] public string CourseCode { get; set; }
        [JsonProperty("workflow_state")] public string WorkflowState { get; set; }
        [JsonProperty("account_id")] public long? AccountId { get; set; }
        [JsonProperty("root_account_id")] public long? RootAccountId { get; set; }
        [JsonProperty("enrollment_term_id")] public long? EnrollmentTermId { get; set; }
        [JsonProperty("grading_standard_id")] public long? GradingStandardId { get; set; }
        [JsonProperty("grade_passback_setting")] public string GradePassbackSetting { get; set; }
        [JsonProperty("created_at")] public DateTime? CreatedAt { get; set; }
        [JsonProperty("start_at")] public DateTime? StartAt { get; set; }
        [JsonProperty("end_at")] public DateTime? EndAt { get; set; }
        [JsonProperty("locale")] public string Locale { get; set; }

        [JsonProperty("enrollments")] public IEnumerable<Enrollment> Enrollments { get; set; }
        IEnumerable<IEnrollment> ICourse.Enrollments => this.Enrollments;

        [JsonProperty("total_students")] public int? TotalStudents { get; set; }

        [JsonProperty("calendar")] public CalendarLink Calendar { get; set; }
        ICalendarLink ICourse.Calendar => this.Calendar;

        [JsonProperty("default_view")] public string DefaultView { get; set; }
        [JsonProperty("syllabus_body")] public string SyllabusBody { get; set; }
        [JsonProperty("needs_grading_count")] public int? NeedsGradingCount { get; set; }

        [JsonProperty("term")] public EnrollmentTerm Term { get; set; }
        IEnrollmentTerm ICourse.EnrollmentTerm => this.Term;

        [JsonProperty("course_progress")] public ICourseProgress CourseProgress { get; set; }
        ICourseProgress ICourse.CourseProgress => this.CourseProgress;

        [JsonProperty("apply_assignment_group_weights")] public bool? ApplyAssignmentGroupWeights { get; set; }
        [JsonProperty("permissions")] public JObject Permissions { get; set; }
        [JsonProperty("is_public")] public bool? IsPublic { get; set; }
        [JsonProperty("is_public_to_auth_users")] public bool? IsPublicToAuthUsers { get; set; }
        [JsonProperty("public_syllabus")] public bool? PublicSyllabus { get; set; }
        [JsonProperty("public_syllabus_to_auth")] public bool? PublicSyllabusToAuth { get; set; }
        [JsonProperty("public_description")] public string PublicDescription { get; set; }
        [JsonProperty("storage_quota_mb")] public decimal? StorageQuotaMb { get; set; }
        [JsonProperty("storage_quota_used_mb")] public decimal? StorageQuotaUsedMb { get; set; }
        [JsonProperty("hide_final_grades")] public bool? HideFinalGrades { get; set; }
        [JsonProperty("license")] public string License { get; set; }
        [JsonProperty("allow_student_assignment_edits")] public bool? AllowStudentAssignmentEdits { get; set; }
        [JsonProperty("allow_wiki_comments")] public bool? AllowWikiComments { get; set; }
        [JsonProperty("allow_student_forum_attachments")] public bool? AllowStudentForumAttachments { get; set; }
        [JsonProperty("open_enrollment")] public bool? OpenEnrollment { get; set; }
        [JsonProperty("self_enrollment")] public bool? SelfEnrollment { get; set; }
        [JsonProperty("restrict_enrollments_to_course_dates")] public bool? RestrictEnrollmentsToCourseDates { get; set; }
        [JsonProperty("course_format")] public string CourseFormat { get; set; }
        [JsonProperty("access_restricted_by_date")] public bool? AccessRestrictedByDate { get; set; }
        [JsonProperty("time_zone")] public string TimeZone { get; set; }
        [JsonProperty("blueprint")] public bool? Blueprint { get; set; }
        [JsonProperty("blueprint_restrictions")] public JObject BlueprintRestrictions { get; set; }
        [JsonProperty("blueprint_restrictions_by_object_type")] public JObject BlueprintRestrictionsByObjectType { get; set; }
    }
}
