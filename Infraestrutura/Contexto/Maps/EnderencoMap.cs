using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestrutura.Contexto.Maps
{
    public class EnderencoMap : IEntityTypeConfiguration<Enderenco>
    {
        public void Configure(EntityTypeBuilder<Enderenco> builder)
        {
            builder.ToTable("enderencos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Bairro).HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(x => x.Cidade).HasMaxLength(100).HasColumnType("varchar(100)");
        }
    }
}
