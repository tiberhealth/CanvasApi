namespace CanvasApi.Client.Assignments.Models;

/// <summary>
/// Extension helpers for <see cref="IAssignmentCreate"/>.
/// Lives in its own file (and uses a non-I-prefixed class name) so each file
/// has exactly one top-level type.
/// </summary>
public static class AssignmentCreateExtensions
{
    /// <summary>
    /// Gets the inner assignment record or attaches a new one.
    /// </summary>
    public static IAssignmentNewEdit GetAssignment(this IAssignmentCreate body, bool attachNew = true)
    {
        var assignment = body.Assignment ?? new AssignmentNewEdit();
        if (attachNew && body.Assignment == null) body.Assignment = assignment;
        return assignment;
    }
}
