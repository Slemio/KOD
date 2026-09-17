using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllQuestions() => Ok("Список всех вопросов");

        [HttpGet("{id}")]
        public IActionResult GetQuestionById([FromRoute] int id)
        {
            if (id == 1)
                return Ok("Тест 1");
            return NotFound();
        }

        [HttpGet("by-test/{testId}")]
        public IActionResult GetQuestionsByTestId([FromRoute] int testId) 
        { 
           return Ok($"Вопросы для теста {testId}");
        }


        [HttpPost]
        public IActionResult CreateQuestion()
        {
            return Created("/api/questions/1", "Вопрос создан");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateQuestion([FromRoute] int id)
        {
            if (id <= 0) return BadRequest("Неккоректный id");
            if (id != 1) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteQuestion([FromRoute] int id)
        {
            if (id <= 0) return BadRequest("Неккоректный id");
            if (id != 1) return NotFound();

            return NoContent();
        }
    }
}
