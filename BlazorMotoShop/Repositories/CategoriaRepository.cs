using BlazorMotoShop.Data;
using BlazorMotoShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorMotoShop.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoriaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Categoria>> ObterCategorias()
        {
            var categorias = await _context.Categorias.ToListAsync();
            return categorias;
        }

        public async Task<Categoria> ObterCategoriaPorId(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);
            return categoria;
        }

        public async Task AdicionarCategoria(Categoria categoria)
        {
            await _context.Categorias.AddAsync(categoria);
            await _context.SaveChangesAsync();
        }

        public async Task DeletarCategoria(Categoria categoria)
        {
            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();
        }

        public async Task EditarCategoria(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
