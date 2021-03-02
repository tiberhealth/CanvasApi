using CanvasApi.Client.Assignments.Enums;

namespace CanvasApi.Client.Assignments.Enums
{
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


internal static class FreezableAttributesHelpers
{
    public static FreezableAttributes? ToFreezableAttribute(this string value) =>
        value?.ToLower().Trim() switch
        {
            "title" => FreezableAttributes.Title,
            "description" => FreezableAttributes.Description,
            "lock_at" => FreezableAttributes.LockAt,
            "points_possible" => FreezableAttributes.PointsPossible,
            "grading_type" => FreezableAttributes.GradingType,
            "submission_types" => FreezableAttributes.SubmissionTypes,
            "assignment_group_id" => FreezableAttributes.AssignmentGroupId,
            "allowed_extensions" => FreezableAttributes.AllowedExtensions,
            "group_category_id" => FreezableAttributes.GroupCategoryId,
            "notify_of_update" => FreezableAttributes.NotifyOfUpdate,
            "peer_reviews" => FreezableAttributes.PeerReviews,
            _ => null
        };
}
