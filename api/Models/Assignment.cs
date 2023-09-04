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

    [ForeignKey("ClassroomId")]
    public Classroom? Classroom { get; set; }

    [Required]
    [Column("SUBJECTID")]
    public int SubjectId { get; set; }

    [ForeignKey("SubjectId")]
    public Subject? Subject { get; set; }

    [Required]
    [Column("TEACHERID")]
    public int TeacherId { get; set; }

    [ForeignKey("TeacherId")]
    public Teacher? Teacher { get; set; }
}