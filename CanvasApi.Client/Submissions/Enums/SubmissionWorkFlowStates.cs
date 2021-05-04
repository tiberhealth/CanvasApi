using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Enums
{
    [EnumAsString]
    public enum SubmissionWorkFlowStates
    {
        Submitted,
         Unsubmitted,
        Graded,
        PendingReview
    }
}
