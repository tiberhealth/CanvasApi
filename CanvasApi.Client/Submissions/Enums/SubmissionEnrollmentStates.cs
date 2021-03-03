using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Enums
{
    [Multipart(EnumAsString = true)]
    public enum SubmissionEnrollmentStates
    {
        [EnumSerializedValue("active")] Active,
        [EnumSerializedValue("concluded")] Concluded
    }
}
