using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Admins.Enums
{
    [EnumAsString]
    public enum AdminListWorkflowState
    {
        [EnumSerializedValue("active")] Active,
        [EnumSerializedValue("deleted")] Deleted,
        [EnumSerializedValue("all")] All
    }
}
