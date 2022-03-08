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
            builder.Property(x => x.Nome).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.Departamento).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(x => x.Cpf).HasColumnType("nvarchar(15)").IsRequired();
            builder.Property(x => x.Sexo).HasColumnType("nvarchar(15)").IsRequired();
            builder.Property(x => x.Telefone).HasColumnType("nvarchar(15)").IsRequired();
            builder.Property(x => x.Endereco).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.Email).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}