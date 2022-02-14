using Esd.Domain;
using Esd.Models;

namespace Esd.Services;

public interface IUserFactory
{
    User Create(UserModel model, Auth auth);
}
