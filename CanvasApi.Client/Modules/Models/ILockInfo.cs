using Newtonsoft.Json;
using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface ILockInfo
    {
        [JsonProperty("asset_string")] string AssetString { get; set; }
        [JsonProperty("context_module")] IModule ContextModule { get; set; }
        [Multipart("lock_at", DateTimeFormat = "yyyy-MM-dd HH:mm:sszzz")] DateTime? LockAt { get; set; }
        [Multipart("unlock_at", DateTimeFormat = "yyyy-MM-dd HH:mm:sszzz")] DateTime? UnlockAt { get; set; }
    }
}