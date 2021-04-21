using System;
using Newtonsoft.Json;

namespace CanvasApi.Client.Accounts.Models
{
    public class HelpLink
    {
        /// <summary>
        /// The ID of the help link
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// The name of the help link
        /// </summary>
        [JsonProperty("text")] public string Text { get; set; }

        /// <summary>
        /// The description of the help link
        /// </summary>
        [JsonProperty("subtext")] public string SubText { get; set; }

        /// <summary>
        /// The URL of the help link
        /// </summary>
        [JsonProperty("url")] public string Url { get; set; }

        /// <summary>
        /// The type of the help link
        /// </summary>
        [JsonProperty("type")] public string Type { get; set; }

        /// <summary>
        /// The roles that have access to this help link
        /// "user", "student", "teacher", "admin", "observer", "unenrolled"
        /// </summary>
        [JsonProperty("available_to")] public string AvailableTo { get; set; }
    }
}
