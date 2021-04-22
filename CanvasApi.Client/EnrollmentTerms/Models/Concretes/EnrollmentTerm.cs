using System;
using Newtonsoft.Json;

namespace CanvasApi.Client.EnrollmentTerms.Models.Concretes
{
    internal class EnrollmentTerm : IEnrollmentTerm
    {
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("sis_term_id")] public string SisTermId { get; set; }
        [JsonProperty("sis_import_id")] public long? SisImportId { get; set; }
        [JsonProperty("overrides")] public EnrollmentOverrides Overrides { get; set; }

        [JsonProperty("start_at")] public DateTime? StartAt { get; set; }
        [JsonProperty("end_at")] public DateTime? EndAt { get; set; }

        IEnrollmentOverrides IEnrollmentTerm.Overrides => this.Overrides;
    }
}
