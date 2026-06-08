namespace CanvasApi.Client.Users.Models;

internal class UserDisplay : IUserDisplay
{
    public long Id { get; set; }
    public string ShortName { get; set; }
    public string AvatarImageUrl { get; set; }
    public string HtmlUrl { get; set; }
}