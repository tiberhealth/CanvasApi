using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class LockInfo : ILockInfo
    {
        [Multipart("asset_string")] public string AssetString { get; set; }
        [Multipart("unlock_at")] public DateTime? UnlockAt { get; set; }
        [Multipart("lock_at")] public DateTime? LockAt { get; set; }
        [Multipart("context_module")] public Module ContextModule { get; set; }
        IModule ILockInfo.ContextModule => this.ContextModule;
    }
}
