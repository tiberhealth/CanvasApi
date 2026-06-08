namespace CanvasApi.Client.Assignments.Models;

internal class LockInfo : ILockInfo
{
    [JsonProperty("asset_string")] public string AssetString { get; set; }
    [JsonProperty("unlock_at")] public DateTime? UnlockAt { get; set; }
    [JsonProperty("lock_at")] public DateTime? LockAt { get; set; }
    [JsonProperty("context_module")] public JObject ContextModule { get; set; }
    [JsonProperty("manually_locked")] public bool? ManuallyLocked { get; set; }
}