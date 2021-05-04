using CanvasApi.Client.Assignments.Enums;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Assignments.Enums
{
    [EnumAsString]
    public enum SubmissionTypes
    {
        DiscussionTopic,
        OnlineQuiz,
        OnPaper,
        None,
        ExternalTool,
        OnlineTextEntry,
        OnlineUrl,
        OnlineUpload,
        MediaRecording
    }
}
