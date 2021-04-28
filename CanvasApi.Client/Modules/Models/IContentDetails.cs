using Newtonsoft.Json;
using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IContentDetails
    {
        [Multipart("due_at", DateTimeFormat = "yyyy-MM-dd HH:mm:sszzz")] DateTime? DueAt { get; }
        [Multipart("lock_at", DateTimeFormat = "yyyy-MM-dd HH:mm:sszzz")] DateTime? LockAt { get; }
        [Multipart("locked_for_user")] bool? LockedForUser { get; }
        [Multipart("lock_explanation")] string LockExplanation { get; }
        [Multipart("lock_info")] ILockInfo LockInfo { get; }
        [Multipart("poionts_possible")] int? PointsPossible { get; }
        [Multipart("unlock_at", DateTimeFormat = "yyyy-MM-dd HH:mm:sszzz")] DateTime? UnlockAt { get; }
    }
}