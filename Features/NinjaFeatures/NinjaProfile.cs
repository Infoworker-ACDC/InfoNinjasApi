using AutoMapper;

namespace InfoNinjasApi.Features.NinjaFeatures
{
    public class NinjaProfile : Profile
    {
        public NinjaProfile()
        {
            CreateMap<NinjaItemDto, NinjaItem>().ReverseMap();
        }
    }
}