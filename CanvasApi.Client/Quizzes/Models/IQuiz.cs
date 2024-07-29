using CanvasApi.Client.Quizzes.Enums;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace CanvasApi.Client.Quizzes.Models
{
    public interface IQuiz
    {
        long Id { get; }
        string Title { get; }
        string HtmlUrl { get; }
        string MobileUrl { get; }
        string PreviewUrl { get; }
        string Description { get; }
        QuizTypes? QuizType { get; }
        int? AssignmentGroupId { get; }
        long? TimeLimit { get; }
        bool? ShuffleAnswers { get; }
        HideResultsTypes HideResults { get; }
        bool? ShowCorrectAnswers { get; }
        bool? ShowCorrectAnswersLastAttempt { get; }
        DateTime? ShowCorrectAnswersAt { get; }
        DateTime? HideCorrectAnswersAt { get; }
        bool? OneTimeResults { get; }
        ScoringPolicyTypes? ScoringPolicy { get; }
        long? AllowedAttempts { get; }
        bool? OneQuestionAtATime { get; }
        long? QuestionCount { get; }
        long? PointsPossible { get; }
        bool? CantGoBack { get; }
        string AccessCode { get; }
        string IpFilter { get; }
        DateTime? DueAt { get; }
        DateTime? LockAt { get; }
        DateTime? UnlockAt { get; }
        bool? Published { get; }
        bool? Unpublishable { get; }
        bool? LockedForUser { get; }
        JObject LockInfo { get; }
        string LockExplanation { get; }
        string SpeedgraderUrl { get; }
        string QuizExtensionsUrl { get; }
        IQuizPermissions Permissions { get; }
        IEnumerable<DateTime> AllDates { get; }
        long? VersionNumber { get; }
        IEnumerable<string> QuestionTypes { get; }
        bool? AnonymousSubmissions { get; }
    }
}
