using System;
using CanvasApi.Client.Pages.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.Pages.Models
{
    public class Page : IPage
    {
        [JsonProperty("url")] public string Url { get; set; }
        [JsonProperty("title")] public string Title { get; set; }
        [JsonProperty("created_at")] public DateTime? CreatedAt { get; set; }
        [JsonProperty("updated_at")] public DateTime? UpdatedAt { get; set; }
        [JsonProperty("hide_from_students")] public bool? HideFromStudents { get; set; }
        [JsonProperty("editing_roles")] public EditingRoles[] EditingRoles { get; set; }
        [JsonProperty("last_edited_by")] public string LastEditedBy { get; set; }
        [JsonProperty("body")] public string Body { get; set; }
        [JsonProperty("published")] public bool? Published { get; set; }
        [JsonProperty("front_page")] public bool? FrontPage { get; set; }
        [JsonProperty("locked_for_user")] public bool? LockedForUser { get; set; }
        [JsonProperty("lock_info")] public JObject LockInfo { get; set; }
        [JsonProperty("lock_explanation")] public string LockExplanation { get; set; }
    }
}
