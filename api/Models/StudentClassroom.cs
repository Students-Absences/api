using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api.Models;

[Table("STUDENTCLASSROOM")]
[PrimaryKey("StudentId", "ClassroomId")]
class StudentClassroom
{
    [Required]
    [Column("STUDENTID")]
    public int StudentId { get; set; }

    [ForeignKey("StudentId")]
    public Student? Student { get; set; }

    [Required]
    [Column("CLASSROOMID")]
    public int ClassroomId { get; set; }

    [ForeignKey("ClassroomId")]
    public Classroom? Classroom { get; set; }
}