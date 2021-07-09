using System.Threading.Tasks;
using System.Collections.Generic;

using Dominio.Entidades;
using Infraestrutura.Contexto;
using Microsoft.EntityFrameworkCore;
using Dominio.Entidades.IRepositorios;

namespace Infraestrutura.Persistencias
{
    public class ImovelRepositorio : IImovelRepositorio
    {
        private readonly DataContext _dataContext;

        public ImovelRepositorio(DataContext dataContent)
        {
            _dataContext = dataContent;
        }

        public async Task Alterar(Imovel imovel)
        {                       
            _dataContext.Imovel.Update(imovel);
            await _dataContext.SaveChangesAsync();
            
        }

        public async Task<Imovel> BuscarPorId(int id)
        {
            Imovel imovel = await _dataContext.Imovel.Include(x=> x.Enderenco)
                                    .FirstOrDefaultAsync(x => x.Id == id);
            return imovel;
        }

        public async Task Criar(Imovel imovel)
        {
            _dataContext.Imovel.Add(imovel);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Excluir(Imovel imovel)
        {
            _dataContext.Imovel.Remove(imovel);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Imovel>> ListarTodosOsImoveis()
        {
            return await _dataContext.Imovel.AsNoTracking().Include(x=> x.Enderenco).ToListAsync();
        }       
    }
}
