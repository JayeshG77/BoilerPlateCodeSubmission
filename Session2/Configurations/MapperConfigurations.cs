using AutoMapper;
using Session2.Models;
using Session2.ModeView;

namespace Session2.Configurations
{
    public class MapperConfigurations : Profile
    {
        public MapperConfigurations()
        {
            CreateMap<Product, ShowProductVm>().ReverseMap();
        }
    }
}
