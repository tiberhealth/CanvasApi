using System;
using System.Collections.Generic;
using CanvasApi.Client.AssignmentGroups.Enums;

namespace CanvasApi.Client.AssignmentGroups.Models
{
    internal class AssignmentGroupGetOptions : IAssignmentGroupGetOptions
    {
        public IEnumerable<AssignmentGroupGetIncludes> Include { get; set; }
        public bool? OverrideAssignmentDates { get; set; }
        public long? GradingPeriodId { get; set; }
    }
}
