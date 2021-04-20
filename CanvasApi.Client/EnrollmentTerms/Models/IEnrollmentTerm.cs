using System;
namespace CanvasApi.Client.EnrollmentTerms.Models
{
    public interface IEnrollmentTerm
    {
        long Id { get; }
        string Name { get; }
        DateTime? StartAt { get; }
        DateTime? EndAt { get; }
    }
}
