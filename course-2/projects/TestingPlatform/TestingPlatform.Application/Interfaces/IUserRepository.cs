using System;
using System.Collections.Generic;
using System.Text;

namespace TestingPlatform.Application.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAllAsync();

        User GetByIdAsync(int id);

        int CreateAsync(User user);

        void UpdateAsync(User user);

        void DeleteAsync(int id);
    }
}
