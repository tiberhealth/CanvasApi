using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Enrollments.Enums
{
    public enum EnrollmentTypes
    {
        [EnumSerializedValue("teacher")] Teacher,
        [EnumSerializedValue("student")] Student,
        [EnumSerializedValue("ta")] TeacherAssistant,
        [EnumSerializedValue("observer")] Observer,
        [EnumSerializedValue("designer")] Designer
    }
}

