using DotNetCore.Repositories;
using Esd.Domain;

namespace Esd.Database;

public interface IAuthRepository : IRepository<Auth>
{
    Task<bool> AnyByLoginAsync(string login);

    Task<Auth> GetByLoginAsync(string login);
}