using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Admins.Models
{
    class AdminRemove : IAdminRemove
    {
        [JsonProperty("role_id")] public int? RoleId { get; set; }
    }
}
