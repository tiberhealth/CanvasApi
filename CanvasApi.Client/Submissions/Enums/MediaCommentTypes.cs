using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Enums
{
    [EnumAsString]
    public enum MediaCommentTypes
    {
        [EnumSerializedValue("audio")] Audio,
        [EnumSerializedValue("video")] Video
    }
}
