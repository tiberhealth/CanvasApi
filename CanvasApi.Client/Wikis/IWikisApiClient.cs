namespace CanvasApi.Client.Wikis;

public interface IWikisApiClient
{
    Task<IPage> Get(long courseId, string pageUrlOrId);
}
