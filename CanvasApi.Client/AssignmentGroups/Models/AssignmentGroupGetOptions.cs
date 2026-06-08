namespace CanvasApi.Client.AssignmentGroups.Models;

internal class AssignmentGroupGetOptions : IAssignmentGroupGetOptions
{
    public IEnumerable<AssignmentGroupGetIncludes> Include { get; set; }
    public bool? OverrideAssignmentDates { get; set; }
    public long? GradingPeriodId { get; set; }
}