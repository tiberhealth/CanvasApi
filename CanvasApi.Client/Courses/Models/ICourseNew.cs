using System;
using CanvasApi.Client.Courses.Enums;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Courses.Models
{
    public interface ICourseNew
    {
        string Name { get; set; }
        string CourseCode { get; set; }
        DateTime? StartAt { get; set; }
        DateTime? EndAt { get; set; }
        CourseLicenseType? License { get; set; }
        bool? IsPublic { get;set; }
        bool? IsPublicToAuthUsers { get; set; }
        bool? PublicSyllabus { get; set; }
        bool? PublicSyllabusToAuth { get; set; }
        string PublicDescription { get; set; }
        bool? AllowStudentWikiEdits { get; set; }
        bool? AllowWikiComments { get; set; }
        bool? AllowStudentForumAttachments { get; set; }
        bool? OpenEnrollment { get; set; }
        bool? SelfEnrollment { get; set; }
        bool? RestrictEnrollmentToCourseDates { get; set; }
        long TermId { get; set; }
        string SisCourseId { get; set; }
        string IntegrationId { get; set; }
        bool? HideFinalGrades { get; set; }
        bool? ApplyAssignmentGroupWeights { get; set; }
        string TimeZone { get; set; }
        bool? Offer { get; set; }
        bool? EnrollMe { get; set; }
        ViewType? DefaultView { get; set; }
        string SyllabusBody { get; set; }
        long? GradingStandardId { get; set; }
        GradePassbackSetting GradebookPassbackSetting { get; set; }
        CourseFormat CourseFormat { get; set; }
    }
}
