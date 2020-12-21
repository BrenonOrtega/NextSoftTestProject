using AutoMapper;
using NextSoftTest.Dtos;
using NextSoftTest.Models;

namespace NextSoftTest.Profiles
{
    public class CadastrosProfile : Profile
    {
        public CadastrosProfile()
        {
            CreateMap<cadastro, CadastroReadDto>();
            CreateMap<CadastroCreateDto, cadastro>();
            CreateMap<CadastroUpdateDto, cadastro>();
            CreateMap<cadastro, CadastroUpdateDto>();
        }
    }
}