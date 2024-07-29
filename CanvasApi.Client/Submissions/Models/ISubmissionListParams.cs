using System;
using System.Collections.Generic;
using CanvasApi.Client.Submissions.Enums;

namespace CanvasApi.Client.Submissions.Models
{
    public interface ISubmissionListParams
    {
        /// <summary>
        /// List of student ids to return submissions for. If this argument is omitted, return submissions for the calling user. Students may only list their own submissions. Observers may only list those of associated students. The special id “all” will return submissions for all students in the course/section as appropriate
        /// </summary>
        IEnumerable<string> StudentIds { get; set; }

        /// <summary>
        /// List of assignments to return submissions for. If none are given, submissions for all assignments are returned
        /// </summary>
        IEnumerable<long> AssignmentIds { get; set; }

        /// <summary>
        /// If this argument is present, the response will be grouped by student, rather than a flat array of submissions.
        /// </summary>
        bool? Grouped { get; internal set; }

        /// <summary>
        /// If this argument is set to true, the response will only include submissions for assignments that have the post_to_sis flag set to true and user enrollments that were added through sis.
        /// </summary>
        bool? PostToSis { get; set; }

        /// <summary>
        /// f this argument is set, the response will only include submissions that were submitted after the specified date_time. This will exclude submissions that do not have a submitted_at which will exclude unsubmitted submissions. The value must be formatted as ISO 8601 YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        DateTime? SubmittedSince { get; set; }

        /// <summary>
        /// If this argument is set, the response will only include submissions that were graded after the specified date_time. This will exclude submissions that have not been graded. The value must be formatted as ISO 8601 YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        DateTime? GradedSince { get; set; }

        /// <summary>
        /// The id of the grading period in which submissions are being requested (Requires grading periods to exist on the account)
        /// </summary>
        long? GradingPeriodId { get; set; }

        /// <summary>
        /// The current status of the submission
        ///
        /// Allowed values:
        /// submitted, unsubmitted, graded, pending_review
        /// </summary>
        SubmissionWorkFlowStates? WorkFlowState { get; set; }

        /// <summary>
        /// The current state of the enrollments. If omitted will include all enrollments that are not deleted.
        ///
        /// Allowed values:
        /// active, concluded
        /// </summary>
        SubmissionEnrollmentStates? EnrollmentState { get; set; }

        /// <summary>
        /// If omitted it is set to true. When set to false it will ignore the effective state of the student enrollments and use the workflow_state for the enrollments. The argument is ignored unless enrollment_state argument is also passed.
        /// </summary>
        bool? StatedBasedOnDate { get; set; }

        /// <summary>
        /// The order submissions will be returned in. Defaults to “id”. Doesn't affect results for “grouped” mode.
        ///
        /// Allowed values:
        /// id, graded_at
        /// </summary>
        SubmissionListOrder? Order { get; set; }

        /// <summary>
        /// Determines whether ordered results are returned in ascending or descending order. Defaults to “ascending”. Doesn't affect results for “grouped” mode.
        ///
        /// Allowed values:
        /// ascending, descending
        /// </summary>
        SubmissionOrderDirection? OrderDirection { get; set; }

        /// <summary>
        /// Associations to include with the group. `total_scores` requires the `grouped` argument.
        ///
        /// Allowed values:
        /// submission_history, submission_comments, rubric_assessment, assignment, total_scores, visibility, course, user
        /// </summary>
        IEnumerable<SubmissionListInclude> Include { get; set; }
      }
}
