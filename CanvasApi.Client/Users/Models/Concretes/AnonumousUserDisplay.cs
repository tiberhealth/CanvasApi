using System;
using Newtonsoft.Json;

namespace CanvasApi.Client.Users.Models.Concretes
{
    public class AnonumousUserDisplay : IAnonumousUserDisplay
    {
        [JsonProperty("anonymous_id")] public string AnonymouusId { get; set; }
        [JsonProperty("avatar_image_url")] public string AvatarImageUrl { get; set; }
    }
}
