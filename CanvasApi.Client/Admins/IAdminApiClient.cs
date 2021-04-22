using CanvasApi.Client.Admins.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CanvasApi.Client.Admins
{
    public interface IAdminApiClient
    {
        Task<IEnumerable<IAdmin>> List(long accountId, Action<IAdminList> body);
        Task<IAdmin> Make(long accountId, Action<IAdminMake> admin);
        Task<IAdmin> Remove(long accountId, long userId, Action<IAdminRemove> options = null);
    }
}