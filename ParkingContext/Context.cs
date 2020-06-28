using Microsoft.EntityFrameworkCore;
using ParkingModel;

namespace ParkingContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PatioEstacionamento> PastioEstacionamento { get; set; }
        public DbSet<Conferencia> Conferencias { get; set; }
    }
}
