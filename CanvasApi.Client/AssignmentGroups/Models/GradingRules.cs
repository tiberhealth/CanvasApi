namespace CanvasApi.Client.AssignmentGroups.Models;

internal class GradingRules : IGradingRules
{
    public int DropLowest { get; set; }
    public int DropHighest { get; set; }
    public IEnumerable<long> NeverDrop { get; set; }
}