using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Enrollments.Enums
{
    [EnumAsString]
    public enum EnrollmentInclude
    {
        [EnumSerializedValue("avatar_url")] AvatarUrl,
        [EnumSerializedValue("group_ids")] GroupIds,
        [EnumSerializedValue("locked")] Locked,
        [EnumSerializedValue("observed_users")] ObservedUsers,
        [EnumSerializedValue("can_be_removed")] CanBeRemoved,
        [EnumSerializedValue("uuid")] Uuid,
        [EnumSerializedValue("current_points")] CurrentPoints
    }
}
