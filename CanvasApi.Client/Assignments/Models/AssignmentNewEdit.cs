using System;
using System.Collections.Generic;
using CanvasApi.Client.Assignments.Enums;
using SubmissionTypes = CanvasApi.Client.Assignments.Enums.SubmissionTypes;

namespace CanvasApi.Client.Assignments.Models;

internal class AssignmentNewEdit : IAssignmentNewEdit
{
    public string Name { get; set; }
    public int? Position { get; set; }
    public IEnumerable<SubmissionTypes> SubmissionTypes { get; set; }
    public decimal? PointsPossible { get; set; }
    public GradingTypes? GradingType { get; set; }
    public long? AssignmentGroupId { get; set; }
    public DateTime? DueAt { get; set; }
    public DateTime? LockAt { get; set; }
    public DateTime? UnlockAt { get; set; }
    public string Description { get; set; }
    public bool? Published { get; set; }
    public bool? NotifyOfUpdate { get; set; }
    public bool? OmitFromFinalGrade { get; set; }
}
