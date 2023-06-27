using AutoMapper;
using Microsoft.Build.Framework.Profiler;
using Session5.DTOs;
using Session5.Model;

namespace Session5.Configuration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
                CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
