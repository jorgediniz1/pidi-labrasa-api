using Labrasa.API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labrasa.API.Infra.Mapping
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("tb_funcionarios");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            builder.Property(x => x.Departamento).HasColumnType("nvarchar").IsRequired().HasMaxLength(20);
            builder.Property(x => x.Cpf).HasColumnType("nvarchar").IsRequired().HasMaxLength(15);
            builder.Property(x => x.Sexo).HasColumnType("nvarchar").IsRequired().HasMaxLength(15);
            builder.Property(x => x.Telefone).HasColumnType("nvarchar").IsRequired().HasMaxLength(15);
            builder.Property(x => x.Endereco).HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            builder.Property(x => x.Email).HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            builder.Property(x => x.Senha).HasColumnType("nvarchar").IsRequired().HasMaxLength(100);

           
        }
    }
}