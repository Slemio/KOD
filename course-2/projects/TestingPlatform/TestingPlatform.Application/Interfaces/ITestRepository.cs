using System;
using System.Collections.Generic;
using System.Text;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Models;

namespace TestingPlatform.Application.Interfaces
{
    public interface ITestRepository
    {
        Task<IEnumerable<TestDto>> GetAllAsync();
        Task<TestDto> GetByIdAsync(int id);
        Task<int> CreateAsync(TestDto test);
        Task UpdateAsync(TestDto test);
        Task DeleteAsync(int id);
    }
}
