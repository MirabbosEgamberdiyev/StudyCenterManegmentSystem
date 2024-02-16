using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.XonaDtos;

public class UpdateXonaDto : BaseDto
{

    [Required(ErrorMessage = "Xona nomi bo'sh bo'lishi mumkin emas.")]
    [StringLength(100, ErrorMessage = "Xona nomi maksimal 100 belgidan iborat bo'lishi kerak.")]
    public string XonaName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Xona qavati bo'sh bo'lishi mumkin emas.")]
    public int Qavat { get; set; }

    [Required(ErrorMessage = "Xona sigimi bo'sh bo'lishi mumkin emas.")]
    public int Sigimi { get; set; }
}
