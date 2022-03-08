using Labrasa.API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labrasa.API.Infra.Mapping
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {

            builder.ToTable("tb_pedidos");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.ValorPedido).HasColumnName("valor_pedido").HasColumnType("numeric(38,2)");
           
            builder.HasOne(x => x.ComandaPedido).WithMany(x => x.PedidosComanda).HasForeignKey(x => x.ComandaPedidoId);
            builder.HasMany(x => x.Produtos);

        }
    }
}
