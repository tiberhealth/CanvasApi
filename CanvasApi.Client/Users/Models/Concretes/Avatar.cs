using System;
using Newtonsoft.Json;

namespace CanvasApi.Client.Users.Models.Concretes
{
    internal class Avatar : IAvatar
    {
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("url")] public string Url { get; set; }
        [JsonProperty("token")] public string Token { get; set; }
        [JsonProperty("display_name")] public string DisplayName { get; set; }
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("content_type")] public string ContentType { get; set; }
        [JsonProperty("file_name")] public string Filename { get; set; }
        [JsonProperty("size")] public long Size { get; set; }
    }
}
