namespace CanvasApi.Client.AssignmentGroups.Enums;

[Multipart(EnumAsString = true)]
public enum SubmissionTypes
{
    OnlineQuiz,
    DiscussionTopic,
    WikiPage,
    ExternalTool
}