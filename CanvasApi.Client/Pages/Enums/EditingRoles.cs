using System;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Pages.Enums
{
    public enum EditingRoles
    {
        [EnumSerializedValue("teachers")] Teachers,
        [EnumSerializedValue("students")] Students,
        [EnumSerializedValue("members")] Members,
        [EnumSerializedValue("public")] Public
    }
}
