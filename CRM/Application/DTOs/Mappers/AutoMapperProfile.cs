using Application.DTOs.FanDtos;
using Application.DTOs.GuruhDtos;
using Application.DTOs.TalabaDtos;
using Application.DTOs.TalabaGuruhDavomatDtos;
using Application.DTOs.TalabaGuruhDtos;
using Application.DTOs.TalabaTolovDtos;
using Application.DTOs.TeacherDtos;
using Application.DTOs.TeacherFanDtos;
using Application.DTOs.XonaDtos;
using AutoMapper;
using Domain.Entities.CRM;

namespace Application.DTOs.Mappers;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<AddFanDto, Fan>();
        CreateMap<FanDto, Fan>().ReverseMap();
        CreateMap<UpdateFanDto, Fan>();


        CreateMap<AddGuruhDto, Guruh>();
        CreateMap<GuruhDto, Guruh>().ReverseMap();
        CreateMap<UpdateGuruhDto, Guruh>();


        CreateMap<AddTalabaDto, Talaba>();
        CreateMap<TalabaDto, Talaba>().ReverseMap();
        CreateMap<UpdateTalabaDto, Talaba>();


        CreateMap<AddTalabaGuruhDavomatDto, TalabaGuruhDavomat>();
        CreateMap<TalabaGuruhDavomatDto, TalabaGuruhDavomat>().ReverseMap();
        CreateMap<UpdateTalabaGuruhDavomatDto, TalabaGuruhDavomat>();


        CreateMap<AddTalabaGuruhDto, TalabaGuruh>();
        CreateMap<TalabaGuruhDto, TalabaGuruh>().ReverseMap();
        CreateMap<UpdateTalabaGuruhDto, TalabaGuruh>();


        CreateMap<AddTalabaTolovDto, TalabaTolov>();
        CreateMap<TalabaTolovDto, TalabaTolov>().ReverseMap();
        CreateMap<UpdateTalabaTolovDto, TalabaTolov>();


        CreateMap<AddTeacherDto, Teacher>();
        CreateMap<TeacherDto, Teacher>().ReverseMap();
        CreateMap<UpdateTeacherDto, Teacher>();


        CreateMap<AddTeacherFanDto, TeacherFan>();
        CreateMap<TeacherFanDto, TeacherFan>().ReverseMap();
        CreateMap<UpdateTeacherFanDto, TeacherFan>();


        CreateMap<AddXonaDto, Xona>();
        CreateMap<XonaDto, Xona>().ReverseMap();
        CreateMap<UpdateXonaDto, Xona>();
    }
}
