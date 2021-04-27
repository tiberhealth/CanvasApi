using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Enums
{
    [EnumAsString]
    public enum ModuleItemSequenceAssetTypes
    {
        [EnumSerializedValue("ModuleItem")] ModuleItem,
        [EnumSerializedValue("File")] File,
        [EnumSerializedValue("Page")] Page,
        [EnumSerializedValue("Discussion")] Discussion,
        [EnumSerializedValue("Assignment")] Assignment,
        [EnumSerializedValue("Quiz")] Quiz,
        [EnumSerializedValue("ExternalTool")] ExternalTool
    }
}
