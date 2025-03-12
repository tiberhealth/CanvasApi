﻿namespace CanvasApi.Client.Assignments.Models;

internal class NeedsGradingCountObj : INeedsGradingCount
{
    [JsonProperty("section_id")] public string SectionId { get; set; }
    [JsonProperty("needs_grading_count")] public int? NeedsGradingCount { get; set; }
}