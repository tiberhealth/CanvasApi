using System;

namespace CanvasApi.Client.EnrollmentTerms.Models.Concretes
{
    internal class EnrollmentTermDetail: IEnrollmentTermDetail
    {
        public string Name { get; set; }
        public DateTime? StartAt { get; set; }
        public DateTime? EndAt { get; set; }
        public string SisTermId { get; set; }
    }
}
