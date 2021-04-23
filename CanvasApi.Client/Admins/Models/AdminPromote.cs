using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Admins.Models
{
    internal class AdminPromote : IAdminPromote
    {
        [JsonProperty("user_id")] public string Name { get; set; }
        [JsonProperty("role_id")] public int? RoleId { get; set; }
        [JsonProperty("send_confirmation")] public bool? SendConfirmation { get; set; }
    }
}
