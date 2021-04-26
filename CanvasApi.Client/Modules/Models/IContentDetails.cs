using Newtonsoft.Json;
using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IContentDetails
    {
        [Multipart("due_at", DateTimeFormat = "yyyy-MM-dd HH:mm:sszzz")] DateTime? DueAt { get; set; }
        [Multipart("lock_at", DateTimeFormat = "yyyy-MM-dd HH:mm:sszzz")] DateTime? LockAt { get; set; }
        [JsonProperty("locked_for_user")] bool? LockedForUser { get; set; }
        [JsonProperty("lock_explanation")] string LockExplanation { get; set; }
        [JsonProperty("lock_info")] ILockInfo LockInfo { get; set; }
        [JsonProperty("poionts_possible")] int? PointsPossible { get; set; }
        [Multipart("unlock_at", DateTimeFormat = "yyyy-MM-dd HH:mm:sszzz")] DateTime? UnlockAt { get; set; }
    }
}