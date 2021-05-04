using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.AssignmentGroups.Enums
{
    [EnumAsString]
    public enum AssignmentGroupGetIncludes
    {
        Assignments,
        DiscussionTopic,
        AssignmentVisibility,
        Submission,
        ScoreStatistics
    }
}
