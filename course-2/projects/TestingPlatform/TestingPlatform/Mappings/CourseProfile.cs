using AutoMapper;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Models;
using TestingPlatform.API.Responses.Course;

namespace TestingPlatform.API.Mappings;

public class CourseProfile : Profile
{
    public CourseProfile()
    {
        CreateMap<CourseDto, CourseResponse>().ReverseMap();
    }
}

