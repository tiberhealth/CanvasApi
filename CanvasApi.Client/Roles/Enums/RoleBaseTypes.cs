﻿using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Enums
{
    [Multipart(EnumAsString = true)]
    public enum RoleBaseTypes
    {
        [EnumSerializedValue("AccountMembership")] AccountMembership,
        [EnumSerializedValue("StudentEnrollment")] StudentEnrollment,
        [EnumSerializedValue("TeacherEnrollment")] TeacherEnrollment,
        [EnumSerializedValue("TaEnrollment")] TaEnrollment,
        [EnumSerializedValue("ObserverEnrollment")] ObserverEnrollment,
        [EnumSerializedValue("DesignerEnrollment")] DesignerEnrollment
    }
}