using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("TEACHER")]
class Teacher : Person
{
    [Required]
    public required string Pin { get; set; }
}