using Esd.Database.Repository;
using Esd.Domain;
using Esd.Models;

namespace Esd.Database;

public interface IUserRepository : IRepository<User>
{
    Task<long> GetAuthIdByUserIdAsync(long id);

    Task<UserModel> GetModelAsync(long id);

    Task<IEnumerable<UserModel>> ListModelAsync();

    Task UpdateStatusAsync(User user);
}
