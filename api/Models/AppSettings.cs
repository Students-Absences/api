using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api.Models;

[Table("APPSETTINGS")]
[Keyless]
class AppSettings
{
    [Column("SCHOOLNAME")]
    public string SchoolName { get; set; } = string.Empty;

    [Column("SCHOOLLOGOURL")]
    public string SchoolLogoUrl { get; set; } = string.Empty;
}