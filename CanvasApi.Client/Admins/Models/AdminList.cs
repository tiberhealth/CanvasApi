using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Admins.Models
{
    internal class AdminList : IAdminList
    {
        [JsonProperty("user_id[]")] public IEnumerable<Int32> UserId { get; set; }
    }
}
