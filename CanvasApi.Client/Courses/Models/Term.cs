using System;
using Newtonsoft.Json;

namespace CanvasApi.Client.Courses.Models
{
    internal class Term : ITerm
    {
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("start_at")] public DateTime? StartAt { get; set; }
        [JsonProperty("end_at")] public DateTime? EndAt { get; set; }
    }
}
