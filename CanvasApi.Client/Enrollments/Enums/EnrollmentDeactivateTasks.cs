using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Enrollments.Enums
{
    [EnumAsString]
    public enum EnrollmentDeactivateTasks
    {
        [EnumSerializedValue("conclude")] Conclude,
        [EnumSerializedValue("delete")] Delete,
        [EnumSerializedValue("inactivatge")] Inactivate,
        [EnumSerializedValue("deactivate")] Deactivate
    }
}
