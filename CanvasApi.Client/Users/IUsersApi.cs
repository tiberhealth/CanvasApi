using System.Threading.Tasks;
using CanvasApi.Client.Users.Models;

namespace CanvasApi.Client.Users
{
    public interface IUsersApi
    {
        Task<IUserProfile> GetProfile(long userId);
    }
}
