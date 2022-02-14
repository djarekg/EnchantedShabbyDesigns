using FluentValidation;

namespace Esd.Models;

public sealed class SignInModelValidator : AbstractValidator<SignInModel>
{
    public SignInModelValidator()
    {
        RuleFor(signIn => signIn.Login).NotEmpty();
        RuleFor(signIn => signIn.Password).NotEmpty();
    }
}