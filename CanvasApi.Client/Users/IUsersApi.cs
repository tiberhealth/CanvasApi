namespace CanvasApi.Client.Users;

public interface IUsersApi
{
    Task<IUser> Get(long userId);

    Task<IUserProfile> GetProfile(long userId);
}