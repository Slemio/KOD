using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllTests() => Ok("Список тестов");

        [HttpGet("{id}")]
        public IActionResult GetTestById([FromRoute] int id)
        {
            if (id == 1)
                return Ok("Тест 1");
            return NotFound();
        }

        [HttpPost]
        public IActionResult CreateTest() 
        {
            return Created("/api/tests/1", "Создан тест с ID=1");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTest([FromRoute] int id)
        {
            if (id <= 0) return BadRequest("Неккоректный id");
            if (id != 1) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTest([FromRoute] int id)
        {
            if (id <= 0) return BadRequest("Неккоректный id");
            if (id != 1) return NotFound();

            return NoContent();
        }
    }

}