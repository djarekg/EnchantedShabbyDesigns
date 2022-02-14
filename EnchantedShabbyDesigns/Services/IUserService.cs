using DotNetCore.Objects;
using DotNetCore.Results;
using Esd.Models;

namespace Esd.Services;

public interface IUserService
{
    Task<IResult<long>> AddAsync(UserModel model);

    Task<DotNetCore.Results.IResult> DeleteAsync(long id);

    Task<UserModel> GetAsync(long id);

    Task<Grid<UserModel>> GridAsync(GridParameters parameters);

    Task<DotNetCore.Results.IResult> InactivateAsync(long id);

    Task<IEnumerable<UserModel>> ListAsync();

    Task<DotNetCore.Results.IResult> UpdateAsync(UserModel model);
}
