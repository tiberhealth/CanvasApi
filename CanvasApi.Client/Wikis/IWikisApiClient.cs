using System.Threading.Tasks;
using CanvasApi.Client.Pages.Models;

namespace CanvasApi.Client.Wikis;

public interface IWikisApiClient
{
    Task<IPage> Get(long courseId, string pageUrlOrId);
}
