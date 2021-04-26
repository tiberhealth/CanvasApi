using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Enums
{
    [EnumAsString]
    public enum SubmissionListOrder
    {
        [EnumSerializedValue("id")] Id,
        [EnumSerializedValue("graded_at")] GradedAt
    }
}
