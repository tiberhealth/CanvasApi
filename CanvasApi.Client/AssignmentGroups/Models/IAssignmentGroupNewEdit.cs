using Newtonsoft.Json.Linq;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.AssignmentGroups.Models
{
    public interface IAssignmentGroupNewEdit
    {
        /// <summary>
        /// The assignment group's name
        /// </summary>
        [Multipart("name")] string Name { get; set;  }

        /// <summary>
        /// The position of this assignment group in relation to the other assignment groups
        /// </summary>
        [Multipart("position")] int? Position { get; set; }

        /// <summary>
        /// The percent of the total grade that this assignment group represents
        /// </summary>
        [Multipart("group_weight")] decimal? GroupWeight { get; set; }

        /// <summary>
        /// The sis source id of the Assignment Group
        /// </summary>
        [Multipart("sis_source_id")] string SisSourceId { get; set; }

        /// <summary>
        /// The integration data of the Assignment Group
        /// </summary>
        [Multipart("integration_data")] JObject IntegrationData { get; set; }

        /// <summary>
        /// The grading rules that are applied within this assignment group See the Assignment Group object definition for format
        /// </summary>
        [Multipart("rules")] string Rules { get; set; }

    }
}
