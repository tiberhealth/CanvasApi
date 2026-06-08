namespace CanvasApi.Client.Roles.Models;

internal class ListRolesOptions : IListRolesOptions
{
    public IEnumerable<RoleWorkflowState> State { get; set; }
    public bool? ShowInherited { get; set; }
    public long AccountId { get; set; }
}