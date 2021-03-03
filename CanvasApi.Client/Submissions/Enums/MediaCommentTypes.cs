using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Enums
{
    [Multipart(EnumAsString = true)]
    public enum MediaCommentTypes
    {
        [EnumSerializedValue("audio")] Audio,
        [EnumSerializedValue("video")] Video
    }
}
