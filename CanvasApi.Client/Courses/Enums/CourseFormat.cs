using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Courses.Enums
{
    public enum CourseFormat
    {
        [EnumSerializedValue("on_campus")] OnCampus,
        [EnumSerializedValue("online")] Online,
        [EnumSerializedValue("blended")] Blended
    }
}
