using DotNetCore.EntityFrameworkCore;
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

    public Task<Auth> GetByLoginAsync(string login) => Queryable.SingleOrDefaultAsync(AuthExpression.Login(login));
}