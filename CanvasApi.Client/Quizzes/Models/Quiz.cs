using CanvasApi.Client.Quizzes.Enums;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace CanvasApi.Client.Quizzes.Models
{
    internal class Quiz : IQuiz
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string HtmlUrl { get; set; }
        public string MobileUrl { get; set; }
        public string PreviewUrl { get; set; }
        public string Description { get; set; }
        public QuizTypes? QuizType { get; set; }
        public int? AssignmentGroupId { get; set; }
        public long? TimeLimit { get; set; }
        public bool? ShuffleAnswers { get; set; }
        public HideResultsTypes HideResults { get; set; }
        public bool? ShowCorrectAnswers { get; set; }
        public bool? ShowCorrectAnswersLastAttempt { get; set; }
        public DateTime? ShowCorrectAnswersAt { get; set; }
        public DateTime? HideCorrectAnswersAt { get; set; }
        public bool? OneTimeResults { get; set; }
        public ScoringPolicyTypes? ScoringPolicy { get; set; }
        public long? AllowedAttempts { get; set; }
        public bool? OneQuestionAtATime { get; set; }
        public long? QuestionCount { get; set; }
        public long? PointsPossible { get; set; }
        public bool? CantGoBack { get; set; }
        public string AccessCode { get; set; }
        public string IpFilter { get; set; }
        public DateTime? DueAt { get; set; }
        public DateTime? LockAt { get; set; }
        public DateTime? UnlockAt { get; set; }
        public bool? Published { get; set; }
        public bool? Unpublishable { get; set; }
        public bool? LockedForUser { get; set; }
        public JObject LockInfo { get; set; }
        public string LockExplanation { get; set; }
        public string SpeedgraderUrl { get; set; }
        public string QuizExtensionsUrl { get; set; }
        public QuizPermissions Permissions { get; set; }
        IQuizPermissions IQuiz.Permissions => Permissions;
        public IEnumerable<DateTime> AllDates { get; set; }
        public long? VersionNumber { get; set; }
        public IEnumerable<string> QuestionTypes { get; set; }
        public bool? AnonymousSubmissions { get; set; }
    }
}
