using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore;

namespace Esd.Domain;

[Index(nameof(Id), IsUnique = true)]
public record Entity
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; }
}
