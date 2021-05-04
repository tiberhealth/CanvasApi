using CanvasApi.Client.Assignments.Enums;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Assignments.Enums
{
    [EnumAsString]
    public enum FreezableAttributes
    {
        Title,
        Description,
        LockAt,
        PointsPossible,
        GradingType,
        SubmissionTypes,
        AssignmentGroupId,
        AllowedExtensions,
        GroupCategoryId,
        NotifyOfUpdate,
        PeerReviews
    }
}
