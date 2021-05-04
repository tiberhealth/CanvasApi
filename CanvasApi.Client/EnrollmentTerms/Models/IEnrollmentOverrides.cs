using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    public interface IEnrollmentOverrides
    {
        IEnrollmentOverrides Teacher { get; }
        IEnrollmentOverrides Student { get; }
        IEnrollmentOverrides TeachingAssistant { get; }
        IEnrollmentOverrides Designer { get; }
    }
}
