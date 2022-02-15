using System.Linq.Expressions;
using Esd.Domain;
using Esd.Models;

namespace Esd.Database;

public static class UserExpression
{
#pragma warning disable 8602
    public static Expression<Func<User, long>> AuthId => user => user.Auth.Id;

    public static Expression<Func<User, UserModel>> Model => user => new(user.Id, user.Name.FirstName, user.Name.LastName, user.Email.Value);
#pragma warning restore 8602

    public static Expression<Func<User, bool>> Id(long id)
    {
        return user => user.Id == id;
    }
}
