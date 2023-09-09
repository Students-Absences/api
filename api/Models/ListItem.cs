using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

class ListItem
{
    [Key]
    [Column("ID")]
    public required int Id { get; set; }

    [Column("LABEL")]
    [Required]
    public required string Label { get; set; }

    [Column("LABELEN")]
    [Required]
    public required string LabelEn { get; set; }
}