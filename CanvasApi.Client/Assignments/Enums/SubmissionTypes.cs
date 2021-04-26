using CanvasApi.Client.Assignments.Enums;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Assignments.Enums
{
    [EnumAsString]
    public enum SubmissionTypes
    {
        [EnumSerializedValue("discussion_topic")] DiscussionTopic,
        [EnumSerializedValue("online_quiz")] OnlineQuiz,
        [EnumSerializedValue("on_paper")] OnPaper,
        [EnumSerializedValue("none")] None,
        [EnumSerializedValue("external_tool")] ExternalTool,
        [EnumSerializedValue("online_text_entry")] OnlineTextEntry,
        [EnumSerializedValue("online_url")] OnlineUrl,
        [EnumSerializedValue("online_upload")] OnlineUpload,
        [EnumSerializedValue("media_recording")] MediaRecording
    }
}
