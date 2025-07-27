// ReSharper disable InconsistentNaming
namespace CanvasApi.Client.Roles.Enums;

[EnumAsString]
public enum RoleWorkflowState
{
    Active,
    Inactive,

    [EnumMember(Value = "built_in")]
    Built_In
}
