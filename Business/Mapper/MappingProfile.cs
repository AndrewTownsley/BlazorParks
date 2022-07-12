using AutoMapper;
using DataAccess.Data;
using Models;

namespace Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ParkDto, Park>();
            CreateMap<Park, Park>();
            CreateMap<Park, ParkDto>();
        }
    }
}
