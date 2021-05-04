using CanvasApi.Client.Quizzes.Enums;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Quizzes.Models
{
    public interface IQuiz
    {
        [Multipart("id")] long Id { get; }
        [Multipart("title")] string Title { get; }
        [Multipart("html_url")] string HtmlUrl { get; }
        [Multipart("mobile_url")] string MobileUrl { get; }
        [Multipart("preview_url")] string PreviewUrl { get; }
        [Multipart("description")] string Description { get; }
        [Multipart("quiz_type")] QuizTypes? QuizType { get; }
        [Multipart("assignment_group_id")] int? AssignmentGroupId { get; }
        [Multipart("time_limit")] long? TimeLimit { get; }
        [Multipart("shuffle_answers")] bool? ShuffleAnswers { get; }
        [Multipart("hide_results")] HideResultsTypes HideResults { get; }
        [Multipart("show_correct_answers")] bool? ShowCorrectAnswers { get; }
        [Multipart("show_correct_answers_last_attempt")] bool? ShowCorrectAnswersLastAttempt { get; }
        [Multipart("show_correct_answers_at")] DateTime? ShowCorrectAnswersAt { get; }
        [Multipart("hide_correct_answers_at")] DateTime? HideCorrectAnswersAt { get; }
        [Multipart("one_time_results")] bool? OneTimeResults { get; }
        [Multipart("scoring_policy")] ScoringPolicyTypes? ScoringPolicy { get; }
        [Multipart("allowed_attempts")] long? AllowedAttempts { get; }
        [Multipart("one_question_at_a_time")] bool? OneQuestionAtATime { get; }
        [Multipart("question_count")] long? QuestionCount { get; }
        [Multipart("points_possible")] long? PointsPossible { get; }
        [Multipart("cant_go_back")] bool? CantGoBack { get; }
        [Multipart("access_code")] string AccessCode { get; }
        [Multipart("ip_filter")] string IpFilter { get; }
        [Multipart("due_at")] DateTime? DueAt { get; }
        [Multipart("lock_at")] DateTime? LockAt { get; }
        [Multipart("unlock_at")] DateTime? UnlockAt { get; }
        [Multipart("published")] bool? Published { get; }
        [Multipart("unpublishable")] bool? Unpublishable { get; }
        [Multipart("locked_for_user")] bool? LockedForUser { get; }
        [Multipart("lock_info")] JObject LockInfo { get; }
        [Multipart("lock_explanation")] string LockExplanation { get; }
        [Multipart("speedgrader_url")] string SpeedgraderUrl { get; }
        [Multipart("quiz_extensions_url")] string QuizExtensionsUrl { get; }
        [Multipart("permissions")] IQuizPermissions Permissions { get; }
        [Multipart("all_dates")] IEnumerable<DateTime> AllDates { get; }
        [Multipart("version_number")] long? VersionNumber { get; }
        [Multipart("question_types")] IEnumerable<string> QuestionTypes { get; }
        [Multipart("anonymous_submissions")] bool? AnonymousSubmissions { get; }
    }
}
