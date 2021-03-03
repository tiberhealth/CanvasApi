using System;
using Newtonsoft.Json;

namespace CanvasApi.Client.Courses.Models
{
    internal class CourseProgress : ICourseProgress
    {
        [JsonProperty("requirement_count")] public int? RequirementCount { get; set; }
        [JsonProperty("requirement_completed_count")] public int? RequirementCompletedCount { get; set; }
        [JsonProperty("next_requirement_url")] public string NextRequirementUrl { get; set; }
        [JsonProperty("completed_at")] public DateTime? CompletedAt { get; set; }
    }
}
