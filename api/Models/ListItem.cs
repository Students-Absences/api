using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

class ListItem
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("LABEL")]
    [Required]
    public string Label { get; set; } = string.Empty;

    [Column("LABELEN")]
    [Required]
    public string LabelEn { get; set; } = string.Empty;
}