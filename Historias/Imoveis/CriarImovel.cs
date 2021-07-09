using System.Threading.Tasks;

using Dominio.Entidades;
using Dominio.Entidades.IRepositorios;

namespace Historias.Imoveis
{
    public class CriarImovel : ICriarImovel
    {
        private readonly IImovelRepositorio _imovelRepositorio;

        public CriarImovel(IImovelRepositorio imovelRepositorio)
        {
            _imovelRepositorio = imovelRepositorio;
        }

        public async Task Executar(Imovel imovel)
        {
            await _imovelRepositorio.Criar(imovel);
        }
    }
}
