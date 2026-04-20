using AmericanAirlinesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AmericanAirlinesApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        } 
        public DbSet<Aeronave> Aeronaves {get;set; }
        public DbSet<Tripulante> Tripulantesq {get;set; }
        public DbSet<Voo> Voos {get;set; }
        public DbSet<Reserva> Reservas {get;set; }
    }
    
}