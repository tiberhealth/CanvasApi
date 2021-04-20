using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    public interface IEnrollmentTermNewUpdate
    {
        /// <summary>
        /// The assignment group's name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// The position of this assignment group in relation to the other assignment groups
        /// </summary>
        [JsonProperty("start_at")] public DateTime? StartAt { get; set; }

        /// <summary>
        /// The percent of the total grade that this assignment group represents
        /// </summary>
        [JsonProperty("end_at")] public DateTime? EndAt { get; set; }
    }
}
