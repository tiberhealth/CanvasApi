namespace CanvasApi.Client.Submissions.Models
{
    public interface IMediaComment
    {
        string ContentType { get; }
        string DisplayName { get; }
        string MediaId { get; }
        string MediaType { get; }
        string Url { get; }
    }
}
