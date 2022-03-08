using Labrasa.API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labrasa.API.Infra.Mapping
{
    public class MesaMap : IEntityTypeConfiguration<Mesa>
    {
        public void Configure(EntityTypeBuilder<Mesa> builder)
        {
            builder.ToTable("tb_mesas");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.NumeroMesa).HasColumnType("nvarchar(2)").HasColumnName("numero_mesa");
            builder.Property(x => x.ComandasAbertas).HasColumnType("nvarchar(2)").HasColumnName("comandas_abertas");
            builder.Property(x => x.ComandasFechadas).HasColumnType("nvarchar(2)").HasColumnName("comandas_fechadas");


            builder.HasMany(x => x.ComandaMesa).WithOne(x => x.Mesa).HasForeignKey(x => x.MesaId);

        }
    }
}
