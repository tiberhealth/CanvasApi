using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Enrollments.Enums
{
    [Multipart(EnumAsString = true)]
    public enum EnrollmentInclude
    {
        AvatarUrl, GroupIds, Locked, ObservedUsers, CanBeRemoved, Uuid, CurrentPoints
    }
}
