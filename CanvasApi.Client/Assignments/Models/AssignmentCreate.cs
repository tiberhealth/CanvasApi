namespace CanvasApi.Client.Assignments.Models;

internal class AssignmentCreate : IAssignmentCreate
{
    public IAssignmentNewEdit Assignment { get; set; }
}
