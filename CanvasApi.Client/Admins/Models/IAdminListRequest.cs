using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Admins.Models
{
    public interface IAdminListRequest
    {
        /// <summary>
        /// Scope the results to those with user IDs equal to any of the IDs specified here.
        /// </summary>
        [JsonProperty("user_id")] IEnumerable<long> UserId { get; set; }
    }
}
