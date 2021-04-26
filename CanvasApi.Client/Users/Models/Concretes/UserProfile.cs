namespace CanvasApi.Client.Users.Models.Concretes
{
    internal class UserProfile : IUserProfile
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string SortableName { get; set; }
        public string Title { get; set; }
        public string Bio { get; set; }
        public string PrimaryEmail { get; set; }
        public string LoginId { get; set; }
        public string SisUserId { get; set; }
        public string LtiUserId { get; set; }
        public string AvatarUrl { get; set; }
        public object Calendar { get; set; }
        public string TimeZone { get; set; }
        public string Locale { get; set; }
    }
}
