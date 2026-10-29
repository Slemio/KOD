using AutoMapper;
using TestingPlatform.API.Requests.Test;
using TestingPlatform.API.Responses.Test;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Models;

namespace TestingPlatform.API.Mappings
{
    public class TestProfile : Profile
    {
       public TestProfile()
        {
            CreateMap<Test, TestDto>().ReverseMap();
            CreateMap<CreateTestRequest, TestDto>();
            CreateMap<UpdateTestRequest, TestDto>();
            CreateMap<TestDto, TestResponse>();
        }
    }
}
