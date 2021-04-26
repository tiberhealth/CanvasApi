using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Enrollments.Enums
{
    public enum EnrollmentStatus
    {
        [EnumSerializedValue("active")] Active,
        [EnumSerializedValue("invited_or_pending")] InvitedOrPending,
        [EnumSerializedValue("completed")] Completed
    }
}
