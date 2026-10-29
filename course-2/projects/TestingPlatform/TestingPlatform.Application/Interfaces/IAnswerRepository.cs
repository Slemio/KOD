using System;
using System.Collections.Generic;
using System.Text;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Models;

namespace TestingPlatform.Application.Interfaces
{
    public interface IAnswerRepository
    {
        Task<IEnumerable<AnswerDto>> GetAllAsync();
        Task<AnswerDto> GetByIdAsync(int id);
        Task<int> CreateAsync(AnswerDto answer);
        Task UpdateAsync(AnswerDto answer);
        Task DeleteAsync(int id);
    }
}
