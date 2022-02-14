using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Esd.Domain;

public sealed record Auth(string Login, string Password, Roles Roles) : Entity
{
    [Required]
    [MaxLength(100)]
    public string Login { get; private set; } = Login;
    [Required]
    [MaxLength(1000)]
    public string Password { get; private set; } = Password;
    [Required]
    [MaxLength(1000)]
    public string Salt { get; private set; } = Guid.NewGuid().ToString();
    [Required]
    [DefaultValue(Roles.None)]
    public Roles Roles { get; private set; } = Roles;

    public void UpdatePassword(string password)
    {
        Password = password;
    }
}

// public class Auth : Entity<long>
// {
//     public Auth(string login, string password, Roles roles)
//     {
//         Login = login;
//         Password = password;
//         Roles = roles;
//         Salt = Guid.NewGuid().ToString();
//     }

//     public string Login { get; private set; }
//     public string Password { get; private set; }
//     public string Salt { get; private set; }
//     public Roles Roles { get; private set; }

//     public void UpdatePassword(string password)
//     {
//         Password = password;
//     }
// }