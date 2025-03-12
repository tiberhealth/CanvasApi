﻿namespace CanvasApi.Client.Quizzes.Models;

public interface IQuizPermissions
{
    bool? Read { get; }
    bool? Submit { get; }
    bool? Create { get; }
    bool? Manage { get; }
    bool? ReadStatistics { get; }
    bool? ReviewGrades { get; }
    bool? Update { get; }
}