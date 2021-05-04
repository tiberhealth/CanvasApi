using Newtonsoft.Json;
using System;
using TiberHealth.Serializer.Attributes;

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