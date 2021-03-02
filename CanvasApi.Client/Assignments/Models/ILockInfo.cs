using System;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.Assignments.Models
{
    public interface ILockInfo
    {
        /// <summary>
        /// Asset string for the object causing the lock
        /// </summary>
        string AssetString { get; }

        /// <summary>
        /// (Optional) Time at which this was/will be unlocked. Must be before the due
        /// date.
        /// </summary>
        DateTime? UnlockAt { get; }

        /// <summary>
        /// (Optional) Time at which this was/will be locked. Must be after the due date.
        /// </summary>
        DateTime? LockAt { get; }

        /// <summary>
        /// (Optional) Context module causing the lock.
        /// </summary>
        JObject ContextModule { get; }
        bool? ManuallyLocked { get; }
    }
}
