using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Enums
{
    [EnumAsString]
    public enum ModuleState
    {
        Locked,
        Unlocked,
        Started,
        Completed
    }
}
