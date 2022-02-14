using Esd.Domain;
using Esd.Models;

namespace Esd.Services;

public sealed class AuthFactory : IAuthFactory
{
    public Auth Create(AuthModel model)
    {
        return new(model.Login, model.Password, (Roles)model.Roles);
    }
}