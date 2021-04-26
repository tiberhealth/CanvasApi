using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.EnrollmentTerms.Enums
{
    [Multipart(EnumAsString = true)]
    public enum EnrollmentTermListWorkflowState
    {
        [EnumSerializedValue("active")] Active,
        [EnumSerializedValue("deleted")] Deleted,
        [EnumSerializedValue("all")] All
    }
}
