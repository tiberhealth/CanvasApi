using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Admins.Models
{
    public interface IAdminList
    {
        [JsonProperty("user_id[]")] IEnumerable<Int32> UserId { get; set; }
    }
}