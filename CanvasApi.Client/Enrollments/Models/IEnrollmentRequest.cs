using CanvasApi.Client.Enrollments.Enums;

namespace CanvasApi.Client.Enrollments.Models
{
    public interface IEnrollmentRequest
    {
        EnrollmentTypes[] Type { get; set; }
        string[] Role { get; set; }
        EnrollmentState[] State { get; set; }
        EnrollmentInclude[] Include { get; set; }
        long? UserId { get; set; }
        long? GradingPeriodId { get; set; }
        long? EnrollmentTermId { get; set; }
        string[] SisAccountId { get; set; }
        string[] SisCourseId { get; set; }
        string[] SisSectionId { get; set; }
        string[] SisUserId { get; set; }
        bool[] CreateForSisId { get; set; }
    }
}
