using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Enums
{
    [EnumAsString]
    public enum SubmissionEnrollmentStates
    {
        [EnumSerializedValue("active")] Active,
        [EnumSerializedValue("concluded")] Concluded
    }
}
