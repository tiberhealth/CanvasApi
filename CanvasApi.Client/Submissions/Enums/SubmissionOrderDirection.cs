using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Enums
{
    [EnumAsString]
    public enum SubmissionOrderDirection
    {
        [EnumSerializedValue("ascending")] Ascending,
        [EnumSerializedValue("descending")] Descending
    }
}
