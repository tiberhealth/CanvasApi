using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Enums
{
    [EnumAsString]
    public enum SubmissionTypes
    {
        [EnumSerializedValue("online_text_entry")] OnlineTextEntry,
        [EnumSerializedValue("online_url")] OnlineUrl,
        [EnumSerializedValue("online_upload")] OnlineUpload,
        [EnumSerializedValue("media_recording")] MediaRecording,
        [EnumSerializedValue("basic_lti_launch")] BasicLtiLaunch
    }
}
