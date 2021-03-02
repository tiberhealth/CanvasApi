using System;
using Newtonsoft.Json;

namespace CanvasApi.Client.Users.Models
{
    internal class UserDisplay : IUserDisplay
    {
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("short_name")] public string ShortName { get; set; }
        [JsonProperty("avatar_image_url")] public string AvatarImageUrl { get; set; }
        [JsonProperty("html_url")] public string HtmlUrl { get; set; }
    }
}
