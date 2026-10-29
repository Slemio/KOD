using AutoMapper;
using TestingPlatform.API.Requests.Answer;
using TestingPlatform.API.Responses.Answer;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Models;

namespace TestingPlatform.API.Mappings
{
    public class AnswerProfile : Profile
    {
        public AnswerProfile()
        {
            CreateMap<Answer, AnswerDto>().ReverseMap();
            CreateMap<CreateAnswerRequest, Answer>();
            CreateMap<UpdateAnswerRequest, Answer>();
            CreateMap<AnswerDto, AnswerResponse>();
        }
    }
}
