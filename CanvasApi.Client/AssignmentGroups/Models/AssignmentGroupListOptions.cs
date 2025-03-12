using SubmissionTypes = CanvasApi.Client.AssignmentGroups.Enums.SubmissionTypes;

namespace CanvasApi.Client.AssignmentGroups.Models;

internal class AssignmentGroupListOptions : IAssignmentGroupListOptions
{
    public IEnumerable<AssignmentListIncludes> Include { get; set; }
    public IEnumerable<long> AssignmentIds { get; set; }
    public IEnumerable<SubmissionTypes> ExcludedAssignmentSubmissionTypes { get; set; }
    public bool? OverrideAssignmentDates { get; set; }
    public long? GradingPeriodId { get; set; }
    public bool? ScopeAssignmentsToStudent { get; set; }
}