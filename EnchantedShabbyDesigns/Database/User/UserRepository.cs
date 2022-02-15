using Esd.Database.Repository;
using Esd.Domain;
using Esd.Models;
using Microsoft.EntityFrameworkCore;

namespace Esd.Database;

public sealed class UserRepository : EFRepository<User>, IUserRepository
{
    public UserRepository(Context context) : base(context) { }

    public Task<long> GetAuthIdByUserIdAsync(long id)
    {
        return Queryable.Where(UserExpression.Id(id)).Select(UserExpression.AuthId).SingleOrDefaultAsync();
    }

    public Task<UserModel> GetModelAsync(long id)
    {
#pragma warning disable 8619
        return Queryable.Where(UserExpression.Id(id)).Select(UserExpression.Model).SingleOrDefaultAsync();
#pragma warning restore 8619
    }

    public async Task<IEnumerable<UserModel>> ListModelAsync()
    {
        return await Queryable.Select(UserExpression.Model).ToListAsync();
    }

    public Task UpdateStatusAsync(User user)
    {
        return UpdatePartialAsync(new { user.Id, user.Status });
    }
}
