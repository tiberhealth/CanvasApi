using System;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    public interface IEnrollmentDates
    {
        DateTime? StartAt { get; set; }
        DateTime? EndAt { get; set; }
    }
}
