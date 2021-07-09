using Dominio.Entidades;
using System.Threading.Tasks;

namespace Historias.Imoveis
{
    public interface IAlterarImovel
    {
        Task Execultar(Imovel imovel);
    }
}