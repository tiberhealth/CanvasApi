using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Enrollments.Enums
{
    [EnumAsString]
    public enum EnrollmentTypes
    {
        [EnumSerializedValue("TeacherEnrollment")] Teacher,
        [EnumSerializedValue("StudentEnrollment")] Student,
        [EnumSerializedValue("TaEnrollment")] TeacherAssistant,
        [EnumSerializedValue("ObserverEnrollment")] Observer,
        [EnumSerializedValue("DesignerEnrollment")] Designer
    }
}

