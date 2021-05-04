using System.Collections.Generic;
using CanvasApi.Client.AssignmentGroups.Enums;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.AssignmentGroups.Models
{
    public interface IAssignmentGroupGetOptions
    {
        /// <summary>
        /// sociations to include with the group. “discussion_topic” and “assignment_visibility” and “submission” are only valid if “assignments” is also included. “score_statistics” is only valid if “submission” and “assignments” are also included. The “assignment_visibility” option additionally requires that the Differentiated Assignments course feature be turned on.
        ///
        /// Allowed values:
        /// assignments, discussion_topic, assignment_visibility, submission, score_statistics
        /// </summary>
        IEnumerable<AssignmentGroupGetIncludes> Include { get; set; }

        /// <summary>
        /// Apply assignment overrides for each assignment, defaults to true
        /// </summary>
        bool? OverrideAssignmentDates { get; set; }

        /// <summary>
        /// The id of the grading period in which assignment groups are being requested (Requires grading periods to exist on the account)
        /// </summary>
        long? GradingPeriodId { get; set; }
    }
}
