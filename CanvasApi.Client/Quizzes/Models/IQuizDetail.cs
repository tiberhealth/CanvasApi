using CanvasApi.Client.Quizzes.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Quizzes.Models
{
    public interface IQuizDetail
    {
        [Multipart("title")] string Title { get; set; }
        [Multipart("description")] string Description { get; set; }
        [Multipart("quiz_type")] QuizTypes? QuizType { get; set; }
        [Multipart("assignment_group_id")] long? AssignmentGroupId { get; set; }
        [Multipart("time_limit")] long? TimeLimit { get; set; }
        [Multipart("shuffle_answers")] bool ShuffleAnswers { get; set; }
        [Multipart("hide_results")] HideResultsTypes? HideResults { get; set; }
        [Multipart("show_correct_answers")] bool ShowCorrectAnswers { get; set; }
        [Multipart("show_correct_answers_last_attempt")] bool ShowCorrectAnswersLastAttempt { get; set; }
        [Multipart("show_correct_answers_at")] DateTime? ShowCorrectAnswersAt { get; set; }
        [Multipart("hide_correct_answers_at")] DateTime? HideCorrectAnswersAt { get; set; }
        [Multipart("allowed_attempts")] long AllowedAttempts { get; set; }
        [Multipart("scoring_policy")] ScoringPolicyTypes ScoringPolicy { get; set; }
        [Multipart("one_question_at_a_time")] bool OneQuestionAtATime { get; set; }
        [Multipart("cant_go_back")] bool CantGoBack { get; set; }
        [Multipart("access_code")] string AccessCode { get; set; }
        [Multipart("ip_filter")] string IpFilter { get; set; }
        [Multipart("due_at")] DateTime? DueAt { get; set; }
        [Multipart("lock_at")] DateTime? LockAt { get; set; }
        [Multipart("unlock_at")] DateTime? UnlockAt { get; set; }
        [Multipart("published")] bool? Published { get; set; }
        [Multipart("one_time_results")] bool OneTimeResults { get; set; }
        [Multipart("only_visible_to_overrides")] bool OnlyVisibleToOverrides { get; set; }
        [Multipart("notify_of_update")] bool NotifyOfUpdate { get; set; }
    }
}
