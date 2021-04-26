using CanvasApi.Client.Admins.Enums;
using CanvasApi.Client.Roles.Models;
using CanvasApi.Client.Roles.Models.Concrete;
using CanvasApi.Client.Users.Models;
using CanvasApi.Client.Users.Models.Concrete;
using Newtonsoft.Json;

namespace CanvasApi.Client.Admins.Models
{
    internal class Admin : IAdmin
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("role")] public Role Role { get; set; }
        IRole IAdmin.Role => Role;

        [JsonProperty("user")] public User User { get; set; }
        IUser IAdmin.User => User;

        [JsonProperty("workflow_state")] public AdminListWorkflowState WorkflowState { get; set; }
    }
}
