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
    public required int StudentId { get; set; }

    [Required]
    [Column("CLASSROOMID")]
    public required int ClassroomId { get; set; }
}