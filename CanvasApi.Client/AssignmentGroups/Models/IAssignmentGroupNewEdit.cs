using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.AssignmentGroups.Models
{
    public interface IAssignmentGroupNewEdit
    {
        /// <summary>
        /// The assignment group's name
        /// </summary>
        [JsonProperty("name")] string Name { get; set;  }

        /// <summary>
        /// The position of this assignment group in relation to the other assignment groups
        /// </summary>
        [JsonProperty("position")] int? Position { get; set; }

        /// <summary>
        /// The percent of the total grade that this assignment group represents
        /// </summary>
        [JsonProperty("group_weight")] decimal? GroupWeight { get; set; }

        /// <summary>
        /// The sis source id of the Assignment Group
        /// </summary>
        [JsonProperty("sis_source_id")] string SisSourceId { get; set; }

        /// <summary>
        /// The integration data of the Assignment Group
        /// </summary>
        [JsonProperty("integration_data")] JObject IntegrationData { get; set; }

        /// <summary>
        /// The grading rules that are applied within this assignment group See the Assignment Group object definition for format
        /// </summary>
        [JsonProperty("rules")] string Rules { get; set; }

    }
}
