using System;

namespace CanvasApi.Client.Courses.Models.Concrete
{
    internal class CourseProgress : ICourseProgress
    {
        public int? RequirementCount { get; set; }
        public int? RequirementCompletedCount { get; set; }
        public string NextRequirementUrl { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}
