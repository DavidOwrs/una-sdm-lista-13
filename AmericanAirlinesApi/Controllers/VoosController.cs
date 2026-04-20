using AmericanAirlinesApi.Data;
using AmericanAirlinesApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmericanAirlinesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class VoosController : ControllerBase
    {
        private readonly AppDbContext _context;
        public VoosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CriarReserva(Reserva reserva)
{
    var voo = await _context.Voos
        .Include(v => v.Aeronave)
        .FirstOrDefaultAsync(v => v.Id == reserva.VooId);

    if (voo == null)
    {
        return BadRequest("Voo não encontrado.");
    }

    // 1 - verificar overbooking
    var totalReservas = await _context.Reservas
        .CountAsync(r => r.VooId == reserva.VooId);

    if (totalReservas >= voo.Aeronave.CapacidadePassageiros)
    {
        return BadRequest("Voo lotado. Não é possível realizar novas reservas.");
    }

    // 2 - lógica do assento
    if (reserva.Assento.EndsWith("A") || reserva.Assento.EndsWith("F"))
    {
        Console.WriteLine("Assento na janela reservado com sucesso!");
        Console.WriteLine("Taxa adicional: $50");
    }

    _context.Reservas.Add(reserva);
    await _context.SaveChangesAsync();

    return Ok(reserva);
}
    }
}