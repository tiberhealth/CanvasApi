using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Enums
{
    [EnumAsString]
    public enum SubmissionWorkFlowStates
    {
        [EnumSerializedValue("submitted")] Submitted,
        [EnumSerializedValue("unsubmitted")]  Unsubmitted,
        [EnumSerializedValue("graded")] Graded,
        [EnumSerializedValue("pending_review")] PendingReview
    }
}
