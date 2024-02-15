using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.CRM;

public class Guruh : BaseEntity
{
    [Required, StringLength(100)]
    public string GuruhName { get; set; } = string.Empty;
    [Required]
    public int FanId { get; set; }
    [Required]
    public int TeacherId { get; set; }
    [Required]
    public int XonaId { get; set; }
    public List<int>? HaftaKunlari {  get; set; } 
    public DateTime Start {  get; set; } 
    public DateTime End { get; set; }
    [Required]
    public decimal Narxi { get; set; }
    [Required, StringLength(100)]
    public string? Davomiyligi { get; set; }
    public List<TalabaGuruh>? TalabaGuruhs { get; set; }
    public List<TalabaGuruhDavomat>? TalabaDavomats { get; set; }
}
