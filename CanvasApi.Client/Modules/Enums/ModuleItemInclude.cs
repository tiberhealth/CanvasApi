using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    [Multipart(EnumAsString = true)]
    public enum ModuleItemInclude
    {
        [EnumSerializedValue("items")] Items,
        [EnumSerializedValue("content_details")] ContentDetails
    }
}
