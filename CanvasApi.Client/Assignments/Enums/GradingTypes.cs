using CanvasApi.Client.Assignments.Enums;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Assignments.Enums
{
    [EnumAsString]
    public enum GradingTypes
    {
        PassFail,
        Percent,
        LetterGrade,
        GpaScale,
        Points
    }
}
