using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("ASSIGNMENT")]
class Assignment
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("CLASSROOMID")]
    public int ClassroomId { get; set; }

    [Required]
    [Column("SUBJECTID")]
    public required int SubjectId { get; set; }

    [Required]
    [Column("TEACHERID")]
    public required int TeacherId { get; set; }
}