namespace CanvasApi.Client.OAuth2.Models
{
    public interface IWebSessionResponse
    {
        string SessionUrl { get; }    
    }
    
    internal class WebSessionResponse: IWebSessionResponse
    {
        public string SessionUrl { get; set; }
    }
}
