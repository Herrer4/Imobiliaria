using Dominio.Enums;

namespace Dominio.Entidades
{
    public class Imovel
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public int QuantidadeDeQuartos { get; set; }

        public double ValorAluguel { get; set; }

        public ETipoImovel TipoImovel { get; set; }        

        public Enderenco Enderenco { get; set; }
    }
}
