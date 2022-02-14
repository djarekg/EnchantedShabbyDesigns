using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esd.Models;

public sealed record UserModel(long Id, string FirstName, string LastName, string Email)
{
    public readonly long Id = Id;
    public readonly string FirstName = FirstName;
    public readonly string LastName = LastName;
    public readonly string Email = Email;
    public AuthModel Auth { get; init; } = default!;
}