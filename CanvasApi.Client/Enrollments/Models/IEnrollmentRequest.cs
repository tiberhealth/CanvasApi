using CanvasApi.Client.Enrollments.Enums;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Enrollments.Models
{
    public interface IEnrollmentRequest
    {
        [Multipart("type")] EnrollmentTypes[] Type { get; set; }
        [Multipart("role")] string[] Role { get; set; }
        [Multipart("state")] EnrollmentState[] State { get; set; }
        [Multipart("include")] EnrollmentInclude[] Include { get; set; }
        [Multipart("user_id")] long? UserId { get; set; }
        [Multipart("grading_period_id")] long? GradingPeriodId { get; set; }
        [Multipart("enrollment_term_id")] long? EnrollmentTermId { get; set; }
        [Multipart("sis_account_id")] string[] SisAccountId { get; set; }
        [Multipart("sis_course_id")] string[] SisCourseId { get; set; }
        [Multipart("sis_section_id")] string[] SisSectionId { get; set; }
        [Multipart("sis_user_id")] string[] SisUserId { get; set; }
        [Multipart("created_for_sis_id")] bool[] CreateForSisId { get; set; }
    }
}
