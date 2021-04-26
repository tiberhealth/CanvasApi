using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.AssignmentGroups.Enums
{
    [Multipart(EnumAsString = true)]
    public enum SubmissionTypes
    {
        [EnumSerializedValue("online_quiz")] OnlineQuiz,
        [EnumSerializedValue("discussion_topic")] DiscussionTopic,
        [EnumSerializedValue("wiki_page")] WikiPage,
        [EnumSerializedValue("external_tool")] ExternalTool
    }
}

