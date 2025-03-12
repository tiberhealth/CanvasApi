namespace CanvasApi.Client.Assignments.Models;

public interface IAssignmentOverride
{
    /// <summary>
    /// the ID of the assignment override
    /// </summary>
    long Id { get; }

    /// <summary>
    /// the ID of the assignment the override applies to
    /// </summary>
    long AssignmentId { get; }

    /// <summary>
    /// the IDs of the override's target students (present if the override targets an
    /// ad-hoc set of students)
    /// </summary>
    long[] StudentIds { get; }

    /// <summary>
    /// the ID of the override's target group (present if the override targets a
    /// group and the assignment is a group assignment)
    /// </summary>
    long GroupId { get; }

    /// <summary>
    /// the ID of the overrides's target section (present if the override targets a
    /// section)
    /// </summary>
    long CourseSectionId { get; }

    /// <summary>
    /// the title of the override
    /// </summary>
    string Title { get; }

    /// <summary>
    /// the overridden due at (present if due_at is overridden)
    /// </summary>
    DateTime? DueAt { get; }

    /// <summary>
    /// the overridden all day flag (present if due_at is overridden)
    /// </summary>
    bool? AllDay { get; }

    /// <summary>
    /// the overridden all day date (present if due_at is overridden)
    /// </summary>
    DateTime? AllDayDate { get; }

    /// <summary>
    /// the overridden unlock at (present if unlock_at is overridden)
    /// </summary>
    DateTime? UnlockAt { get; }

    /// <summary>
    /// the overridden lock at, if any (present if lock_at is overridden)
    /// </summary>
    DateTime? LockAt { get; }
}