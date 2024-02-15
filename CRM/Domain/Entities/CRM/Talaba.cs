using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.CRM;

public class Talaba : BaseEntity
{
    [Required, StringLength(100)]
    public string FirstName { get; set; } = string.Empty;
    [Required, StringLength(100)]
    public string LastName { get; set; } = string.Empty;
    [Required, StringLength(100)]
    public string PhoneNumber { get; set; } = string.Empty;
    public List<TalabaGuruh>? TalabaGuruhs { get; set;}
    public List<TalabaTolov>? TalabaTolov { get; set; }
    public List<TalabaGuruhDavomat>? TalabaGuruhDavomats { get; set; }
}
