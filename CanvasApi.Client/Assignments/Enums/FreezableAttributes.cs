using CanvasApi.Client.Assignments.Enums;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Assignments.Enums
{
    [EnumAsString]
    public enum FreezableAttributes
    {
        [EnumSerializedValue("title")] Title,
        [EnumSerializedValue("description")] Description,
        [EnumSerializedValue("lock_at")] LockAt,
        [EnumSerializedValue("points_possible")] PointsPossible,
        [EnumSerializedValue("grading_type")] GradingType,
        [EnumSerializedValue("submission_types")] SubmissionTypes,
        [EnumSerializedValue("assignment_group_id")] AssignmentGroupId,
        [EnumSerializedValue("allowed_extensions")] AllowedExtensions,
        [EnumSerializedValue("group_category_id")] GroupCategoryId,
        [EnumSerializedValue("notify_of_update")] NotifyOfUpdate,
        [EnumSerializedValue("peer_reviews")] PeerReviews
    }
}
