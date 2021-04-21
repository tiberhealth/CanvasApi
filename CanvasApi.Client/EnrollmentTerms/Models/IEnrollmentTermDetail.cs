using System;
using Newtonsoft.Json;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    public interface IEnrollmentTermDetail
    {
        /// <summary>
        /// The name of the term.
        /// </summary>
        [JsonProperty("name")] string Name { get; set; }

        /// <summary>
        /// The day/time the term starts. Accepts times in ISO 8601 format, e.g. 2015-01-10T18:48:00Z.
        /// </summary>
        [JsonProperty("start_at")] DateTime? StartAt { get; set; }

        /// <summary>
        /// The day/time the term ends. Accepts times in ISO 8601 format, e.g. 2015-01-10T18:48:00Z.
        /// </summary>
        [JsonProperty("end_at")] DateTime? EndAt { get; set; }

        /// <summary>
        /// The unique SIS identifier for the term.
        /// </summary>
        [JsonProperty("sis_term_id")] string SisTermId { get; set; }

        // TODO: Need to figure out how to do the overrides

    }
}
