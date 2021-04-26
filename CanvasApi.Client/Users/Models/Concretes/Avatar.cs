namespace CanvasApi.Client.Users.Models.Concretes
{
    internal class Avatar : IAvatar
    {
        public string Type { get; set; }
        public string Url { get; set; }
        public string Token { get; set; }
        public string DisplayName { get; set; }
        public long Id { get; set; }
        public string ContentType { get; set; }
        public string Filename { get; set; }
        public long Size { get; set; }
    }
}
