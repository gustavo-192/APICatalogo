using APICatalogo.Models;

namespace APICatalogo.Repositories;

public interface IProdutoRepository : IRepository<Produto>
{
    public IEnumerable<Produto> GetProdutosPorCategoria(int id);
}