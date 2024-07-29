using System.Collections.Generic;
using CanvasApi.Client.AssignmentGroups.Enums;

namespace CanvasApi.Client.AssignmentGroups.Models
{
    public interface IAssignmentGroupListOptions
    {
        /// <summary>
        /// Associations to include with the group. “discussion_topic”, “all_dates”, “can_edit”, “assignment_visibility” & “submission” are only valid if “assignments” is also included. “score_statistics” requires that the “assignments” and “submission” options are included. The “assignment_visibility” option additionally requires that the Differentiated Assignments course feature be turned on. If “observed_users” is passed along with “assignments” and “submission”, submissions for observed users will also be included as an array.
        ///
        /// Allowed values: <see cref="AssignmentListIncludes"/>
        /// assignments, discussion_topic, all_dates, assignment_visibility, overrides, submission, observed_users, can_edit, score_statistics
        /// </summary>
        IEnumerable<AssignmentListIncludes> Include { get; set; }

        /// <summary>
        /// If “assignments” are included, optionally return only assignments having their ID in this array. This argument may also be passed as a comma separated string.
        /// </summary>
        IEnumerable<long> AssignmentIds { get; set; }

        /// <summary>
        /// f “assignments” are included, those with the specified submission types will be excluded from the assignment groups.
        ///
        /// Allowed values: <see cref="SubmissionTypes"/>
        /// online_quiz, discussion_topic, wiki_page, external_tool
        /// /// </summary>
        IEnumerable<SubmissionTypes> ExcludedAssignmentSubmissionTypes { get; set; }

        /// <summary>
        /// Apply assignment overrides for each assignment, defaults to true.
        /// </summary>
        bool? OverrideAssignmentDates { get; set; }

        /// <summary>
        /// The id of the grading period in which assignment groups are being requested (Requires grading periods to exist.)
        /// </summary>
        long? GradingPeriodId { get; set; }

        /// <summary>
        /// If true, all assignments returned will apply to the current user in the specified grading period. If assignments apply to other students in the specified grading period, but not the current user, they will not be returned. (Requires the grading_period_id argument and grading periods to exist. In addition, the current user must be a student.)
        /// </summary>
        bool? ScopeAssignmentsToStudent { get; set; }
    }
}
