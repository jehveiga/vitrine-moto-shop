﻿using BlazorMotoShop.Data;
using BlazorMotoShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorMotoShop.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Produto> ObterProdutoPorId(int id)
        {
            return await _context.Produtos.FindAsync(id) ?? new();
        }

        public async Task<IEnumerable<Produto>> ObterProdutos()
        {
            return await _context.Produtos.AsNoTracking().ToListAsync();
        }

        public async Task<Produto> ObterProdutoComCategoria(int id) => await _context.Produtos.Include(produto => produto.Categoria)
                                                                                              .AsNoTracking()
                                                                                              .FirstOrDefaultAsync(produto => produto.Id == id) ?? new();

        public async Task<IEnumerable<Produto>> ObterProdutosComCategoria() =>
                                                await _context.Produtos.Include(produto => produto.Categoria).AsNoTracking().ToListAsync();

        public async Task AdicionarProduto(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();
        }

        public async Task DeletarProduto(Produto produto)
        {
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();

        }

        public async Task EditarProduto(Produto produto)
        {
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}
