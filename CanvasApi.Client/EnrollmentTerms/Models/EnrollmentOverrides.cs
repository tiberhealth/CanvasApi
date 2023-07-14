using Newtonsoft.Json;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    internal class EnrollmentOverrides : IEnrollmentOverrides
    {
        [JsonProperty("TeacherEnrollment")] public IEnrollmentOverrides Teacher { get; set; }
        [JsonProperty("StudentEnrollment")] public IEnrollmentOverrides Student { get; set; }
        [JsonProperty("TaEnrollment")] public IEnrollmentOverrides TeachingAssistant { get; set; }
        [JsonProperty("DesignerEnrollment")] public IEnrollmentOverrides Designer { get; set; }
    }
}
