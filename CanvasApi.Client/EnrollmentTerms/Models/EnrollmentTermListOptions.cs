using System;
using System.Collections.Generic;
using CanvasApi.Client.EnrollmentTerms.Enums;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    internal class EnrollmentTermListOptions : IEnrollmentTermListOptions
    {
        public IEnumerable<EnrollmentTermListIncludes> Include { get; set; }
        public IEnumerable<EnrollmentTermListWorkflowState> WorkflowState { get; set; }
        
    }
}
