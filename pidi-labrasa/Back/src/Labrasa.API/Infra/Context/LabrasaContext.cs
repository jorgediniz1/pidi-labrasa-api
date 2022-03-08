using Labrasa.API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Labrasa.API.Infra.Context
{
    public class LabrasaContext : DbContext
    {
        public LabrasaContext(DbContextOptions<LabrasaContext> opt) : base(opt) {}


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Produto> Produtos { get; set; } 
        public DbSet<Comanda> Comandas { get; set; } 
        public DbSet<Funcionario> Funcionarios { get; set; } 
        public DbSet<Mesa> Mesas { get; set; } 
        public DbSet<Pedido> Pedidos { get; set; } 

    }
}
