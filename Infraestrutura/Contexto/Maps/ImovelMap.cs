using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Dominio.Enums;
using Dominio.Entidades;

namespace Infraestrutura.Contexto.Maps
{
    public class ImovelMap : IEntityTypeConfiguration<Imovel>
    {
        public void Configure(EntityTypeBuilder<Imovel> builder)
        {
            builder.ToTable("imoveis");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).IsRequired().HasColumnType("Text");
            builder.Property(x => x.QuantidadeDeQuartos).IsRequired().HasColumnType("tinyint");
            builder.Property(x => x.TipoImovel).HasConversion(y => y.ToString(), y => (ETipoImovel)Enum.Parse(typeof(ETipoImovel), y)).HasMaxLength(20).IsRequired();
            builder.Property(x => x.ValorAluguel).IsRequired();

            builder.HasOne(x => x.Enderenco).WithOne(x => x.Imovel);
        }
    }
}
