using System;
using Newtonsoft.Json;

namespace CanvasApi.Client.Enrollments.Models.Concretes
{
    internal class Grade : IGrade
    {
        [JsonProperty("html_url")] public string HtmlUrl { get; set; }
        [JsonProperty("current_grade")] public string CurrentGrade { get; set; }
        [JsonProperty("final_grade")] public string FinalGrade { get; set; }
        [JsonProperty("current_score")] public string CurrentScore { get; set; }
        [JsonProperty("final_score")] public string FinalScore { get; set; }
        [JsonProperty("current_points")] public decimal? CurrentPoints { get; set; }
        [JsonProperty("unposted_current_grade")] public string UnpostedCurrentGrade { get; set; }
        [JsonProperty("unposted_final_grade")] public string UnpostedFinalGrade { get; set; }
        [JsonProperty("unposted_current_score")] public string UnpostedCurrentScore { get; set; }
        [JsonProperty("unposted_final_score")] public string UnpostedFinalScore { get; set; }
        [JsonProperty("unposted_current_points")] public decimal? UnpostedCurrentPoints { get; set; }
    }
}
