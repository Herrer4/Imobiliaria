namespace Dominio.Entidades
{
    public class Enderenco
    {
        public int Id { get; set; }
        public int ImovelId { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public Imovel Imovel { get;set;}
    }
}
