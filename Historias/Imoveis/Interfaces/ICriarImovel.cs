using Dominio.Entidades;
using System.Threading.Tasks;

namespace Historias.Imoveis
{
    public interface ICriarImovel
    {
        Task Executar(Imovel imovel);
    }
}