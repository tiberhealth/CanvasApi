namespace CanvasApi.Client.Modules.Models;

public interface IContentDetails
{
    DateTime? DueAt { get; }
    DateTime? LockAt { get; }
    bool? LockedForUser { get; }
    string LockExplanation { get; }
    ILockInfo LockInfo { get; }
    int? PointsPossible { get; }
    DateTime? UnlockAt { get; }
}