using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.CRM;

public class TeacherFan : BaseEntity
{
    [Required]
    public int FanId { get; set; }
    [Required]
    public int TeacherId { get; set; }
    [ForeignKey("TeacherId")]
    public Teacher? Teacher { get; set; }
    [ForeignKey("FanId")]
    public Fan? Fan { get; set; }
}
