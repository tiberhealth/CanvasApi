using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Courses.Enums
{
    public enum CourseState
    {
        [EnumSerializedValue("unpublished")] Unpublished,
        [EnumSerializedValue("available")] Available,
        [EnumSerializedValue("completed")] Completed,
        [EnumSerializedValue("deleted")] Deleted
    }
}
