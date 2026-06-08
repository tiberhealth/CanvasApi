namespace CanvasApi.Client.AssignmentGroups.Models;

public interface IGradingRules
{
    /// <summary>
    /// Number of lowest scores to be dropped for each user.
    /// </summary>
    int DropLowest {get; }

    /// <summary>
    /// Number of highest scores to be dropped for each user.
    /// </summary>
    int DropHighest { get; }

    /// <summary>
    /// Assignment IDs that should never be dropped.
    /// </summary>
    IEnumerable<long> NeverDrop { get; }
}