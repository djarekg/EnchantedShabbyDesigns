using System.Linq.Expressions;
using Esd.Domain;

namespace Esd.Repository;

public static class AuthExpression
{
    public static Expression<Func<Auth, bool>> Login(string login)
    {
        return auth => auth.Login == login;
    }
}
