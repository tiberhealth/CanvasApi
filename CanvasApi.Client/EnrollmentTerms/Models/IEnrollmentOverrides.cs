namespace CanvasApi.Client.EnrollmentTerms.Models;

public interface IEnrollmentOverrides
{
    IEnrollmentDates Teacher { get; }
    IEnrollmentDates Student { get; }
    IEnrollmentDates TeachingAssistant { get; }
    IEnrollmentDates Designer { get; }
}