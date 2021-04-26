namespace CanvasApi.Client.OAuth2.Models
{
    public interface ILogoutResponse
    {
        string ForwardUrl { get; }   
    }
    
    internal class LogoutResponse: ILogoutResponse
    {
        public string ForwardUrl { get; set; }
    }
}