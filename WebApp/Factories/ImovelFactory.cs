using Dominio.Entidades;
using System.Collections.Generic;
using WebApp.Models;
using Dominio.Enums;

namespace WebApp.Factories
{
    internal class ImovelFactory
    {
        public static ImovelViewModel MapearImovelViewModel(Imovel imovel)
        {
            var autorViewModel = new ImovelViewModel
            {
                Id = imovel.Id,
                Descricao = imovel.Descricao,
                QuantidadeDeQuartos = imovel.QuantidadeDeQuartos,
                ValorAluguel = imovel.ValorAluguel,
                TipoImovel = imovel.TipoImovel,
                Cidade = imovel.Enderenco.Cidade,
                Bairro = imovel.Enderenco.Bairro,
                TipoImovelLabel = imovel.TipoImovel == ETipoImovel.Apartamento ? "Apartamento" : "Casa"
            };

            return autorViewModel;
        }

        public static ImovelViewModel MapearImovelViewModelAlterar(Imovel imovel)
        {
            var autorViewModel = new ImovelViewModel
            {
                Id = imovel.Id,
                Descricao = imovel.Descricao,
                QuantidadeDeQuartos = imovel.QuantidadeDeQuartos,
                ValorAluguel = imovel.ValorAluguel,
                TipoImovel = imovel.TipoImovel,
                EnderencoId = imovel.Enderenco.Id,
                Cidade = imovel.Enderenco.Cidade,
                Bairro = imovel.Enderenco.Bairro
            };

            return autorViewModel;
        }

        public static Imovel MapearImovel(ImovelViewModel imovelViewModel)
        {
            var imovel = new Imovel
            {
                Id = imovelViewModel.Id,
                Descricao = imovelViewModel.Descricao,
                QuantidadeDeQuartos = imovelViewModel.QuantidadeDeQuartos,
                ValorAluguel = imovelViewModel.ValorAluguel,
                TipoImovel = imovelViewModel.TipoImovel,
                Enderenco = new Enderenco()
                {            
                    Id = imovelViewModel.EnderencoId,
                    ImovelId = imovelViewModel.Id,
                    Cidade = imovelViewModel.Cidade,
                    Bairro = imovelViewModel.Bairro
                }
            };

            return imovel;
        }

        public static IEnumerable<ImovelViewModel> MapearListaImovelViewModel(IEnumerable<Imovel> listaImoveis)
        {
            var lista = new List<ImovelViewModel>();
            foreach (var item in listaImoveis)
            {
                lista.Add(MapearImovelViewModel(item));
            }

            return lista;
        }
    }
}