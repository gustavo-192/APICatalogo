using APICatalogo.Models;

namespace APICatalogo.Repositories;

public interface IProdutoRepository
{
    public IQueryable<Produto> GetProdutos();
    public Produto GetProduto(int id);
    public Produto Create(Produto produto);
    public bool Update(Produto produto);
    public bool Delete(int id);

}