using CanvasApi.Client.Assignments.Enums;

namespace CanvasApi.Client.Assignments.Enums
{
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

internal static class SubmissionTypesHelper
{
    public static SubmissionTypes? ToSubmissionType(this string value) =>
        value?.ToLower().Trim() switch
        {
            "discussion_topic" => SubmissionTypes.DiscussionTopic,
            "online_quiz" => SubmissionTypes.OnlineQuiz,
            "on_paper" => SubmissionTypes.OnPaper,
            "none" => SubmissionTypes.None,
            "external_tool" => SubmissionTypes.ExternalTool,
            "online_text_entry" => SubmissionTypes.OnlineTextEntry,
            "online_url" => SubmissionTypes.OnlineUrl,
            "online_upload" => SubmissionTypes.OnlineUpload,
            "media_recording" => SubmissionTypes.MediaRecording,
            _ => null
        };
}