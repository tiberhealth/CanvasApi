namespace CanvasApi.Client.Roles.Models;

class RoleListResult
{
    public IEnumerable<Role> Roles { get; set; }
    public static IEnumerable<Role> ToArray(RoleListResult apiResult) => apiResult.Roles.ToArray();
}