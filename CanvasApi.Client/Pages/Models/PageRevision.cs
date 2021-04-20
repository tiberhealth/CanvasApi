using System;
using Newtonsoft.Json;

namespace CanvasApi.Client.Pages.Models
{
    public class PageRevision : IPageRevision
    {
        [JsonProperty("revision_id")] public long RevisionId { get; set; }
        [JsonProperty("updated_at")] public DateTime? UpdatedAt { get; set; }
        [JsonProperty("latest")] public bool? Latest { get; set; }
        [JsonProperty("edited_by")] public string EditedBy { get; set; }
        [JsonProperty("url")] public string Url { get; set; }
        [JsonProperty("title")] public string Title { get; set; }
        [JsonProperty("body")] public string Body { get; set; }
    }
}
