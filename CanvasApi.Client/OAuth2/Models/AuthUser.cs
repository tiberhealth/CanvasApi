namespace CanvasApi.Client.OAuth2.Models;

public interface IAuthUser
{
    long Id { get; }
    string Name { get; }
}
    
internal class AuthUser: IAuthUser
{
    public long Id { get; set; }
    public string Name { get; set; }
}