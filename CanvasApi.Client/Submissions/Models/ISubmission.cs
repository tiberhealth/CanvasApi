using System;
using System.Collections.Generic;
using CanvasApi.Client.Assignments.Models;
using CanvasApi.Client.Courses.Models;
using CanvasApi.Client.Users.Models;

namespace CanvasApi.Client.Submissions.Models
{
    public interface ISubmission
    {
        /// <summary>
        /// The submission's assignment id
        /// </summary>
        long AssignmentId { get; }

        /// <summary>
        /// The submission's assignment (see the assignments API) (optional)
        /// </summary>
        IAssignment Assignment { get; }

        /// The submission's course (see the course API) (optional)
        /// </summary>
        /// </summary>
        ICourse Course { get; }

        /// <summary>
        /// This is the submission attempt number.
        /// </summary>
        int? Attempt { get; }

        /// <summary>
        /// The content of the submission, if it was submitted directly in a text field.
        /// </summary>
        string Body { get; }

        /// <summary>
        /// The grade for the submission, translated into the assignment grading scheme
        /// (so a letter grade, for example).
        /// </summary>
        string Grade { get; }

        /// <summary>
        /// A boolean flag which is false if the student has re-submitted since the
        /// submission was last graded.
        /// </summary>
        bool? GradeMatchesCurrentSubmission { get; }

        /// <summary>
        /// URL to the submission. This will require the user to log in.
        /// </summary>
        string HtmlUrl { get; }

        /// <summary>
        /// URL to the submission preview. This will require the user to log in.
        /// </summary>
        string PreviewUrl { get; }

        /// <summary>
        /// The raw score
        /// </summary>
        decimal? Score { get; }

        /// <summary>
        /// Associated comments for a submission (optional)
        /// </summary>
        IEnumerable<ISubmissionComment> SubmissionComments { get; }

        /// <summary>
        /// The types of submission ex:
        /// ('online_text_entry'|'online_url'|'online_upload'|'media_recording')
        /// </summary>
        string SubmissionType { get; }

        /// <summary>
        /// The timestamp when the assignment was submitted
        /// </summary>
        DateTime? SubmittedAt { get; }

        /// <summary>
        /// The URL of the submission (for 'online_url' submissions).
        /// </summary>
        string Url { get; }

        /// <summary>
        /// The id of the user who created the submission
        /// </summary>
        long? UserId { get; }

        /// <summary>
        /// The id of the user who graded the submission. This will be null for
        /// submissions that haven't been graded yet. It will be a positive number if a
        /// real user has graded the submission and a negative number if the submission
        /// was graded by a process (e.g. Quiz autograder and autograding LTI tools). 
        /// Specifically autograded quizzes set grader_id to the negative of the quiz id.
        /// Submissions autograded by LTI tools set grader_id to the negative of the tool
        /// id.
        /// </summary>
        long? GraderId { get; }
        DateTime? GradedAt { get; }

        /// <summary>
        /// The submissions user (see user API) (optional)
        /// </summary>
        IUserDisplay User { get; }

        /// <summary>
        /// Whether the submission was made after the applicable due date
        /// </summary>
        bool? Late { get; }

        /// <summary>
        /// Whether the assignment is visible to the user who submitted the assignment.
        /// Submissions where `assignment_visible` is false no longer count towards the
        /// student's grade and the assignment can no longer be accessed by the student.
        /// `assignment_visible` becomes false for submissions that do not have a grade
        /// and whose assignment is no longer assigned to the student's section.
        /// </summary>
        bool? AssignmentVisible { get; }

        /// <summary>
        /// Whether the assignment is excused.  Excused assignments have no impact on a
        /// user's grade.
        /// </summary>
        bool? Excused { get; }

        /// <summary>
        /// Whether the assignment is missing.
        /// </summary>
        bool? Missing { get; }

        /// <summary>
        /// The status of the submission in relation to the late policy. Can be late,
        /// missing, none, or null.
        /// </summary>
        string LatePolicyStatus { get; }

        /// <summary>
        /// The amount of points automatically deducted from the score by the
        /// missing/late policy for a late or missing assignment.
        /// </summary>
        decimal? PointsDeducted { get; }

        /// <summary>
        /// The amount of time, in seconds, that an submission is late by.
        /// </summary>
        long? SecondsLate { get; }

        /// <summary>
        /// The current state of the submission
        /// </summary>
        string WorkflowState { get; }

        /// <summary>
        /// Extra submission attempts allowed for the given user and assignment.
        /// </summary>
        int? ExtraAttempts { get; }

        /// <summary>
        /// A unique short ID identifying this submission without reference to the owning
        /// user. Only included if the caller has administrator access for the current
        /// account.
        /// </summary>
        string AnonymousId { get; }

        /// <summary>
        /// The date this submission was posted to the student, or nil if it has not been
        /// posted.
        /// </summary>
        DateTime? PostedAt { get;  }
    }
}
