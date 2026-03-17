using System.Collections.ObjectModel;

namespace APICatalogo.Models;

public class Categoria
{
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }
    public int CategoriaID{ get; set; }
    public String? Nome { get; set; }

    public String? ImageURL { get; set; }

    public ICollection<Produto>? Produtos { get; set;}

}
