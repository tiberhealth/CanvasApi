using System;
using CanvasApi.Client.Courses.Enums;
using Newtonsoft.Json;

namespace CanvasApi.Client.Courses.Models
{
    public interface ICourseNew
    {
        [JsonProperty("name")] string Name { get; set; }
        [JsonProperty("course_code")] string CourseCode { get; set; }
        [JsonProperty("start_at")] DateTime? StartAt { get; set; }
        [JsonProperty("end_at")] DateTime? EndAt { get; set; }
        [JsonProperty("license")] CourseLicenseType? License { get; set; }
        [JsonProperty("is_public")] bool? IsPublic { get;set; }
        [JsonProperty("is_public_to_auth_users")] bool? IsPublicToAuthUsers { get; set; }
        [JsonProperty("name")] bool? PublicSyllabus { get; set; }
        [JsonProperty("name")] bool? PublicSyllabusToAuth { get; set; }
        [JsonProperty("name")] string PublicDescription { get; set; }
        [JsonProperty("name")] bool? AllowStudentWikiEdits { get; set; }
        [JsonProperty("name")] bool? AllowWikiComments { get; set; }
        [JsonProperty("name")] bool? AllowStudentForumAttachments { get; set; }
        [JsonProperty("name")] bool? OpenEnrollment { get; set; }
        [JsonProperty("name")] bool? SelfEnrollment { get; set; }
        [JsonProperty("name")] bool? RestrictEnrollmentToCourseDates { get; set; }
        [JsonProperty("name")] long TermId { get; set; }
        [JsonProperty("name")] string SisCourseId { get; set; }
        [JsonProperty("name")] string IntegrationId { get; set; }
        [JsonProperty("name")] bool? HideFinalGrades { get; set; }
        [JsonProperty("name")] bool? ApplyAssignmentGroupWeights { get; set; }
        [JsonProperty("name")] string TimeZone { get; set; }
        [JsonProperty("name")] bool? Offer { get; set; }
        [JsonProperty("name")] bool? EnrollMe { get; set; }
        [JsonProperty("name")] ViewType? DefaultView { get; set; }
        [JsonProperty("name")] string SyllabusBody { get; set; }
        [JsonProperty("name")] long? GradingStandardId { get; set; }
        [JsonProperty("name")] GradePassbackSetting GradebookPassbackSetting { get; set; }
        [JsonProperty("name")] CourseFormat CourseFormat { get; set; }
    }
}
