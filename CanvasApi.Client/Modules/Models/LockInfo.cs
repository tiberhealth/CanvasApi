namespace CanvasApi.Client.Modules.Models;

internal class LockInfo : ILockInfo
{
    public string AssetString { get; set; }
    public DateTime? UnlockAt { get; set; }
    public DateTime? LockAt { get; set; }
    public Module ContextModule { get; set; }
    IModule ILockInfo.ContextModule => ContextModule;
}