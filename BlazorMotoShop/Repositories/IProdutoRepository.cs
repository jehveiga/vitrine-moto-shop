using BlazorMotoShop.Models;

namespace BlazorMotoShop.Repositories
{
    public interface IProdutoRepository : IDisposable
    {
        Task<Produto> ObterProdutoPorId(int id);
        Task<IEnumerable<Produto>> ObterProdutos();
        Task<IEnumerable<Produto>> ObterProdutosComCategoria();
        Task<Produto> ObterProdutoComCategoria(int id);
        Task AdicionarProduto(Produto produto);
        Task EditarProduto(Produto produto);
        Task DeletarProduto(Produto produto);
    }
}
