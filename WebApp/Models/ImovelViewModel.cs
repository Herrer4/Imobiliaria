using Dominio.Enums;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace WebApp.Models
{
    public class ImovelViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [DisplayName("Imovel")]
        public string Descricao { get; set; }

        [DisplayName("Quant. de Quartos")]
        [Required(ErrorMessage = "O campo Quant Quartos é obrigatório")]
        public int QuantidadeDeQuartos { get; set; }

        [DisplayName("Valor do Aluguel")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "O campo Valor Aluguel é obrigatório")]
        public double ValorAluguel { get; set; }

        [DisplayName("Tipo de Imovel")]
        public ETipoImovel TipoImovel { get; set; }

        [HiddenInput]
        public int EnderencoId { get; set; }

        [DisplayName("Cidade")]
        [Required(ErrorMessage = "O campo Cidade é obrigatório")]
        public string Cidade { get; set; }

        [DisplayName("Bairro")]
        [Required(ErrorMessage = "O campo Bairro é obrigatório")]
        public string Bairro { get; set; }

        [HiddenInput]
        public string TipoImovelLabel {get; set;}
    }
}
