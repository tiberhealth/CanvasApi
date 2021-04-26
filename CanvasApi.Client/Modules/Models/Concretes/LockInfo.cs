using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Modules.Models
{
    internal class LockInfo : ILockInfo
    {
        [JsonProperty("asset_string")] public string AssetString { get; set; }
        [JsonProperty("unlock_at")] public DateTime? UnlockAt { get; set; }
        [JsonProperty("lock_at")] public DateTime? LockAt { get; set; }
        [JsonProperty("context_module")] public IModule ContextModule { get; set; }
    }
}
