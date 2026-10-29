using AutoMapper;
using TestingPlatform.Application.Dtos;

namespace TestingPlatform.API.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }


}
