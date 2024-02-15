using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.CRM;

public class BaseEntity
{
    [Key,Required]
    public int  Id { get; set; }
}
