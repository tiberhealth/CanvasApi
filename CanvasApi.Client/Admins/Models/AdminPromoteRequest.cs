namespace CanvasApi.Client.Admins.Models;

internal class AdminPromoteRequest : IAdminPromoteRequest
{
    public int UserId { get; set; }
    public string Role { get; set; }
    public int? RoleId { get; set; }
    public bool? SendConfirmation { get; set; }
}