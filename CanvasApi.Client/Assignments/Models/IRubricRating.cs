namespace CanvasApi.Client.Assignments.Models
{
    public interface IRubricRating
    {
        decimal? Points { get; }
        string Id { get; }
        string Description { get; }
        string LongDescription { get; }
    }
}
