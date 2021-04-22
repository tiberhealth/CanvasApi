using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CanvasApi.Client.Submissions.Models.Concretes
{
    internal class GroupedSubmissions : IGroupedSubmissions
    {
        [JsonProperty("user_id")] public long UserId { get; set; }
        [JsonProperty("submissions")] public IEnumerable<Submission> Submissions { get; set; }
        IEnumerable<ISubmission> IGroupedSubmissions.Submissions => this.Submissions;
    }
}
