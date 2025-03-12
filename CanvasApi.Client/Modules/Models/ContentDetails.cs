namespace CanvasApi.Client.Modules.Models;

internal class ContentDetails : IContentDetails
{
    public int? PointsPossible { get; set; }
    public DateTime? DueAt { get; set; }
    public DateTime? UnlockAt { get; set; }
    public DateTime? LockAt { get; set; }
    public bool? LockedForUser { get; set; }
    public string LockExplanation { get; set; }

    public LockInfo LockInfo { get; set; }
    ILockInfo IContentDetails.LockInfo => LockInfo;
}