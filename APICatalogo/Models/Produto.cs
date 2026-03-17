namespace APICatalogo.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public String? Nome { get; set; }
        public String? Descricao { get; set; }
        public decimal? Preco { get; set; }
        public string? ImageURL { get; set; }
        public float Estoque { get; set; }
        public DateTime DatCadastro { get; set; }

        public int CategoriaID { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
