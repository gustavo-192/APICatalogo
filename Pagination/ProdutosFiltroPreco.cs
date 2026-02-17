using APIcatalogo.Pagination;

namespace APICatalogo.Pagination;

public class ProdutosFiltroPreco : QuerystringParameters
{
    public decimal? Preco { get; set; }
    public string? PrecoCriterio { get; set; } // "maior", "menor" ou "igual"
}
