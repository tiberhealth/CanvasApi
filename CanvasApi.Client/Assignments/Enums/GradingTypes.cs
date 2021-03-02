using System;
using System.Diagnostics.CodeAnalysis;
using CanvasApi.Client.Assignments.Enums;

namespace CanvasApi.Client.Assignments.Enums
{
    public enum GradingTypes
    {
        PassFail,
        Percent,
        LetterGrade,
        GpaScale,
        Points
    }
}

internal static class GradingTypeHelper
{
    public static GradingTypes? ToGradingType(this string value) =>
        value?.Trim().ToLower() switch
        {
            "pass_fail" => GradingTypes.PassFail,
            "percent" => GradingTypes.Percent,
            "letter_grade" => GradingTypes.LetterGrade,
            "gpa_scale" => GradingTypes.GpaScale,
            "points" => GradingTypes.Points,
            _ => null
        };
}