namespace CanvasApi.Client.Assignments.Models;

public interface IAssignmentDate
{
    /// <summary>
    /// (Optional, missing if 'base' is present) id of the assignment override this
    /// date represents
    /// </summary>
    long Id { get; }

    /// <summary>
    /// (Optional, present if 'id' is missing) whether this date represents the
    /// assignment's or quiz's default due date
    /// </summary>
    bool? Base { get; }
    string Title { get; }

    /// <summary>
    /// The due date for the assignment. Must be between the unlock date and the lock
    /// date if there are lock dates
    /// </summary>
    DateTime? DueAt { get; }

    /// <summary>
    /// The unlock date for the assignment. Must be before the due date if there is a
    /// due date.
    /// </summary>
    DateTime? UnlockAt { get; }

    /// <summary>
    /// The lock date for the assignment. Must be after the due date if there is a
    /// due date.
    /// </summary>
    DateTime? LockAt { get; }

}