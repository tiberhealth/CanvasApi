namespace CanvasApi.Client.Enrollments.Models;

public class EnrollmentRequest : IEnrollmentRequest
{
    public EnrollmentTypes[] Type { get; set; }
    public string[] Role { get; set; }
    public EnrollmentState[] State { get; set; }
    public EnrollmentInclude[] Include { get; set; }
    public long? UserId { get; set; }
    public long? GradingPeriodId { get; set; }
    public long? EnrollmentTermId { get; set; }
    public string[] SisAccountId { get; set; }
    public string[] SisCourseId { get; set; }
    public string[] SisSectionId { get; set; }
    public string[] SisUserId { get; set; }
    public bool[] CreateForSisId { get; set; }
}