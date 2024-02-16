using Application.DTOs.XonaDtos;

namespace Application.Interfaces;

public interface IXonaService
{
    Task AddXonaAsync(AddXonaDto dto);
    Task<List<XonaDto>> GetAllAsync();
    Task<XonaDto> GetByIdAsync(int id);
    Task UpdateAsync(UpdateXonaDto dto);
    Task DeleteAsync(int id);
}
