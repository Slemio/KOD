using System;
using System.Collections.Generic;
using System.Text;
using TestingPlatform.Application.Dtos;

namespace TestingPlatform.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserDto>> GetAllAsync();

        Task<UserDto> GetByIdAsync(int id);

        Task<int> CreateAsync(UserDto user);

        Task UpdateAsync(UserDto user);

        Task DeleteAsync(int id);
    }
}
