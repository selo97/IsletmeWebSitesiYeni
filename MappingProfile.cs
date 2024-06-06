using AutoMapper;
using IsletmeWebSitesiYeni.Models;
using IsletmeWebSitesiYeni.ViewModels;

namespace IsletmeWebSitesiYeni
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }
}
