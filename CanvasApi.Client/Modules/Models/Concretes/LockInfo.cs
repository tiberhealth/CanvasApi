using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class LockInfo : ILockInfo
    {
        public string AssetString { get; set; }
        public DateTime? UnlockAt { get; set; }
        public DateTime? LockAt { get; set; }
        public Module ContextModule { get; set; }
        IModule ILockInfo.ContextModule => this.ContextModule;
    }
}
