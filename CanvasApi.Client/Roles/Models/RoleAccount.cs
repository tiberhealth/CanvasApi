namespace CanvasApi.Client.Roles.Models
{
    internal class RoleAccount : IRoleAccount
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public long? ParentAccountId { get; set; }
        public long? RootAccountId { get; set; }
        public string SisAccountId { get; set; }

    }
}
