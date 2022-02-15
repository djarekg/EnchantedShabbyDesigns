using Esd.Database.Repository;
using Esd.Domain;
using Esd.Repository;
using Microsoft.EntityFrameworkCore;

namespace Esd.Database;

public sealed class AuthRepository : EFRepository<Auth>, IAuthRepository
{
    public AuthRepository(Context context) : base(context) { }

    public Task<bool> AnyByLoginAsync(string login)
    {
        return Queryable.AnyAsync(AuthExpression.Login(login));
    }

#pragma warning disable 8619
    public Task<Auth> GetByLoginAsync(string login) => Queryable.SingleOrDefaultAsync(AuthExpression.Login(login));
#pragma warning restore 8619
}