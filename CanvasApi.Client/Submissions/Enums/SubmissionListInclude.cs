using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Enums
{
    [Multipart(EnumAsString = true)]
    public enum SubmissionListInclude
    {
        [EnumSerializedValue("submission_history")] SubmissionHistory,
        [EnumSerializedValue("submission_comments")] SubmissionComments,
        [EnumSerializedValue("rubric_assessment")] RubricAssignment,
        [EnumSerializedValue("assignment")] Assignment,
        [EnumSerializedValue("visibility")] Visibility,
        [EnumSerializedValue("course")] Course,
        [EnumSerializedValue("user")] User,
        [EnumSerializedValue("group")] Group,
        [EnumSerializedValue("total_scores")] TotalScores
    }
}
