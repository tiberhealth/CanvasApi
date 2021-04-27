using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    internal class ContentDetails : IContentDetails
    {
        [Multipart("points_possible")] public int? PointsPossible { get; set; }
        [Multipart("due_at")] public DateTime? DueAt { get; set; }
        [Multipart("unlock_at")] public DateTime? UnlockAt { get; set; }
        [Multipart("lock_at")] public DateTime? LockAt { get; set; }
        [Multipart("locked_for_user")] public bool? LockedForUser { get; set; }
        [Multipart("lock_explanation")] public string LockExplanation { get; set; }
        [Multipart("lock_info")] public ILockInfo LockInfo { get; set; }
    }
}
