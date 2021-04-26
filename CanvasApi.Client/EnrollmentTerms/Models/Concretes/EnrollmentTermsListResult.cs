using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace CanvasApi.Client.EnrollmentTerms.Models.Concretes
{
    internal class EnrollmentTermsListResult
    {
        [JsonProperty("enrollment_terms")] public IEnumerable<EnrollmentTerm> EnrollmentTerms { get; set; }

        public static IEnumerable<EnrollmentTerm> ToArray(EnrollmentTermsListResult apiResult) => apiResult.EnrollmentTerms.ToArray();
    }
}
