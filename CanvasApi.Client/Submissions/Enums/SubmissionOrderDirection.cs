using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Enums
{
    [Multipart(EnumAsString = true)]
    public enum SubmissionOrderDirection
    {
        [EnumSerializedValue("ascending")] Ascending,
        [EnumSerializedValue("descending")] Descending
    }
}
