using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.CRM;

public class Xona : BaseEntity
{
    [Required, StringLength(100)]
    public string XonaName { get; set; } = string.Empty;
    public int Qavat {  get; set; }
    [Required]
    public int Sigimi { get; set; }
}
