using games_webapi.Context;
using games_webapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace games_webapi.Controllers
{
    [Route("api/developers")]
    [ApiController]
    public class DevelopersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public DevelopersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var developers = await _context.Developers.AsNoTracking()
                .ToListAsync();

            if (developers is null)
                return NotFound();

            return Ok(developers);
        }

        [HttpGet("games")]
        public async Task<ActionResult> GetDevelopersGames()
        {
            var developersGames = await _context.Developers.AsNoTracking()
                .Include(g => g.Games).ToListAsync();

            if (developersGames is null)
                return NotFound();

            return Ok(developersGames);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var developer = await _context.Developers.AsNoTracking()
                .FirstOrDefaultAsync(d => d.Id == id);

            if (developer is null)
                return NotFound($"Developer with ID {id} not found");

            return Ok(developer);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Developer developer)
        {
            await _context.Developers.AddAsync(developer);
            await _context.SaveChangesAsync();

            return Ok(developer);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, Developer developer)
        {
            if (id != developer.Id)
                return BadRequest();

            _context.Entry(developer).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(developer);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var developer = await _context.Developers.FirstOrDefaultAsync(d => d.Id == id);

            if (developer is null)
                return NotFound($"Developer with ID {id} not found");

            _context.Remove(developer);
            await _context.SaveChangesAsync();

            return Ok(developer);
        }
    }
}
