using Dominio.Entidades;
using Infraestrutura.Contexto.Maps;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Contexto
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Imovel> Imovel { get; set; }

        public DbSet<Enderenco> Enderenco { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ImovelMap());
            modelBuilder.ApplyConfiguration(new EnderencoMap());
        }
    }
}
