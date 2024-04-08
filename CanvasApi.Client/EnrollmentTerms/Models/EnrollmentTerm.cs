using System;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    internal class EnrollmentTerm : IEnrollmentTerm
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string SisTermId { get; set; }
        public long? SisImportId { get; set; }
        //public IEnrollmentOverrides Overrides { get; set; }

        public DateTime? StartAt { get; set; }
        public DateTime? EndAt { get; set; }
    }
}
