using TestingPlatform.API.Responses.Course;
using TestingPlatform.API.Responses.Direction;
using TestingPlatform.API.Responses.Project;

namespace TestingPlatform.API.Responses.Group
{
    public class GroupResponse : BaseResponse
    {
        /// <summary>
        /// Модель направления
        /// </summary>
        public DirectionResponse Direction { get; set; }

        /// <summary>
        /// Модель курса
        /// </summary>
        public CourseResponse Course { get; set; }

        /// <summary>
        /// Модель проекта
        /// </summary>
        public ProjectResponse Project { get; set; }
    }

}
