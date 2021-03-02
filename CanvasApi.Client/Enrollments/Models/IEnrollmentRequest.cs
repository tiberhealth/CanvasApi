using System;
using CanvasApi.Client.Enrollments.Enums;
using Newtonsoft.Json;

namespace CanvasApi.Client.Enrollments.Models
{
    public interface IEnrollmentRequest
    {
        [JsonProperty("type")] string[] Type { get; set; }
        [JsonProperty("role")] string[] Role { get; set; }
        [JsonProperty("state")] EnrollmentState[] State { get; set; }
        [JsonProperty("include")] EnrollmentInclude[] Include { get; set; }
        [JsonProperty("user_id")] long? UserId { get; set; }
        [JsonProperty("grading_period_id")] long? GradingPeriodId { get; set; }
        [JsonProperty("enrollment_term_id")] long? EnrollmentTermId { get; set; }
        [JsonProperty("sis_account_id")] string[] SisAccountId { get; set; }
        [JsonProperty("sis_course_id")] string[] SisCourseId { get; set; }
        [JsonProperty("sis_section_id")] string[] SisSectionId { get; set; }
        [JsonProperty("sis_user_id")] string[] SisUserId { get; set; }
        [JsonProperty("created_for_sis_id")] bool[] CreateForSisId { get; set; }
    }
}
