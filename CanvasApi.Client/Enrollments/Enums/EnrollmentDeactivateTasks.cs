using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Enrollments.Enums
{
    [Multipart(EnumAsString = true)]
    public enum EnrollmentDeactivateTasks
    {
        Conclude, Delete, Inactivate, Deactivate
    }
}
