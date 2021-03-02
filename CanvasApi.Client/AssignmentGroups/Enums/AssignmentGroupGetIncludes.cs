using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.AssignmentGroups.Enums
{
    [Multipart(EnumAsString = true)]
    public enum AssignmentGroupGetIncludes
    {
        [EnumSerializedValue("assignments")] Assignments,
        [EnumSerializedValue("discussion_topic")] DiscussionTopic,
        [EnumSerializedValue("assignment_visibility")] AssignmentVisibility,
        [EnumSerializedValue("submission")] Submission,
        [EnumSerializedValue("score_statistics")] ScoreStatistics
    }
}
