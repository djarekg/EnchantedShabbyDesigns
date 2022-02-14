using DotNetCore.Results;
using Esd.Domain;
using Esd.Models;

namespace Esd.Services;

public interface IAuthService
{
    Task<IResult<Auth>> AddAsync(AuthModel model);

    Task DeleteAsync(long id);

    Task<IResult<TokenModel>> SignInAsync(SignInModel model);
}
