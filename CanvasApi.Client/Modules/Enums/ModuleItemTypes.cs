using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Enums
{
    [EnumAsString]
    public enum ModuleItemTypes
    {
        [EnumSerializedValue("File")] File,
        [EnumSerializedValue("Page")] Page,
        [EnumSerializedValue("Discussion")] Discussion,
        [EnumSerializedValue("Assignment")] Assignment,
        [EnumSerializedValue("Quiz")] Quiz,
        [EnumSerializedValue("SubHeader")] SubHeader,
        [EnumSerializedValue("ExternalUrl")] ExternalUrl,
        [EnumSerializedValue("ExternalTool")] ExternalTool
    }
}
