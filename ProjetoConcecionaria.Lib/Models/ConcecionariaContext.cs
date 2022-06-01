using Microsoft.EntityFrameworkCore;

namespace ProjetoConcecionaria.Lib.Models
{
    public class ConcecionariaContext : DbContext
    {
        public ConcecionariaContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Carro>().ToTable("CC_Carros");           
            

            modelBuilder.Entity<Cliente>().ToTable("CC_Clientes");
            modelBuilder.Entity<Funcionario>().ToTable("CC_Funcionarios");
            modelBuilder.Entity<Moto>().ToTable("CC_Motos");
            modelBuilder.Entity<Venda>().ToTable("CC_Vendas");
        }

        public DbSet<Carro> Carros { get; set;}
        public DbSet<Cliente> Cliente{ get; set;}
        public DbSet<Funcionario> Funcionario { get; set;}
        public DbSet<Moto> Moto { get; set;}
        public DbSet<Venda> Venda { get; set;}
    }
}