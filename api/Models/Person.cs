using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

class Person
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FIRSTNAME")]
    [Required]
    public required string FirstName { get; set; }

    [Column("LASTNAME")]
    [Required]
    public required string LastName { get; set; }
}