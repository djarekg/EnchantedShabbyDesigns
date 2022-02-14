using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Esd.Domain;

[Table(nameof(User))]
public sealed record User : Entity
{
    [Required]
    public Name? Name { get; set; }
    [Required]
    [MaxLength(100)]
    public Email? Email { get; set; }
    [Required]
    public Status Status { get; set; }
    public Auth? Auth { get; set; }

    public void Activated()
    {
        Status = Status.Active;
    }

    public void Inactivate()
    {
        Status = Status.Inactive;
    }

    public void Update(string firstName, string lastName, string email)
    {
        Name = new Name(firstName, lastName);
        Email = new Email(email);
    }
}

// public class User : Entity<long>
// {
//     public User(Name name, Email email, Auth auth)
//     {
//         Name = name;
//         Email = email;
//         Auth = auth;
//         Activate();
//     }

//     public User(long id) => Id = id;

//     public Name Name { get; private set; }

//     public Email Email { get; private set; }

//     public Status Status { get; private set; }

//     public Auth Auth { get; private set; }

//     public void Activate()
//     {
//         Status = Status.Active;
//     }

//     public void Inactivate()
//     {
//         Status = Status.Inactive;
//     }

//     public void Update(string firstName, string lastName, string email)
//     {
//         Name = new Name(firstName, lastName);
//         Email = new Email(email);
//     }
// }