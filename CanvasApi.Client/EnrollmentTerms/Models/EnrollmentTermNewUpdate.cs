using System;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    internal class EnrollmentTermNewUpdate : IEnrollmentTermNewUpdate
    {
        IEnrollmentTermDetail IEnrollmentTermNewUpdate.EnrollmentTerm => this.EnrollmentTerm;

        internal IEnrollmentTermDetail EnrollmentTerm { get; set; }
    }
}
