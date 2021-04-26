using Newtonsoft.Json;

namespace CanvasApi.Client.Assignments.Models.Concretes
{
    internal class RubricRating: IRubricRating
    {

        [JsonProperty("points")] public decimal? Points { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("long_description")] public string LongDescription { get; set; }
    }
}
