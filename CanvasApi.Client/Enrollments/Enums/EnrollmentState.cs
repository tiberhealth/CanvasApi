using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Enrollments.Enums
{
    [EnumAsString]
    public enum EnrollmentState
    {
        [EnumSerializedValue("active")] Active,
        [EnumSerializedValue("invited")] Invited,
        [EnumSerializedValue("creation_pending")] CreationPending,
        [EnumSerializedValue("deleted")] Deleted,
        [EnumSerializedValue("rejected")] Rejected,
        [EnumSerializedValue("completed")] Completed,
        [EnumSerializedValue("inactive")] Inactive,
        [EnumSerializedValue("current_and_invited")] CurrentAndInvited,
        [EnumSerializedValue("current_and_future")] CurrentAndFuture,
        [EnumSerializedValue("current_and_concluded")] CurrentAndConcluded
    }
}
