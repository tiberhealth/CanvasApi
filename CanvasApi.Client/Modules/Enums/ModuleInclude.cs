using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Enums
{
    [EnumAsString]
    public enum ModuleInclude
    {
        [EnumSerializedValue("items")] Items,
        [EnumSerializedValue("content_details")] ContentDetails
    }
}
