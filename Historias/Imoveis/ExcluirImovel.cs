using System.Threading.Tasks;

using Dominio.Entidades;
using Dominio.Entidades.IRepositorios;

namespace Historias.Imoveis
{
    public class ExcluirImovel : IExcluirImovel
    {
        private readonly IImovelRepositorio _imovelRepositorio;

        public ExcluirImovel(IImovelRepositorio imovelRepositorio)
        {
            _imovelRepositorio = imovelRepositorio;
        }

        public async Task Executar(Imovel imovel)
        {
            await _imovelRepositorio.Excluir(imovel);
        }
    }
}
