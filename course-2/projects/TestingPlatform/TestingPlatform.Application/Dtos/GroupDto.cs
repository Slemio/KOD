using System;
using System.Collections.Generic;
using System.Text;

namespace TestingPlatform.Application.Dtos
{
    public class GroupDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DirectionDto directionDto { get; set; }

        public CourseDto courseDto { get; set; }

        public ProjectDto projectDto { get; set; }
    }
}
