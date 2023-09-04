using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("TEACHER")]
class Teacher : Person
{
    [Required]
    public string Pin { get; set; } = string.Empty;
}