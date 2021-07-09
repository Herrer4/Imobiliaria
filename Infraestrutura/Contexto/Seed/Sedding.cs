using System.Linq;
using Dominio.Entidades;

namespace Infraestrutura.Contexto.Seed
{
    public class Sedding
    {
        private DataContext _dataContext;

        public Sedding(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Seed()
        {
            if (_dataContext.Imovel.Any())
            {
                return;
            }

            Imovel i1 = new Imovel() { Descricao = "Apartamento Test", QuantidadeDeQuartos = 2, TipoImovel = Dominio.Enums.ETipoImovel.Apartamento, ValorAluguel = 1 };

            _dataContext.Imovel.Add(i1);

            _dataContext.SaveChanges();

            Enderenco e1 = new Enderenco() { ImovelId = i1.Id, Bairro = "Canasvieras", Cidade = "Florianopolis" };
            _dataContext.Enderenco.Add(e1);

            _dataContext.SaveChanges();
        }
    }
}
