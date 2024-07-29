using System;
using System.Collections.Generic;
using CanvasApi.Client.Assignments.Enums;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.Assignments.Models
{
    public interface IAssignment
    {
        /// <summary>
        /// the ID of the assignment
        /// </summary>
        long Id { get; }

        /// <summary>
        /// the name of the assignment
        /// </summary>
        string Name { get; }

        /// <summary>
        /// the assignment description, in an HTML fragment
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The time at which this assignment was originally created
        /// </summary>
        DateTime? CreatedAt { get; }

        /// <summary>
        /// The time at which this assignment was last modified in any way
        /// </summary>
        DateTime? UpdatedAt { get; }

        /// <summary>
        /// the due date for the assignment. returns null if not present. NOTE: If this
        /// assignment has assignment overrides, this field will be the due date as it
        /// applies to the user requesting information from the API.
        /// </summary>
        DateTime? DueAt { get; }

        /// <summary>
        /// the lock date (assignment is locked after this date). returns null if not
        /// present. NOTE: If this assignment has assignment overrides, this field will
        /// be the lock date as it applies to the user requesting information from the
        /// API.
        /// </summary>
        DateTime? LockAt { get; }

        /// <summary>
        /// the unlock date (assignment is unlocked after this date) returns null if not
        /// present NOTE: If this assignment has assignment overrides, this field will be
        /// the unlock date as it applies to the user requesting information from the
        /// API.
        /// </summary>
        DateTime? UnlockAt { get; }

        /// <summary>
        /// whether this assignment has overrides
        /// </summary>
        bool? HasOverrides { get; }

        /// <summary>
        /// (Optional) all dates associated with the assignment, if applicable
        /// </summary>
        IEnumerable<IAssignmentDate> AllDates { get; }

        /// <summary>
        /// the ID of the course the assignment belongs to
        /// </summary>
        long? CourseId { get; }

        /// <summary>
        /// the URL to the assignment's web page
        /// </summary>
        string HtmlUrl { get; }

        /// <summary>
        /// the URL to download all submissions as a zip
        /// </summary>
        string SubmissionsDownloadUrl { get; }

        /// <summary>
        /// the ID of the assignment's group
        /// </summary>
        long? AssignmentGroupId { get; }

        /// <summary>
        /// Boolean flag indicating whether the assignment requires a due date based on
        /// the account level setting
        /// </summary>
        bool? DueDateRequired { get; }

        /// <summary>
        /// Allowed file extensions, which take effect if submission_types includes
        /// 'online_upload'.
        /// </summary>
        IEnumerable<string> AllowedExtensions { get; }

        /// <summary>
        /// An integer indicating the maximum length an assignment's name may be
        /// </summary>
        int? MaxNameLength { get; }

        /// <summary>
        /// Boolean flag indicating whether or not Turnitin has been enabled for the
        /// assignment. NOTE: This flag will not appear unless your account has the
        /// Turnitin plugin available
        /// </summary>
        bool? TurnitinEnabled { get; }

        /// <summary>
        /// Boolean flag indicating whether or not VeriCite has been enabled for the
        /// assignment. NOTE: This flag will not appear unless your account has the
        /// VeriCite plugin available
        /// </summary>
        bool? VericiteEnabled { get; }

        /// <summary>
        /// Settings to pass along to turnitin to control what kinds of matches should be
        /// considered. originality_report_visibility can be 'immediate',
        /// 'after_grading', 'after_due_date', or 'never' exclude_small_matches_type can
        /// be null, 'percent', 'words' exclude_small_matches_value: - if type is null,
        /// this will be null also - if type is 'percent', this will be a number between
        /// 0 and 100 representing match size to exclude as a percentage of the document
        /// size. - if type is 'words', this will be number > 0 representing how many
        /// words a match must contain for it to be considered NOTE: This flag will not
        /// appear unless your account has the Turnitin plugin available
        /// </summary>
        ITurnItInSettings TurnitinSettings { get; }

        /// <summary>
        /// If this is a group assignment, boolean flag indicating whether or not
        /// students will be graded individually.
        /// </summary>
        bool? GradeGroupStudentsIndividually { get; }

        /// <summary>
        /// (Optional) assignment's settings for external tools if submission_types
        /// include 'external_tool'. Only url and new_tab are included (new_tab defaults
        /// to false).  Use the 'External Tools' API if you need more information about
        /// an external tool.
        /// </summary>
        IExternalToolTagAttribute ExternalToolTagAttributes { get; }

        /// <summary>
        /// Boolean indicating if peer reviews are required for this assignment
        /// </summary>
        bool? PeerReviews { get; }

        /// <summary>
        /// Boolean indicating peer reviews are assigned automatically. If false, the
        /// teacher is expected to manually assign peer reviews.
        /// </summary>
        bool? AutomaticPeerReviews { get; }

        /// <summary>
        /// Integer representing the amount of reviews each user is assigned. NOTE: This
        /// key is NOT present unless you have automatic_peer_reviews set to true.
        /// </summary>
        int? PeerReviewCount { get; }

        /// <summary>
        /// String representing a date the reviews are due by. Must be a date that occurs
        /// after the default due date. If blank, or date is not after the assignment's
        /// due date, the assignment's due date will be used. NOTE: This key is NOT
        /// present unless you have automatic_peer_reviews set to true.
        /// </summary>
        DateTime? PeerReviewsAssignAt { get; }

        /// <summary>
        /// Boolean representing whether or not members from within the same group on a
        /// group assignment can be assigned to peer review their own group's work
        /// </summary>
        bool? IntraGroupPeerReviews { get; }

        /// <summary>
        /// The ID of the assignment’s group set, if this is a group assignment. For
        /// group discussions, set group_category_id on the discussion topic, not the
        /// linked assignment.
        /// </summary>
        long? GroupCategoryId { get; }

        /// <summary>
        /// if the requesting user has grading rights, the number of submissions that
        /// need grading.
        /// </summary>
        int? NeedsGradingCount { get; }

        /// <summary>
        /// if the requesting user has grading rights and the
        /// 'needs_grading_count_by_section' flag is specified, the number of submissions
        /// that need grading split out by section. NOTE: This key is NOT present unless
        /// you pass the 'needs_grading_count_by_section' argument as true.  ANOTHER
        /// NOTE: it's possible to be enrolled in multiple sections, and if a student is
        /// setup that way they will show an assignment that needs grading in multiple
        /// sections (effectively the count will be duplicated between sections)
        /// </summary>
        IEnumerable<INeedsGradingCount> NeedsGradingCountBySection { get; }

        /// <summary>
        /// the sorting order of the assignment in the group
        /// </summary>
        int? Position { get; }

        /// <summary>
        /// (optional, present if Sync Grades to SIS feature is enabled)
        /// </summary>
        bool? PostToSis { get; }

        /// <summary>
        /// (optional, Third Party unique identifier for Assignment)
        /// </summary>
        string IntegrationId { get; }

        /// <summary>
        /// (optional, Third Party integration data for assignment)
        /// </summary>
        JObject IntegrationData { get; }

        /// <summary>
        /// the maximum points possible for the assignment
        /// </summary>
        decimal? PointsPossible { get; }

        /// <summary>
        /// the types of submissions allowed for this assignment list containing one or
        /// more of the following: 'discussion_topic', 'online_quiz', 'on_paper', 'none',
        /// 'external_tool', 'online_text_entry', 'online_url', 'online_upload'
        /// 'media_recording'
        /// </summary>
        IEnumerable<SubmissionTypes> SubmissionTypes { get; }

        /// <summary>
        /// If true, the assignment has been submitted to by at least one student
        /// </summary>
        bool? HasSubmittedSubmissions { get; }

        /// <summary>
        /// The type of grading the assignment receives; one of 'pass_fail', 'percent',
        /// 'letter_grade', 'gpa_scale', 'points'
        /// </summary>
        GradingTypes? GradingType { get; }

        /// <summary>
        /// The id of the grading standard being applied to this assignment. Valid if
        /// grading_type is 'letter_grade' or 'gpa_scale'.
        /// </summary>
        long? GradingStandardId { get; }

        /// <summary>
        /// Whether the assignment is published
        /// </summary>
        bool? Published { get; }

        /// <summary>
        /// Whether the assignment's 'published' state can be changed to false. Will be
        /// false if there are student submissions for the assignment.
        /// </summary>
        bool? Unpublishable { get; }

        /// <summary>
        /// Whether the assignment is only visible to overrides.
        /// </summary>
        bool? OnlyVisibleToOverrides { get; }

        /// <summary>
        /// Whether or not this is locked for the user.
        /// </summary>
        bool? LockedForUser { get; }

        /// <summary>
        /// (Optional) Information for the user about the lock. Present when
        /// locked_for_user is true.
        /// </summary>
        ILockInfo LockInfo { get; }

        /// <summary>
        /// (Optional) An explanation of why this is locked for the user. Present when
        /// locked_for_user is true.
        /// </summary>
        string LockExplanation { get; }

        /// <summary>
        /// (Optional) id of the associated quiz (applies only when submission_types is
        /// ['online_quiz'])
        /// </summary>
        long? QuizId { get; }

        /// <summary>
        /// (Optional) whether anonymous submissions are accepted (applies only to quiz
        /// assignments)
        /// </summary>
        bool? AnonymousSubmissions { get; }

        /// <summary>
        /// (Optional) the DiscussionTopic associated with the assignment, if applicable
        /// </summary>
        JObject DiscussionTopic { get; }

        /// <summary>
        /// (Optional) Boolean indicating if assignment will be frozen when it is copied.
        /// NOTE: This field will only be present if the AssignmentFreezer plugin is
        /// available for your account.
        /// </summary>
        bool? FreezeOnCopy { get; }

        /// <summary>
        /// (Optional) Boolean indicating if assignment is frozen for the calling user.
        /// NOTE: This field will only be present if the AssignmentFreezer plugin is
        /// available for your account.
        /// </summary>
        bool? Frozen { get; }

        /// <summary>
        /// (Optional) Array of frozen attributes for the assignment. Only account
        /// administrators currently have permission to change an attribute in this list.
        /// Will be empty if no attributes are frozen for this assignment. Possible
        /// frozen attributes are: title, description, lock_at, points_possible,
        /// grading_type, submission_types, assignment_group_id, allowed_extensions,
        /// group_category_id, notify_of_update, peer_reviews NOTE: This field will only
        /// be present if the AssignmentFreezer plugin is available for your account.
        /// </summary>
        IEnumerable<FreezableAttributes> FrozenAttributes { get; }

        /// <summary>
        /// (Optional) If 'submission' is included in the 'include' parameter, includes a
        /// Submission object that represents the current user's (user who is requesting
        /// information from the api) current submission for the assignment. See the
        /// Submissions API for an example response. If the user does not have a
        /// submission, this key will be absent.
        /// </summary>
        JObject Submission { get; }

        /// <summary>
        /// (Optional) If true, the rubric is directly tied to grading the assignment.
        /// Otherwise, it is only advisory. Included if there is an associated rubric.
        /// </summary>
        bool? UseRubricForGrading { get; }

        /// <summary>
        /// (Optional) An object describing the basic attributes of the rubric, including
        /// the point total. Included if there is an associated rubric.
        /// </summary>
        JObject RubricSettings { get; }

        /// <summary>
        /// (Optional) A list of scoring criteria and ratings for each rubric criterion.
        /// Included if there is an associated rubric.
        /// </summary>
        IEnumerable<IRubricCriteria> Rubric { get; }

        /// <summary>
        /// (Optional) If 'assignment_visibility' is included in the 'include' parameter,
        /// includes an array of student IDs who can see this assignment.
        /// </summary>
        IEnumerable<long> AssignmentVisibility { get; }

        /// <summary>
        /// (Optional) If 'overrides' is included in the 'include' parameter, includes an
        /// array of assignment override objects.
        /// </summary>
        JObject Overrides { get; }

        /// <summary>
        /// (Optional) If true, the assignment will be omitted from the student's final
        /// grade
        /// </summary>
        bool? OmitFromFinalGrade { get; }

        /// <summary>
        /// Boolean indicating if the assignment is moderated.
        /// </summary>
        bool? ModeratedGrading { get; }

        /// <summary>
        /// The maximum number of provisional graders who may issue grades for this
        /// assignment. Only relevant for moderated assignments. Must be a positive
        /// value, and must be set to 1 if the course has fewer than two active
        /// instructors. Otherwise, the maximum value is the number of active instructors
        /// in the course minus one, or 10 if the course has more than 11 active
        /// instructors.
        /// </summary>
        int? GraderCount { get; }

        /// <summary>
        /// The user ID of the grader responsible for choosing final grades for this
        /// assignment. Only relevant for moderated assignments.
        /// </summary>
        long? FinalGraderId { get; }

        /// <summary>
        /// Boolean indicating if provisional graders' comments are visible to other
        /// provisional graders. Only relevant for moderated assignments.
        /// </summary>
        bool? GraderCommentsVisibleToGraders { get; }

        /// <summary>
        /// Boolean indicating if provisional graders' identities are hidden from other
        /// provisional graders. Only relevant for moderated assignments with
        /// grader_comments_visible_to_graders set to true.
        /// </summary>
        bool? GradersAnonymousToGraders { get; }

        /// <summary>
        /// Boolean indicating if provisional grader identities are visible to the final
        /// grader. Only relevant for moderated assignments.
        /// </summary>
        bool? GraderNamesVisibleToFinalGrader { get; }

        /// <summary>
        /// Boolean indicating if the assignment is graded anonymously. If true, graders
        /// cannot see student identities.
        /// </summary>
        bool? AnonymousGrading { get; }

        /// <summary>
        /// The number of submission attempts a student can make for this assignment. -1
        /// is considered unlimited.
        /// </summary>
        int? AllowedAttempts { get; }

        /// <summary>
        /// Whether the assignment has manual posting enabled. Only relevant for courses
        /// using New Gradebook.
        /// </summary>
        bool? PostManually { get; }

        /// <summary>
        /// (Optional) If 'score_statistics' and 'submission' are included in the
        /// 'include' parameter and statistics are available, includes the min, max, and
        /// mode for this assignment
        /// </summary>
        IScoreStatistic ScoreStatistics { get; }

        /// <summary>
        /// (Optional) If retrieving a single assignment and 'can_submit' is included in
        /// the 'include' parameter, flags whether user has the right to submit the
        /// assignment (i.e. checks enrollment dates, submission types, locked status,
        /// attempts remaining, etc...). Including 'can submit' automatically includes
        /// 'submission' in the include parameter.
        /// </summary>
        bool? CanSubmit { get; }

        bool? AnonymizeStudents { get; }
        bool? RequireLockdownBrowser { get; }
        bool? InClosedGradingPeriod { get; }
        bool? Muted { get; }
        string WorkflowState { get; }
        long? OriginalQuizId { get; }
        string OriginalAssignmentName { get; }
        long? OriginalAssignmentId { get; }
        long? OriginalCourseId { get; }
        bool? CanDuplicate { get; }
        bool? IsQuizAssignment { get; }
        string SecureParams { get; }
    }
}
