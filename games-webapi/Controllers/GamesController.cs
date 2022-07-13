using games_webapi.Context;
using games_webapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace games_webapi.Controllers
{
    [Route("api/games")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var games = await _context.Games.AsNoTracking()
                .ToListAsync();

            if (games is null)
                return NotFound();

            return Ok(games);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var game = await _context.Games.AsNoTracking()
                .FirstOrDefaultAsync(g => g.Id == id);

            if (game is null)
                return NotFound($"Game with ID {id} not found");

            return Ok(game);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Game game)
        {
            await _context.Games.AddAsync(game);
            await _context.SaveChangesAsync();

            return Ok(game);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, Game game)
        {
            if (game.Id != id)
                return BadRequest();

            _context.Entry(game).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(game);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var game = await _context.Games.FirstOrDefaultAsync(g => g.Id == id);

            if (game is null)
                return NotFound($"Game with ID {id} not found");

            _context.Games.Remove(game);
            await _context.SaveChangesAsync();

            return Ok(game);
        }
    }
}
