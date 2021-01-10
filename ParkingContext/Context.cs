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
            // -------------------------- Alterações Usuário

            modelBuilder.Entity<Usuario>()
                .Property(s => s.Cpf)
                .HasColumnName("Cpf_Id")
                .IsRequired();

            

            modelBuilder.Entity<Usuario>()
                .Property(s => s.Email)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Usuario>()
                .HasKey(a => a.UsuarioId);
            
            modelBuilder.Entity<Usuario>()
                .Property(s => s.NomeCompleto)
                .HasColumnName("NomesCompleto");

            modelBuilder.Entity<Usuario>()
                .Ignore(a => a.Idade);



            // -------------------------- Alterações Pátio
            
            modelBuilder.Entity<Patio>()
                .HasKey(a => a.Patio_Id);

            modelBuilder.Entity<Patio>()
                .Property(s => s.Cpf)
                .HasColumnName("Cpf_Id")
                .IsRequired();

            modelBuilder.Entity<Patio>()
            .HasOne(b => b.Informacoes)
            .WithOne(i => i.Patio)
            .HasForeignKey<Conferencia>(a => a.Patio_Id);

            // -------------------------- Alterações Conferência

            modelBuilder.Entity<Conferencia>()
                .HasKey(a => a.Inf_Id);

            // -------------------------- Alterações Carro
            modelBuilder.Entity<Carro>()
                .HasKey(a => a.CaroId);

            modelBuilder.Entity<Carro>()
                .Property(a => a.CaroId)
                .HasColumnName("Carro_Id");

            modelBuilder.Entity<Carro>()
                .Property(a => a.Conferencia)
                .HasMaxLength(500)
                .IsRequired();

            modelBuilder.Entity<Carro>()
                .HasOne(a => a.Usuario)
                .WithMany(a => a.Carros);
        }
    }
}
