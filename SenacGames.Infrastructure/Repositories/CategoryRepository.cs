// =============================================================================
// SenacGames.Infrastructure - CategoryRepository
// =============================================================================
// Implementação do repositório de categorias.
// Segue o mesmo padrão do GameRepository.
// =============================================================================

using Microsoft.EntityFrameworkCore;
using SenacGames.Domain.Entities;
using SenacGames.Domain.Interfaces;
using SenacGames.Infrastructure.Context;

namespace SenacGames.Infrastructure.Repositories
{
    /// <summary>
    /// Implementação do repositório de Categorias usando Entity Framework Core.
    /// </summary>
    public class CategoryRepository : ICategoryRepository
    {
        private readonly SenacGamesDbContext _context;

        public CategoryRepository(SenacGamesDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories
                .Include(c => c.Games) // Inclui os games para contar
                .OrderBy(c => c.Name)
                .ToListAsync();
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            return await _context.Categories
                .Include(c => c.Games)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<int> CountAsync()
        {
            return await _context.Categories.CountAsync();
        }
    }
}
