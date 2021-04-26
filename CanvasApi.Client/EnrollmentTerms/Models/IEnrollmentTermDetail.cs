using System;
using Newtonsoft.Json;
using TiberHealth.Serializer;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    public interface IEnrollmentTermDetail: IEnrollmentDates
    {
        /// <summary>
        /// The name of the term.
        /// </summary>
        [JsonProperty("name")] string Name { get; set; }

        /// <summary>
        /// The unique SIS identifier for the term.
        /// </summary>
        [JsonProperty("sis_term_id")] string SisTermId { get; set; }

        // TODO: Need to figure out how to do the overrides

    }
}
