using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Enums
{
    [EnumAsString]
    public enum SubmissionListInclude
    {
        SubmissionHistory,
        SubmissionComments,
        RubricAssignment,
        Assignment,
        Visibility,
        Course,
        User,
        Group,
        TotalScores
    }
}
