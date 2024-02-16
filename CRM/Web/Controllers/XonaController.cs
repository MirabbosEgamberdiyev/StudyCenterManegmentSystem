using Application.Common.Exceptions;
using Application.DTOs.XonaDtos;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class XonaController(IXonaService xonaService) : ControllerBase
{
    private readonly IXonaService _xonaService = xonaService;

    [HttpPost("create-class-room")]
    public async Task<IActionResult> AddXonaAsync(AddXonaDto dto)
    {
        try
        {
            await _xonaService.AddXonaAsync(dto);
            return Ok("Xona muvaffaqiyatli qo'shildi");
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception)
        {
            return StatusCode(500, "Serverdagi xatolik");
        }
    }

    [HttpDelete("delete-class-room/{id}")]
    public async Task<IActionResult> DeleteXonaAsync(int id)
    {
        try
        {
            await _xonaService.DeleteAsync(id);
            return Ok("Xona muvaffaqiyatli o'chirildi");
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception)
        {
            return StatusCode(500, "Serverdagi xatolik");
        }
    }

    [HttpGet("get-all-class-rooms")]
    public async Task<IActionResult> GetAllXonalarAsync()
    {
        try
        {
            var xonalar = await _xonaService.GetAllAsync();
            return Ok(xonalar);
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception)
        {
            return StatusCode(500, "Serverdagi xatolik");
        }
    }

    [HttpGet("get-class-room/{id}")]
    public async Task<IActionResult> GetXonaByIdAsync(int id)
    {
        try
        {
            var xona = await _xonaService.GetByIdAsync(id);
            return Ok(xona);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception)
        {
            return StatusCode(500, "Serverdagi xatolik");
        }
    }

    [HttpPut("update-class-room")]
    public async Task<IActionResult> UpdateXonaAsync(UpdateXonaDto dto)
    {
        try
        {
            await _xonaService.UpdateAsync(dto);
            return Ok("Xona muvaffaqiyatli yangilandi");
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception)
        {
            return StatusCode(500, "Serverdagi xatolik");
        }
    }

}

