using Newtonsoft.Json;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    public interface IEnrollmentOverrides
    {
        [JsonProperty("TeacherEnrollment")] IEnrollmentOverrides Teacher { get; }
        [JsonProperty("StudentEnrollment")] IEnrollmentOverrides Student { get; }
        [JsonProperty("TaEnrollment")] IEnrollmentOverrides TeachingAssistant { get; }
        [JsonProperty("DesignerEnrollment")] IEnrollmentOverrides Designer { get; }
    }
}
