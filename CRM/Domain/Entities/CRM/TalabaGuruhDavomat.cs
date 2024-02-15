

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.CRM;

public class TalabaGuruhDavomat : BaseEntity
{
    [Required]
    public int TalabaId { get; set; }
    [ForeignKey("TalabaId")]
    public Talaba? Talaba { get; set; }
    [Required]
    public int GuruhId { get; set; }
    [ForeignKey("GuruhId")]
    public Guruh? Guruh { get; set; }
    public DateTime Qachon {  get; set; }
    public bool KeldiKemadi { get; set; } = true;
}
