using System;
using System.Collections.Generic;
using System.Text;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Models;

namespace TestingPlatform.Application.Interfaces
{
    public interface IGroupRepository
    {
        int Create(GroupDto group);
        List<GroupDto> GetAll();
        GroupDto GetById(int id);
        void Update(GroupDto group);
        void Delete(int id);
    }
}
