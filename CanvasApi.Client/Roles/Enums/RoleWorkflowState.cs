using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Enums
{
    [EnumAsString]
    public enum RoleWorkflowState
    {
        [EnumSerializedValue("active")] Active,
        [EnumSerializedValue("inactive")] Inactive,
        [EnumSerializedValue("built_in")] BuiltIn
    }
}
