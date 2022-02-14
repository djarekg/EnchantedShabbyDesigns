using Esd.Models;

public sealed class UpdateUserModelValidator : UserModelValidator
{
    public UpdateUserModelValidator()
    {
        Id(); FirstName(); LastName(); Email();
    }
}
