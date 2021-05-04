using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Enrollments.Enums
{
    [EnumAsString]
    public enum EnrollmentState
    {
        Active,
        Invited,
        CreationPending,
        Deleted,
        Rejected,
        Completed,
        Inactive,
        CurrentAndInvited,
        CurrentAndFuture,
        CurrentAndConcluded
    }
}
