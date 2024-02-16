using Domain.Entities.CRM;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Identity;

public class ApplicationUser : IdentityUser
{
    [Required, StringLength(100)]
    public string FirstName { get; set; } = string.Empty;
    [Required, StringLength(100)]
    public string LastName { get; set; } = string.Empty;
}