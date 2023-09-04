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
    public string SchoolName { get; set; } = string.Empty;

    [Column("SCHOOLLOGOURL")]
    [Required]
    public string SchoolLogoUrl { get; set; } = string.Empty;
}