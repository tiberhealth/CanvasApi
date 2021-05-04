using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Enrollments.Enums
{
    [EnumAsString]
    public enum EnrollmentInclude
    {
        AvatarUrl,
        GroupIds,
        Locked,
        ObservedUsers,
        CanBeRemoved,
        Uuid,
        CurrentPoints
    }
}
