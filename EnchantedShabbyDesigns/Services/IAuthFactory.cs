using Esd.Domain;
using Esd.Models;

namespace Esd.Services;

public interface IAuthFactory
{
    Auth Create(AuthModel model);
}