using System;
namespace CanvasApi.Client.Assignments.Models
{
    public interface INeedsGradingCount
    {
        /// <summary>
        /// The section ID
        /// </summary>
        string SectionId { get; }

        /// <summary>
        /// Number of submissions that need grading
        /// </summary>
        int? NeedsGradingCount { get; }
    }
}
