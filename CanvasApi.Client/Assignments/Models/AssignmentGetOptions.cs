namespace CanvasApi.Client.Assignments.Models;

internal class AssignmentGetOptions : IAssignmentGetOptions
{
    public IEnumerable<AssignmentGetIncludes> Include { get; set; }
    public bool? OverrideAssignmentDates { get; set; }
    public bool? NeedsGradingCountBySection { get; set; }
    public bool? AllDates { get; set; }
}
