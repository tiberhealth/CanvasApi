using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Admins.Models
{
    class AdminDemote : IAdminDemote
    {
        [JsonProperty("role_id")] public int? RoleId { get; set; }
    }
}
