using Microsoft.EntityFrameworkCore;
using ParkingModel;

namespace ParkingContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Patio> Patio { get; set; }
        public DbSet<Conferencia> Conferencia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .Property(s => s.Cpf)
                .HasColumnName("Cpf_Id");
            modelBuilder.Entity<Usuario>()
                .Property(s => s.Email)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
