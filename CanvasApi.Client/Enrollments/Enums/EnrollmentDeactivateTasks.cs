using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Enrollments.Enums
{
    [EnumAsString]
    public enum EnrollmentDeactivateTasks
    {
        Conclude,
        Delete,
        Inactivate,
        Deactivate
    }
}
