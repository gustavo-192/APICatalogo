using System.Runtime.InteropServices;
using APICatalogo.Models;
using APICatalogo.Pagination;

namespace APICatalogo.Repositories;

public interface ICategoriaRepository : IRepository<Categoria>
{
    
    public PagedList<Categoria> GetCategorias(CategoriasParameters categoriasParams);
}