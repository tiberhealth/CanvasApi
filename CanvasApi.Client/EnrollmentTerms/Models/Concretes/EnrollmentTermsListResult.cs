using System.Collections.Generic;
using System.Linq;

namespace CanvasApi.Client.EnrollmentTerms.Models.Concretes
{
    internal class EnrollmentTermsListResult
    {
        public IEnumerable<EnrollmentTerm> EnrollmentTerms { get; set; }

        public static IEnumerable<EnrollmentTerm> ToArray(EnrollmentTermsListResult apiResult) => apiResult.EnrollmentTerms.ToArray();
    }
}
