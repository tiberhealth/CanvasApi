namespace CanvasApi.Client.EnrollmentTerms.Models;

internal class EnrollmentOverrides : IEnrollmentOverrides
{
    IEnrollmentDates IEnrollmentOverrides.Teacher => this.Teacher;
    IEnrollmentDates IEnrollmentOverrides.Student => this.Student;
    IEnrollmentDates IEnrollmentOverrides.TeachingAssistant => this.TeachingAssistant;
    IEnrollmentDates IEnrollmentOverrides.Designer => this.Designer;
        
        
    [JsonProperty("TeacherEnrollment")] public EnrollmentDates Teacher { get; set; }
    [JsonProperty("StudentEnrollment")] public EnrollmentDates Student { get; set; }
    [JsonProperty("TaEnrollment")] public EnrollmentDates TeachingAssistant { get; set; }
    [JsonProperty("DesignerEnrollment")] public EnrollmentDates Designer { get; set; }
        
}