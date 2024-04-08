using System;

namespace CanvasApi.Client.EnrollmentTerms.Models;

public class EnrollmentDates: IEnrollmentDates
{
    public DateTime? StartAt { get; set; }
    public DateTime? EndAt { get; set; }
}