using AutoMapper;
using TestingPlatform.API.Requests.Group;
using TestingPlatform.API.Responses.Group;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Models;

namespace TestingPlatform.Infrastructure.Mappings;

public class GroupProfile : Profile
{
    public GroupProfile()
    {
        CreateMap<GroupDto, GroupResponse>();
        CreateMap<CreateGroupRequest, GroupDto>()
            .ForMember(d => d.directionDto, o => o.MapFrom(s => s.DirectionId > 0 ? new DirectionDto { Id = s.DirectionId } : null))
            .ForMember(d => d.courseDto, o => o.MapFrom(s => s.CourseId > 0 ? new CourseDto { Id = s.CourseId } : null))
            .ForMember(d => d.projectDto, o => o.MapFrom(s => s.ProjectId > 0 ? new ProjectDto { Id = s.ProjectId } : null));
        CreateMap<UpdateGroupRequest, GroupDto>()
            .ForMember(d => d.directionDto, o => o.MapFrom(s => s.DirectionId > 0 ? new DirectionDto { Id = s.DirectionId } : null))
            .ForMember(d => d.courseDto, o => o.MapFrom(s => s.CourseId > 0 ? new CourseDto { Id = s.CourseId } : null))
            .ForMember(d => d.projectDto, o => o.MapFrom(s => s.ProjectId > 0 ? new ProjectDto { Id = s.ProjectId } : null));
    }
}

