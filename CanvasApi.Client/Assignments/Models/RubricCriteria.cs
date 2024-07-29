using System.Collections.Generic;
using Newtonsoft.Json;

namespace CanvasApi.Client.Assignments.Models
{
    internal class RubricCriteria : IRubricCriteria
    {
        [JsonProperty("points")] public decimal? Points { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("learning_outcome_id")] public string LearningOutcomeId { get; set; }
        [JsonProperty("vendor_guid")] public string VendorGuid { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("long_description")] public string LongDescription { get; set; }
        [JsonProperty("criterion_use_range")] public bool? CriterionUseRange { get; set; }

        IEnumerable<IRubricRating> IRubricCriteria.Ratings => this.Ratings;
        [JsonProperty("ratings")] public RubricRating[] Ratings { get; set; }
        
        [JsonProperty("ignore_for_scoring")] public bool? IgnoreForScoring { get; set; }
    }
}
