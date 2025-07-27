namespace CanvasApi.Client.Admins.Models;

internal class Admin : IAdmin
{
    public long Id { get; set; }

    public string Role { get; set; }

    public User User { get; set; }
    IUser IAdmin.User => this.User;

    public AdminListWorkflowState WorkflowState { get; set; }
}