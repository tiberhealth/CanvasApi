using CanvasApi.Client.Quizzes.Enums;
using System;

namespace CanvasApi.Client.Quizzes.Models
{
    internal class QuizDetail : IQuizDetail
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public QuizTypes? QuizType { get; set; }
        public long? AssignmentGroupId { get; set; }
        public long? TimeLimit { get; set; }
        public bool ShuffleAnswers { get; set; }
        public HideResultsTypes? HideResults { get; set; }
        public bool ShowCorrectAnswers { get; set; } = true;
        public bool ShowCorrectAnswersLastAttempt { get; set; }
        public DateTime? ShowCorrectAnswersAt { get; set; }
        public DateTime? HideCorrectAnswersAt { get; set; }
        public long AllowedAttempts { get; set; } = 1;
        public ScoringPolicyTypes ScoringPolicy { get; set; } = 0;
        public bool OneQuestionAtATime { get; set; }
        public bool CantGoBack { get; set; }
        public string AccessCode { get; set; }
        public string IpFilter { get; set; }
        public DateTime? DueAt { get; set; }
        public DateTime? LockAt { get; set; }
        public DateTime? UnlockAt { get; set; }
        public bool? Published { get; set; }
        public bool OneTimeResults { get; set; }
        public bool OnlyVisibleToOverrides { get; set; }
        public bool NotifyOfUpdate { get; set; } = true;
    }
}
