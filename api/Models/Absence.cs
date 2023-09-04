using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("ABSENCE")]
class Absence
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("HOUR")]
    public int Hour { get; set; }

    [Required]
    [Column("DAY")]
    public int Day { get; set; }

    [Required]
    [Column("MONTH")]
    public int Month { get; set; }

    [Required]
    [Column("YEAR")]
    public int Year { get; set;}

    [Required]
    [Column("ASSIGNMENTID")]
    public int AssignmentId { get; set; }

    [Required]
    [Column("STUDENTID")]
    public int StudentId { get; set;}
}