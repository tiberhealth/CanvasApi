namespace CanvasApi.Client.Roles.Models
{
    internal class GetSingleRoleOptions : IGetSingleRoleOptions
    {
        public int RoleId { get; set; }
        public string Role { get; set; }
        public long AccountId { get; set; }
    }
}
