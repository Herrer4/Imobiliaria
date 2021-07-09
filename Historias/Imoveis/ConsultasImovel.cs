using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Dominio.Entidades;
using Dominio.Entidades.IRepositorios;

namespace Historias.Imoveis
{
    public class ConsultasImovel : IConsultasImovel
    {
        private readonly IImovelRepositorio _imovelRepositorio;

        public ConsultasImovel(IImovelRepositorio imovelRepositorio)
        {
            _imovelRepositorio = imovelRepositorio;
        }

        public async Task<IEnumerable<Imovel>> ListaPorCidade(string cidade)
        {
            var todosImoveis = await _imovelRepositorio.ListarTodosOsImoveis();

            var imoveis = from i in todosImoveis

                          where i.Enderenco.Cidade == cidade

                          select i;

            return imoveis;
        }

        public async Task<IEnumerable<Imovel>> ListaPorBairro(string bairro)
        {
            var todosImoveis = await _imovelRepositorio.ListarTodosOsImoveis();

            var imoveis = from i in todosImoveis

                          where i.Enderenco.Bairro == bairro

                          select i;

            return imoveis;
        }

        public async Task<IEnumerable<Imovel>> ListaTodos()
        {
            return await _imovelRepositorio.ListarTodosOsImoveis();
        }

        public async Task<Imovel> BuscarPeloId(int id)
        {
            return await _imovelRepositorio.BuscarPorId(id);
        }
    }
}
