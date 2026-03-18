using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace APICatalogo.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoID { get; set; }
        [Required]
        [StringLength(80)]
        public String? Nome { get; set; }
        [Required]
        [StringLength(300)]
        public String? Descricao { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal? Preco { get; set; }
        [Required]
        [StringLength(300)]
        public string? ImageURL { get; set; }
        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }

        public int CategoriaID { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
