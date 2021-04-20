using System;
namespace CanvasApi.Client.EnrollmentTerms.Models
{
    public interface IEnrollmentTerm
    {
        /// <summary>
        /// The unique identifier for the enrollment term.
        /// </summary>
        long Id { get; }
        /// <summary>
        /// The name of the term.
        /// </summary>
        string Name { get; }
        /// <summary>
        /// The datetime of the start of the term.
        /// </summary>
        DateTime? StartAt { get; }
        /// <summary>
        /// The datetime of the end of the term.
        /// </summary>
        DateTime? EndAt { get; }
    }
}
