using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Enums
{
    [Multipart(EnumAsString = true)]
    public enum ModuleTypes
    {
        [EnumSerializedValue("file")] File,
        [EnumSerializedValue("page")] Page,
        [EnumSerializedValue("discussion")] Discussion,
        [EnumSerializedValue("assignment")] Assignment,
        [EnumSerializedValue("quiz")] Quiz,
        [EnumSerializedValue("subheader")] SubHeader,
        [EnumSerializedValue("externalurl")] ExternalUrl,
        [EnumSerializedValue("externaltool")] ExternalTool
    }
}
