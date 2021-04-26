namespace CanvasApi.Client.Assignments.Models
{
    public interface IRubricCriteria
    {
        decimal? Points { get; }
        /// <summary>
        /// The id of rubric criteria.
        /// </summary>
        string Id { get; }
        /// <summary>
        /// (Optional) The id of the learning outcome this criteria uses, if any.
        /// </summary>
        string LearningOutcomeId { get; }
        /// <summary>
        /// (Optional) The 3rd party vendor's GUID for the outcome this criteria
        /// references, if any.
        /// </summary>
        string VendorGuid { get; }
        string Description { get; }
        string LongDescription { get; }
        bool? CriterionUseRange { get; }
        string Ratings { get; }
        bool? IgnoreForScoring { get; }
    }
}
