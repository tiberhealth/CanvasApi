namespace CanvasApi.Client.AssignmentGroups.Models
{
    public interface IDeleteAssignmentGroup
    {
        /// <summary>
        /// The ID of an active Assignment Group to which the assignments that are currently assigned to the destroyed Assignment Group will be assigned. NOTE: If this argument is not provided, any assignments in this Assignment Group will be deleted
        /// </summary>
        long? MoveAssignmentTo { get; set; }
    }
}
