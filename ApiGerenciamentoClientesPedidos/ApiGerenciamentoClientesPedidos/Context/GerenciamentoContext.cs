    using ApiGerenciamentoClientesPedidos.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiGerenciamentoClientesPedidos.Context
{
    public class GerenciamentoContext : DbContext
    {
        public GerenciamentoContext(DbContextOptions<GerenciamentoContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pedido>()
                .Property(p => p.valorTotalPedido)
                .HasColumnType("decimal(18,2)"); // Define o tipo da coluna no banco de dados

            // Configuração um para muitos
            modelBuilder.Entity<Cliente>()
            .HasMany(c => c.Pedidos)
            .WithOne(p => p.Cliente)
            .HasForeignKey(p => p.ClienteId);
        }


    }
}
