using System;

namespace CanvasApi.Client.Modules.Models
{
    public interface ILockInfo
    {
        string AssetString { get; }
        IModule ContextModule { get; }
        DateTime? LockAt { get; }
         DateTime? UnlockAt { get; }
    }
}