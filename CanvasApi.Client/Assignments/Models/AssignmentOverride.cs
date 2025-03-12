namespace CanvasApi.Client.Assignments.Models;

internal class AssignmentOverride : IAssignmentOverride
{
    [JsonProperty("id")] public long Id { get; set; }
    [JsonProperty("assignment_id")] public long AssignmentId { get; set; }
    [JsonProperty("student_ids")] public long[] StudentIds { get; set; }
    [JsonProperty("group_id")] public long GroupId { get; set; }
    [JsonProperty("course_section_id")] public long CourseSectionId { get; set; }
    [JsonProperty("title")] public string Title { get; set; }
    [JsonProperty("due_at")] public DateTime? DueAt { get; set; }
    [JsonProperty("all_day")] public bool? AllDay { get; set; }
    [JsonProperty("all_day_date")] public DateTime? AllDayDate { get; set; }
    [JsonProperty("unlock_at")] public DateTime? UnlockAt { get; set; }
    [JsonProperty("lock_at")] public DateTime? LockAt { get; set; }
}