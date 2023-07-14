namespace CanvasApi.Client.Admins.Models
{
    class AdminDemoteRequest : IAdminDemoteRequest
    {
        public string Role { get; set; }
        public int? RoleId { get; set; }
    }
}
