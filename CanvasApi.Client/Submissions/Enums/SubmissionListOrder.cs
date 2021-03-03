using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Enums
{
    [Multipart(EnumAsString = true)]
    public enum SubmissionListOrder
    {
        [EnumSerializedValue("id")] Id,
        [EnumSerializedValue("graded_at")] GradedAt
    }
}
