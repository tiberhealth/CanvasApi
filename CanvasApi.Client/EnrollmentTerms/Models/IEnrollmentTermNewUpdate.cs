using System;
using System.Dynamic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    public interface IEnrollmentTermNewUpdate
    {
        /// <summary>
        /// Enrollment Term Details
        /// </summary>
        [JsonProperty("enrollment_term")] IEnrollmentTermDetail EnrollmentTerm { get; }
    }
}
