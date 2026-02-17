using APICatalogo.Models;
using APICatalogo.Pagination;
using APICatalogo.Paginations;

namespace APICatalogo.Repositories;

public interface IProdutoRepository : IRepository<Produto>
{
    public PagedList<Produto> GetProdutos(ProdutosParameters produtosParams);
    public PagedList<Produto> GetProdutosFiltroPreco(ProdutosFiltroPreco produtosFiltroParams);
    public IEnumerable<Produto> GetProdutosPorCategoria(int id);
}