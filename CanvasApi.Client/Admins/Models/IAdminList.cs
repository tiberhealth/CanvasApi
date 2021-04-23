using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Admins.Models
{
    public interface IAdminList
    {
        /// <summary>
        /// Scope the results to those with user IDs equal to any of the IDs specified here.
        /// </summary>
        [JsonProperty("user_id[]")] IEnumerable<Int32> UserId { get; set; }
    }
}