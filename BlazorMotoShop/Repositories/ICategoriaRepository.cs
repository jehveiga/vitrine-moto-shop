using BlazorMotoShop.Models;

namespace BlazorMotoShop.Repositories
{
    public interface ICategoriaRepository : IDisposable
    {
        Task<Categoria> ObterCategoriaPorId(int id);
        Task<IEnumerable<Categoria>> ObterCategorias();
        Task<IEnumerable<Categoria>> ObterCategoriasOrdenadas();
        Task AdicionarCategoria(Categoria categoria);
        Task EditarCategoria(Categoria categoria);
        Task DeletarCategoria(Categoria categoria);
    }
}
