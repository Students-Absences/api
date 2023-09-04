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
    public string FirstName { get; set; } = string.Empty;

    [Column("LASTNAME")]
    [Required]
    public string LastName { get; set; } = string.Empty;
}