using CanvasApi.Client.Quizzes.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Quizzes.Models
{
    public interface IQuizDetail
    {
        string Title { get; set; }
        string Description { get; set; }
        QuizTypes? QuizType { get; set; }
        long? AssignmentGroupId { get; set; }
        long? TimeLimit { get; set; }
        bool ShuffleAnswers { get; set; }
        HideResultsTypes? HideResults { get; set; }
        bool ShowCorrectAnswers { get; set; }
        bool ShowCorrectAnswersLastAttempt { get; set; }
        DateTime? ShowCorrectAnswersAt { get; set; }
        DateTime? HideCorrectAnswersAt { get; set; }
        long AllowedAttempts { get; set; }
        ScoringPolicyTypes ScoringPolicy { get; set; }
        bool OneQuestionAtATime { get; set; }
        bool CantGoBack { get; set; }
        string AccessCode { get; set; }
        string IpFilter { get; set; }
        DateTime? DueAt { get; set; }
        DateTime? LockAt { get; set; }
        DateTime? UnlockAt { get; set; }
        bool? Published { get; set; }
        bool OneTimeResults { get; set; }
        bool OnlyVisibleToOverrides { get; set; }
        bool NotifyOfUpdate { get; set; }
    }
}
