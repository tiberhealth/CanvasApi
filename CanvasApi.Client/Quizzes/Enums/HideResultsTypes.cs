using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Quizzes.Enums
{
    [EnumAsString]
    public enum HideResultsTypes
    {
        Always,
        UntilAfterLastAttempt
    }
}
