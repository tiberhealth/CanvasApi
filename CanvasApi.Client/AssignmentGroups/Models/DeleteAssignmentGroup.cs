using System;
namespace CanvasApi.Client.AssignmentGroups.Models
{
    internal class DeleteAssignmentGroup : IDeleteAssignmentGroup
    {
        public long? MoveAssignmentTo { get; set; }
    }
}
