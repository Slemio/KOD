using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok("Студенты...");
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById([FromRoute] int id)
        {
            if (id <= 0) return BadRequest("Неккоректный id");
            if (id == 1) return Ok();

            return NotFound("Студент не найден");
        }

        [HttpPost]
        public IActionResult CreateStudent()
        {
            return Created("/api/student/1", "Студент 1 создан");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent([FromRoute] int id)
        {
            if (id <= 0) return BadRequest("Неккоректный id");
            if (id != 1) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent([FromRoute] int id)
        {
            if (id <= 0) return BadRequest("Неккоректный id");
            if (id != 1) return NotFound();

            return NoContent();
        }
    }
}
