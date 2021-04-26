using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.EnrollmentTerms.Models
{
    public interface IEnrollmentDates
    {
        [Multipart("start_at", DateTimeFormat = "yyyy-MM-dd HH:mm:sszzz")] DateTime? StartAt { get; set; }
        [Multipart("end_at", DateTimeFormat = "yyyy-MM-dd HH:mm:sszzz")] DateTime? EndAt { get; set; }
    }
}
