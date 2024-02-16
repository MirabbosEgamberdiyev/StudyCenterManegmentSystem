using Application.Common.Exceptions;
using Application.Common.Validators;
using Application.DTOs.XonaDtos;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities.CRM;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Application.Services;

public class XonaService(IUnitOfWork unitOfWork, IMapper mapper) : IXonaService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task AddXonaAsync(AddXonaDto dto)
    {
        if(dto is null)
        {
            throw new ArgumentNullException("Xona null");
        }
        var xona = _mapper.Map<Xona>(dto);
        var xonalar = await _unitOfWork.XonaInterface.GetAllAsync();


        if (xona is null)
        {
            throw new CustomException("Xonani map qilishda hatolik yuz berdi ");
        }
        if(xonalar is null)
        {
            throw new NotFoundException("Hech qanday xona topilmadi");
        }

        if (xona.IsExist(xonalar))
        {
            throw new CustomException("Xona oldin mavjud");
        }
        if (xona.IsValid())
        {
            throw new CustomException("Xona invalid");
        }

        await _unitOfWork.XonaInterface.AddAsync(xona);
        await _unitOfWork.SaveChangeAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var xona = await _unitOfWork.XonaInterface.GetByIdAsync(id);
        if(xona is null)
        {
            throw new NotFoundException("Xona topilmadi ");
        }
        await _unitOfWork.XonaInterface.DeleteAsync(id);
        await _unitOfWork.SaveChangeAsync();
    }


    public async Task<List<XonaDto>> GetAllAsync()
    {
        var xonalar = await _unitOfWork.XonaInterface.GetAllAsync();
        if(xonalar is null)
        {
            throw new CustomException("Xonalar topilmadi");
        }
        return await xonalar.Select(x => _mapper.Map<XonaDto>(x)).ToListAsync();
    }

    public async Task<XonaDto> GetByIdAsync(int id)
    {
        var xona = await _unitOfWork.XonaInterface.GetByIdAsync(id);
        if(xona is null)
        {
            throw new NotFoundException("Bunday xona topilmadi");
        }
        return _mapper.Map<XonaDto>(xona);
    }

    public async Task UpdateAsync(UpdateXonaDto dto)
    {
        if (dto is null)
        {
            throw new ArgumentNullException("Xona null");
        }
        var xona = _mapper.Map<Xona>(dto);
        var xonalar = await _unitOfWork.XonaInterface.GetAllAsync();


        if (xona is null)
        {
            throw new CustomException("Xonani map qilishda hatolik yuz berdi ");
        }
        if (xonalar is null)
        {
            throw new NotFoundException("Hech qanday xona topilmadi");
        }

     
        if (xona.IsValid())
        {
            throw new CustomException("Xona invalid");
        }

        await _unitOfWork.XonaInterface.UpdateAsync(xona);
        await _unitOfWork.SaveChangeAsync();
    }
}
