using System;
using System.Collections.Generic;
using CanvasApi.Client.EnrollmentTerms.Enums;

namespace CanvasApi.Client.EnrollmentTerms.Models.Concretes
{
    internal class EnrollmentTermListOptions : IEnrollmentTermListOptions
    {
        public IEnumerable<EnrollmentTermIncludes> Include { get; set; }
        public IEnumerable<EnrollmentTermListWorkflowState> WorkflowState { get; set; }
    }
}
