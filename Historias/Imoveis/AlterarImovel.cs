using Dominio.Entidades;
using Dominio.Entidades.IRepositorios;
using System.Threading.Tasks;

namespace Historias.Imoveis
{
    public class AlterarImovel : IAlterarImovel
    {
        private readonly IImovelRepositorio _imovelRepositorio;
       
        public AlterarImovel(IImovelRepositorio imovelRepositorio)
        {
            _imovelRepositorio = imovelRepositorio;
        }

        public async Task Execultar(Imovel imovel)
        {
            await _imovelRepositorio.Alterar(imovel);
        }
    }
}
