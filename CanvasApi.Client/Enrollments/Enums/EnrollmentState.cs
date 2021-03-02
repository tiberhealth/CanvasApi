using System;
using System.ComponentModel.Design;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Enrollments.Enums
{
    [Multipart(EnumAsString = true)]
    public enum EnrollmentState
    {
        Active, Invited, CreationPending, Deleted, Rejected, Completed, Inactive, CurrentAndInvited, CurrentAndFuture, CurrentAndConcluded
    }
}
