using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestingPlatform.Data;
using TestingPlatform.Models;

namespace TestingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly AppDbContext _db;

        public GroupController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAllGroups()
        {
            var groups = _db.Groups.ToList();
            return Ok(groups); // 200
        }

        [HttpGet("{id:int}")]
        public IActionResult GetGroupById(int id)
        {
            if (id <= 0)
                return BadRequest("Некорректный id"); // 400

            var group = _db.Groups.FirstOrDefault(s => s.Id == id);
            if (group is null)
                return NotFound(); // 404

            return Ok(group); // 200
        }

        [HttpPost]
        public IActionResult CreateGroup([FromBody] Group group)
        {
            _db.Groups.Add(group);
            _db.SaveChanges();

            return Created();
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateGroup([FromBody] Group group)
        {
            var exists = _db.Groups.FirstOrDefault(s => s.Id == group.Id);
            if (exists == default)
                return NotFound();

            _db.Entry(group).State = EntityState.Modified;
            _db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteGroup(int id)
        {
            var group = _db.Groups.Find(id);
            if (group is null)
                return NotFound();

            _db.Groups.Remove(group);
            _db.SaveChanges();

            return NoContent();
        }
    }
}
