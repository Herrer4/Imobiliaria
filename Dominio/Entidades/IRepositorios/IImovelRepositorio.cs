using System;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Dominio.Entidades.IRepositorios
{
    public interface IImovelRepositorio
    {
        Task Criar(Imovel imovel);
        Task Alterar(Imovel imovel);
        Task Excluir(Imovel imovel);
        Task<Imovel> BuscarPorId(int id);
        Task<IEnumerable<Imovel>> ListarTodosOsImoveis();
    }
}
