using System;
using System.Collections.Generic;
using System.Linq;
using CanvasApi.Client.Assignments.Enums;
using CanvasApi.Client.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.Assignments.Models
{
    internal class Assignment : IAssignment
    {
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("created_at")] public DateTime? CreatedAt { get; set; }
        [JsonProperty("updated_at")] public DateTime? UpdatedAt { get; set; }
        [JsonProperty("due_at")] public DateTime? DueAt { get; set; }
        [JsonProperty("lock_at")] public DateTime? LockAt { get; set; }
        [JsonProperty("unlock_at")] public DateTime? UnlockAt { get; set; }
        [JsonProperty("has_overrides")] public bool? HasOverrides { get; set; }

        [JsonProperty("all_dates")] public AssignmentDate[] AllDates { get; set; }
        IEnumerable<IAssignmentDate> IAssignment.AllDates => AllDates;


        [JsonProperty("course_id")] public long? CourseId { get; set; }
        [JsonProperty("html_url")] public string HtmlUrl { get; set; }
        [JsonProperty("submissions_download_url")] public string SubmissionsDownloadUrl { get; set; }
        [JsonProperty("assignment_group_id")] public long? AssignmentGroupId { get; set; }
        [JsonProperty("due_date_required")] public bool? DueDateRequired { get; set; }
        [JsonProperty("allowed_extensions")] public IEnumerable<string> AllowedExtensions { get; set; }
        [JsonProperty("max_name_length")] public int? MaxNameLength { get; set; }
        [JsonProperty("turnitin_enabled")] public bool? TurnitinEnabled { get; set; }
        [JsonProperty("vericite_enabled")] public bool? VericiteEnabled { get; set; }

        [JsonProperty("turnitin_settings")] public TurnItInSettings TurnitinSettings { get; set; }
        ITurnItInSettings IAssignment.TurnitinSettings => TurnitinSettings;

        [JsonProperty("grade_group_students_individually")] public bool? GradeGroupStudentsIndividually { get; set; }

        [JsonProperty("external_tool_tag_attributes")] public ExternalToolTagAttribute ExternalToolTagAttributes { get; set; }
        IExternalToolTagAttribute IAssignment.ExternalToolTagAttributes => ExternalToolTagAttributes;

        [JsonProperty("peer_reviews")] public bool? PeerReviews { get; set; }
        [JsonProperty("automatic_peer_reviews")] public bool? AutomaticPeerReviews { get; set; }
        [JsonProperty("peer_review_count")] public int? PeerReviewCount { get; set; }
        [JsonProperty("peer_reviews_assign_at")] public DateTime? PeerReviewsAssignAt { get; set; }
        [JsonProperty("intra_group_peer_reviews")] public bool? IntraGroupPeerReviews { get; set; }
        [JsonProperty("group_category_id")] public long? GroupCategoryId { get; set; }
        [JsonProperty("needs_grading_count")] public int? NeedsGradingCount { get; set; }

        [JsonProperty("needs_grading_count_by_section")] public NeedsGradingCountObj[] NeedsGradingCountBySection { get; set; }
        IEnumerable<INeedsGradingCount> IAssignment.NeedsGradingCountBySection => NeedsGradingCountBySection;

        [JsonProperty("position")] public int? Position { get; set; }
        [JsonProperty("post_to_sis")] public bool? PostToSis { get; set; }
        [JsonProperty("integration_id")] public string IntegrationId { get; set; }
        [JsonProperty("integration_data")] public JObject IntegrationData { get; set; }
        [JsonProperty("points_possible")] public decimal? PointsPossible { get; set; }

        [JsonProperty("submission_types")] public string[] SubmissionTypes { get; set; }
        IEnumerable<SubmissionTypes> IAssignment.SubmissionTypes =>
            SubmissionTypes?
                .Select(item => item.ToEnum<SubmissionTypes>())
                .Where(item => item != null)
                .Select(item => item.Value)
                .Distinct()
                .ToArray();

        [JsonProperty("has_submitted_submissions")] public bool? HasSubmittedSubmissions { get; set; }

        [JsonProperty("grading_type")] public string GradingType { get; set; }
        GradingTypes? IAssignment.GradingType => GradingType?.ToEnum<GradingTypes>();

        [JsonProperty("grading_standard_id")] public long? GradingStandardId { get; set; }
        [JsonProperty("published")] public bool? Published { get; set; }
        [JsonProperty("unpublishable")] public bool? Unpublishable { get; set; }
        [JsonProperty("only_visible_to_overrides")] public bool? OnlyVisibleToOverrides { get; set; }
        [JsonProperty("locked_for_user")] public bool? LockedForUser { get; set; }

        [JsonProperty("lock_info")] public LockInfo LockInfo { get; set; }
        ILockInfo IAssignment.LockInfo => LockInfo;

        [JsonProperty("lock_explanation")] public string LockExplanation { get; set; }
        [JsonProperty("quiz_id")] public long? QuizId { get; set; }
        [JsonProperty("anonymous_submissions")] public bool? AnonymousSubmissions { get; set; }
        [JsonProperty("discussion_topic")] public JObject DiscussionTopic { get; set; }
        [JsonProperty("freeze_on_copy")] public bool? FreezeOnCopy { get; set; }
        [JsonProperty("frozen")] public bool? Frozen { get; set; }

        [JsonProperty("frozen_attributes")] public string[] FrozenAttributes { get; set; }
        IEnumerable<FreezableAttributes> IAssignment.FrozenAttributes =>
            FrozenAttributes?
            .Select(item => item.ToEnum<FreezableAttributes>())
            .Where(item => item != null)
            .Select(item => item.Value)
            .Distinct()
            .ToArray();

        [JsonProperty("submission")] public JObject Submission { get; set; }
        [JsonProperty("use_rubric_for_grading")] public bool? UseRubricForGrading { get; set; }
        [JsonProperty("rubric_settings")] public JObject RubricSettings { get; set; }

        [JsonProperty("rubric")] public RubricCriteria[] Rubric { get; set; }
        IEnumerable<IRubricCriteria> IAssignment.Rubric => Rubric;

        [JsonProperty("assignment_visibility")] public IEnumerable<long> AssignmentVisibility { get; set; }
        [JsonProperty("overrides")] public JObject Overrides { get; set; }
        [JsonProperty("omit_from_final_grade")] public bool? OmitFromFinalGrade { get; set; }
        [JsonProperty("moderated_grading")] public bool? ModeratedGrading { get; set; }
        [JsonProperty("grader_count")] public int? GraderCount { get; set; }
        [JsonProperty("final_grader_id")] public long? FinalGraderId { get; set; }
        [JsonProperty("grader_comments_visible_to_graders")] public bool? GraderCommentsVisibleToGraders { get; set; }
        [JsonProperty("graders_anonymous_to_graders")] public bool? GradersAnonymousToGraders { get; set; }
        [JsonProperty("grader_names_visible_to_final_grader")] public bool? GraderNamesVisibleToFinalGrader { get; set; }
        [JsonProperty("anonymous_grading")] public bool? AnonymousGrading { get; set; }
        [JsonProperty("allowed_attempts")] public int? AllowedAttempts { get; set; }
        [JsonProperty("post_manually")] public bool? PostManually { get; set; }

        [JsonProperty("score_statistics")] public ScoreStatistic ScoreStatistics { get; set; }
        IScoreStatistic IAssignment.ScoreStatistics => ScoreStatistics;

        [JsonProperty("can_submit")] public bool? CanSubmit { get; set; }

        [JsonProperty("anonymize_students")] public bool? AnonymizeStudents { get; set; }
        [JsonProperty("require_lockdown_browser")] public bool? RequireLockdownBrowser { get; set; }
        [JsonProperty("in_closed_grading_period")] public bool? InClosedGradingPeriod { get; set; }
        [JsonProperty("muted")] public bool? Muted { get; set; }
        [JsonProperty("workflow_state")] public string WorkflowState { get; set; }
        [JsonProperty("original_quiz_id")] public long? OriginalQuizId { get; set; }
        [JsonProperty("original_assignment_name")] public string OriginalAssignmentName { get; set; }
        [JsonProperty("original_assignment_id")] public long? OriginalAssignmentId { get; set; }
        [JsonProperty("original_course_id")] public long? OriginalCourseId { get; set; }
        [JsonProperty("can_duplicate")] public bool? CanDuplicate { get; set; }
        [JsonProperty("is_quiz_assignment")] public bool? IsQuizAssignment { get; set; }
        [JsonProperty("secure_params")] public string SecureParams { get; set; }

    }
}
