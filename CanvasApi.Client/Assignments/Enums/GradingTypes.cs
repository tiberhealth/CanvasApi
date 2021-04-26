using CanvasApi.Client.Assignments.Enums;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Assignments.Enums
{
    [EnumAsString]
    public enum GradingTypes
    {
        [EnumSerializedValue("pass_fail")] PassFail,
        [EnumSerializedValue("percent")] Percent,
        [EnumSerializedValue("letter_grade")] LetterGrade,
        [EnumSerializedValue("gpa_scale")] GpaScale,
        [EnumSerializedValue("points")] Points
    }
}
