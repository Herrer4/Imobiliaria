using Dominio.Entidades;
using System.Threading.Tasks;

namespace Historias.Imoveis
{
    public interface IExcluirImovel
    {
        Task Executar(Imovel imovel);
    }
}