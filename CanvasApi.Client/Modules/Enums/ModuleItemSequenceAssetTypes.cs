using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Enums
{
    [EnumAsString]
    public enum ModuleItemSequenceAssetTypes
    {
        ModuleItem,
        File,
        Page,
        Discussion,
        Assignment,
        Quiz,
        ExternalTool
    }
}
