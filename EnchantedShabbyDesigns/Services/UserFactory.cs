using Esd.Domain;
using Esd.Models;

namespace Esd.Services;

public sealed class UserFactory : IUserFactory
{
    public User Create(UserModel model, Auth auth)
    {
        return new()
        {
            Name = new Name(model.FirstName, model.LastName),
            Email = new Email(model.Email),
            Auth = auth
        };
    }
}
