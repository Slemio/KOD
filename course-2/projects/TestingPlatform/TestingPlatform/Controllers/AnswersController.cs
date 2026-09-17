using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllAnswers() => Ok("Список всех ответов");

        [HttpGet("{id}")]
        public IActionResult GetAnswerById([FromRoute] int id)
        {
            if (id == 1)
                return Ok("Ответ 1");
            return NotFound();
        }

        [HttpGet("by-question/{questionId}")]
        public IActionResult GetAnswersByQuestionId([FromRoute] int questionId)
        {
            return Ok($"Ответы для вопроса {questionId}");
        }


        [HttpPost]
        public IActionResult CreateAnswer()
        {
            return Created("/api/answers/1", "Ответ создан");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAnswer([FromRoute] int id)
        {
            if (id <= 0) return BadRequest("Неккоректный id");
            if (id != 1) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAnswer([FromRoute] int id)
        {
            if (id <= 0) return BadRequest("Неккоректный id");
            if (id != 1) return NotFound();

            return NoContent();
        }
    }
}
