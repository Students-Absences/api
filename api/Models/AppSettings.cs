using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api.Models;

[Table("APPSETTINGS")]
[PrimaryKey("SchoolName", "SchoolLogoUrl")]
class AppSettings
{
    [Column("SCHOOLNAME")]
    [Required]
    public required string SchoolName { get; set; }

    [Column("SCHOOLLOGOURL")]
    [Required]
    public required string SchoolLogoUrl { get; set; }
}