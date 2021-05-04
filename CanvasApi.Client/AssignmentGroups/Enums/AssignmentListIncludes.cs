using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.AssignmentGroups.Enums
{
    [EnumAsString]
    public enum AssignmentListIncludes
    {
        Assignments,
        DiscussionTopic,
        AllDates,
        AssignmentVisibility,
        Overrides,
        Submission,
        ObservedUsers,
        CanEdit,
        ScoreStatistics
    }

}

