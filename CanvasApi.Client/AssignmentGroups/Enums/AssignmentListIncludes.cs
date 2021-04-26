using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.AssignmentGroups.Enums
{
    [Multipart(EnumAsString = true)]
    public enum AssignmentListIncludes
    {
        [EnumSerializedValue("assignments")] Assignments,
        [EnumSerializedValue("discussion_topic")] DiscussionTopic,
        [EnumSerializedValue("all_dates")] AllDates,
        [EnumSerializedValue("assignment_visibility")] AssignmentVisibility,
        [EnumSerializedValue("overrides")] Overrides,
        [EnumSerializedValue("submission")] Submission,
        [EnumSerializedValue("observed_users")] ObservedUsers,
        [EnumSerializedValue("can_edit")] CanEdit,
        [EnumSerializedValue("score_statistics")] ScoreStatistics
    }

}

