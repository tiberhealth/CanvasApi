using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Enums
{
    [EnumAsString]
    public enum ModuleWorkflowState
    {
        MustView,
        MustSubmit,
        MustContribute,
        MustMarkDone
    }
}
