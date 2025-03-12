namespace CanvasApi.Client.Users.Models;

public class AnonumousUserDisplay : IAnonumousUserDisplay
{
    public string AnonymouusId { get; set; }
    public string AvatarImageUrl { get; set; }
}