using Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Historias.Imoveis
{
    public interface IConsultasImovel
    {
        Task<IEnumerable<Imovel>> ListaPorBairro(string bairro);
        Task<IEnumerable<Imovel>> ListaPorCidade(string cidade);
        Task<IEnumerable<Imovel>> ListaTodos();
        Task<Imovel> BuscarPeloId(int id);
    }
}