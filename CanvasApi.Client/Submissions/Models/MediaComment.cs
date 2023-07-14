namespace CanvasApi.Client.Submissions.Models
{
    internal class MediaComment : IMediaComment
    {
        public string ContentType { get; set; }
        public string DisplayName { get; set; }
        public string MediaId { get; set; }
        public string MediaType { get; set; }
        public string Url { get; set; }
    }
}
