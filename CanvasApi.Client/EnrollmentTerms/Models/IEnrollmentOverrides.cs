using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    public interface IEnrollmentOverrides
    {
        [Multipart("TeacherEnrollment")] IEnrollmentOverrides Teacher { get; }
        [Multipart("StudentEnrollment")] IEnrollmentOverrides Student { get; }
        [Multipart("TaEnrollment")] IEnrollmentOverrides TeachingAssistant { get; }
        [Multipart("DesignerEnrollment")] IEnrollmentOverrides Designer { get; }
    }
}
