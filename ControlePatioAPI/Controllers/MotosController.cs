using Microsoft.AspNetCore.Mvc;
using ControlePatioAPI.Data;
using ControlePatioAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlePatioAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MotosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MotosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Moto>>> GetAll()
        {
            return Ok(await _context.Motos.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Moto>> GetById(int id)
        {
            var moto = await _context.Motos.FindAsync(id);
            if (moto == null) return NotFound();
            return Ok(moto);
        }

        [HttpGet("placa/{placa}")]
        public async Task<ActionResult<Moto>> GetByPlaca(string placa)
        {
            var moto = await _context.Motos.FirstOrDefaultAsync(m => m.Placa == placa);
            if (moto == null) return NotFound();
            return Ok(moto);
        }

        [HttpPost]
        public async Task<ActionResult<Moto>> Create(Moto moto)
        {
            _context.Motos.Add(moto);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = moto.Id }, moto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Moto moto)
        {
            if (id != moto.Id) return BadRequest();
            _context.Entry(moto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var moto = await _context.Motos.FindAsync(id);
            if (moto == null) return NotFound();
            _context.Motos.Remove(moto);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
