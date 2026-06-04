namespace CanvasApi.Client.Assignments.Models;

/// <summary>
/// Top-level body for an assignment create/edit. Wraps an
/// <see cref="IAssignmentNewEdit"/> so the multipart serializer emits the
/// canonical Canvas <c>assignment[*]</c> prefix.
/// </summary>
public interface IAssignmentCreate
{
    /// <summary>
    /// The assignment fields. Serialized as <c>assignment[name]</c>,
    /// <c>assignment[points_possible]</c>, etc.
    /// </summary>
    IAssignmentNewEdit Assignment { get; set; }
}

public static class IAssignmentCreateHelpers
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
