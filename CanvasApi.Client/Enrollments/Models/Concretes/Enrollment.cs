using System;
using CanvasApi.Client.Users.Models;
using CanvasApi.Client.Users.Models.Concretes;
using Newtonsoft.Json;

namespace CanvasApi.Client.Enrollments.Models.Concretes
{
    internal class Enrollment : IEnrollment
    {
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("course_id")] public long CourseId { get; set; }
        [JsonProperty("sis_course_id")] public string SisCourseId { get; set; }
        [JsonProperty("course_integration_id")] public string CourseIntegrationId { get; set; }
        [JsonProperty("course_section_id")] public int? CourseSectionId { get; set; }
        [JsonProperty("section_integration_id")] public string SectionIntegrationId { get; set; }
        [JsonProperty("sis_account_id")] public string SisAccountId { get; set; }
        [JsonProperty("sis_section_id")] public string SisSectionId { get; set; }
        [JsonProperty("sis_user_id")] public string SisUserId { get; set; }
        [JsonProperty("enrollment_state")] public string EnrollmentState { get; set; }
        [JsonProperty("limit_privileges_to_course_section")] public bool? LimitPrivilegesToCourseSection { get; set; }
        [JsonProperty("sis_import_id")] public long? SisImportId { get; set; }
        [JsonProperty("root_account_id")] public long? RootAccountId { get; set; }
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("user_id")] public long? UserId { get; set; }
        [JsonProperty("associated_user_id")] public string AssociatedUserId { get; set; }
        [JsonProperty("role")] public string Role { get; set; }
        [JsonProperty("role_id")] public long? RoleId { get; set; }
        [JsonProperty("created_at")] public DateTime? CreatedAt { get; set; }
        [JsonProperty("updated_at")] public DateTime? UpdatedAt { get; set; }
        [JsonProperty("start_at")] public DateTime? StartAt { get; set; }
        [JsonProperty("end_at")] public DateTime? EndAt { get; set; }
        [JsonProperty("last_activity_at")] public DateTime? LastActivityAt { get; set; }
        [JsonProperty("last_attended_at")] public DateTime? LastAttendedAt { get; set; }
        [JsonProperty("total_activity_time")] public long? TotalActivityTime { get; set; }
        [JsonProperty("html_url")] public string HtmlUrl { get; set; }
        [JsonProperty("grades")] internal Grade Grades { get; set; }
        [JsonProperty("user")] internal UserDisplay User { get; set; }
        [JsonProperty("override_grade")] public string OverrideGrade { get; set; }
        [JsonProperty("override_score")] public decimal? OverrideScore { get; set; }
        [JsonProperty("unposted_current_grade")] public string UnpostedCurrentGrade { get; set; }
        [JsonProperty("unposted_final_grade")] public string UnpostedFinalGrade { get; set; }
        [JsonProperty("unposted_current_score")] public string UnpostedCurrentScore { get; set; }
        [JsonProperty("unposted_final_score")] public string UnpostedFinalScore { get; set; }
        [JsonProperty("has_grading_periods")] public bool? HasGradingPeriods { get; set; }
        [JsonProperty("totals_for_all_grading_periods_option")] public bool? TotalsForAllGradingPeriodsOption { get; set; }
        [JsonProperty("current_grading_period_title")] public string CurrentGradingPeriodTitle { get; set; }
        [JsonProperty("current_grading_period_id")] public long? CurrentGradingPeriodId { get; set; }
        [JsonProperty("current_period_override_grade")] public string CurrentPeriodOverrideGrade { get; set; }
        [JsonProperty("current_period_override_score")] public decimal? CurrentPeriodOverrideScore { get; set; }
        [JsonProperty("current_period_unposted_current_score")] public decimal? CurrentPeriodUnpostedCurrentScore { get; set; }
        [JsonProperty("current_period_unposted_final_score")] public decimal? CurrentPeriodUnpostedFinalScore { get; set; }
        [JsonProperty("current_period_unposted_current_grade")] public string CurrentPeriodUnpostedCurrentGrade { get; set; }
        [JsonProperty("current_period_unposted_final_grade")] public string CurrentPeriodUnpostedFinalGrade { get; set; }

        IGrade IEnrollment.Grades => this.Grades;
        IUserDisplay IEnrollment.User => this.User;
    }
}
