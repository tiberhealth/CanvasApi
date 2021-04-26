using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Courses.Enums
{
    public enum ViewType
    {
        /// <summary>
        /// Recent Activity Dashboard
        /// </summary>
        [EnumSerializedValue("feed")] Feed,

        /// <summary>
        /// Wiki Page
        /// </summary>
        [EnumSerializedValue("wiki")] Wiki,

        /// <summary>
        /// Course Modules/Sections Page
        /// </summary>
        [EnumSerializedValue("modules")] Modules,

        /// <summary>
        /// Course Syllabus Page
        /// </summary>
        [EnumSerializedValue("syllabus")] Syllabus,

        /// <summary>
        /// Course Assignments List
        /// </summary>
        [EnumSerializedValue("assignments")] Assignments
    }
}
