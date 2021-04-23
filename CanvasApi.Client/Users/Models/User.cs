using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Users.Models
{
    internal class User : IUser
    {
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
    }
}
