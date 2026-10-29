using AutoMapper;
using TestingPlatform.API.Responses.Direction;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Models;

namespace TestingPlatform.API.Mappings;

public class DirectionProfile : Profile
{
    public DirectionProfile()
    {
        CreateMap<DirectionDto, DirectionResponse>().ReverseMap();
    }
}

