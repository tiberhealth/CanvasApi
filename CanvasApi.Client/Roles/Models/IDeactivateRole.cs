namespace CanvasApi.Client.Roles.Models;

public interface IDeactivateRole
{
    /// <summary>
    /// The name for the role
    /// </summary>
    string Role { get; set; }
    /// <summary>
    /// The unique identifier for the role
    /// </summary>
    int RoleId { get; set; }
}