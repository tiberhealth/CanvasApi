using Newtonsoft.Json;

namespace CanvasApi.Client.Assignments.Models.Concretes
{
    internal class ScoreStatistic : IScoreStatistic
    {
        [JsonProperty("min")] public decimal? Min { get; set; }
        [JsonProperty("max")] public decimal? Max { get; set; }
        [JsonProperty("mean")] public decimal? Mean { get; set; }
    }
}
