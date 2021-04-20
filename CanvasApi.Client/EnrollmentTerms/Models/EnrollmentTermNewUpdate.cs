using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    internal class EnrollmentTermNewUpdate : IEnrollmentTermNewUpdate
    {
        public string Name { get; set; }
        public DateTime? StartAt { get; set; }
        public DateTime? EndAt { get; set; }
    }
}
