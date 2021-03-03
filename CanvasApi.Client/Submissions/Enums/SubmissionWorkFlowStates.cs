using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Submissions.Enums
{
    [Multipart(EnumAsString = true)]
    public enum SubmissionWorkFlowStates
    {
        [EnumSerializedValue("submitted")] Submitted,
        [EnumSerializedValue("unsubmitted")]  Unsubmitted,
        [EnumSerializedValue("graded")] Graded,
        [EnumSerializedValue("pending_review")] PendingReview
    }
}
