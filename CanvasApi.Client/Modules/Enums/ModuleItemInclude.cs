using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Enums
{
    [Multipart(EnumAsString = true)]
    public enum ModuleItemInclude
    {
        [EnumSerializedValue("content_details")] ContentDetails
    }
}
