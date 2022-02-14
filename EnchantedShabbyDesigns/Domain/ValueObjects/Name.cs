using System.ComponentModel.DataAnnotations;

namespace Esd.Domain;

public sealed record Name(string FirstName, string LastName)
{
    [MaxLength(20)]
    public string FirstName { get; set; } = FirstName;
    [MaxLength(20)]
    public string LastName { get; set; } = LastName;
}
