using System;
using System.Collections.Generic;
using CanvasApi.Client.EnrollmentTerms.Enums;

namespace CanvasApi.Client.EnrollmentTerms.Models.Concretes
{
    internal class EnrollmentTermRetrieveOptions : IEnrollmentTermRetrieveOptions
    {
        public IEnumerable<EnrollmentTermIncludes> Include { get; set; }
    }
}