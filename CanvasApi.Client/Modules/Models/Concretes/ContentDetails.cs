using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models
{
    internal class ContentDetails : IContentDetails
    {
        [JsonProperty("points_possible")] public int? PointsPossible { get; set; }
        [JsonProperty("due_at")] public DateTime? DueAt { get; set; }
        [JsonProperty("unlock_at")] public DateTime? UnlockAt { get; set; }
        [JsonProperty("lock_at")] public DateTime? LockAt { get; set; }
        [JsonProperty("locked_for_user")] public bool? LockedForUser { get; set; }
        [JsonProperty("lock_explanation")] public string LockExplanation { get; set; }
        [JsonProperty("lock_info")] public ILockInfo LockInfo { get; set; }
    }
}
