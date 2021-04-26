using System;
using CanvasApi.Client.Courses.Enums;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Courses.Models
{
    public interface ICourseNew
    {
        [Multipart("name")] string Name { get; set; }
        [Multipart("course_code")] string CourseCode { get; set; }
        [Multipart("start_at")] DateTime? StartAt { get; set; }
        [Multipart("end_at")] DateTime? EndAt { get; set; }
        [Multipart("license")] CourseLicenseType? License { get; set; }
        [Multipart("is_public")] bool? IsPublic { get;set; }
        [Multipart("is_public_to_auth_users")] bool? IsPublicToAuthUsers { get; set; }
        [Multipart("name")] bool? PublicSyllabus { get; set; }
        [Multipart("name")] bool? PublicSyllabusToAuth { get; set; }
        [Multipart("name")] string PublicDescription { get; set; }
        [Multipart("name")] bool? AllowStudentWikiEdits { get; set; }
        [Multipart("name")] bool? AllowWikiComments { get; set; }
        [Multipart("name")] bool? AllowStudentForumAttachments { get; set; }
        [Multipart("name")] bool? OpenEnrollment { get; set; }
        [Multipart("name")] bool? SelfEnrollment { get; set; }
        [Multipart("name")] bool? RestrictEnrollmentToCourseDates { get; set; }
        [Multipart("name")] long TermId { get; set; }
        [Multipart("name")] string SisCourseId { get; set; }
        [Multipart("name")] string IntegrationId { get; set; }
        [Multipart("name")] bool? HideFinalGrades { get; set; }
        [Multipart("name")] bool? ApplyAssignmentGroupWeights { get; set; }
        [Multipart("name")] string TimeZone { get; set; }
        [Multipart("name")] bool? Offer { get; set; }
        [Multipart("name")] bool? EnrollMe { get; set; }
        [Multipart("name")] ViewType? DefaultView { get; set; }
        [Multipart("name")] string SyllabusBody { get; set; }
        [Multipart("name")] long? GradingStandardId { get; set; }
        [Multipart("name")] GradePassbackSetting GradebookPassbackSetting { get; set; }
        [Multipart("name")] CourseFormat CourseFormat { get; set; }
    }
}
