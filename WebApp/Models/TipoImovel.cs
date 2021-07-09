using System.ComponentModel.DataAnnotations;


namespace WebApp.Models
{
    public enum TipoImovel
    {
        [Display(Name= "Casa")]
        Casa,
        [Display(Name = "Apartamento")]
        Apartamento
    }
}
