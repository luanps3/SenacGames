// =============================================================================
// SenacGames.Infrastructure - GameRepository
// =============================================================================
//  CONCEITO: Repositório (Repository Pattern)
// O repositório encapsula toda a lógica de acesso a dados.
// Ele usa o DbContext do Entity Framework para executar as operações.
//
// Benefícios do Repository Pattern:
// - Centraliza o acesso a dados em um único lugar
// - Facilita a manutenção e testes
// - A camada Application não precisa conhecer o EF Core
// =============================================================================

using Microsoft.EntityFrameworkCore;
using SenacGames.Domain.Entities;
using SenacGames.Domain.Interfaces;
using SenacGames.Infrastructure.Context;

namespace SenacGames.Infrastructure.Repositories
{
    /// <summary>
    /// Implementação do repositório de Games usando Entity Framework Core.
    /// </summary>
    public class GameRepository : IGameRepository
    {
        private readonly SenacGamesDbContext _context;

        public GameRepository(SenacGamesDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retorna todos os games incluindo a categoria relacionada.
        ///  CONCEITO: Include() — carrega dados de tabelas relacionadas (JOIN).
        /// </summary>
        public async Task<IEnumerable<Game>> GetAllAsync()
        {
            return await _context.Games
                .Include(g => g.Category)  // Faz JOIN com a tabela Categories
                .OrderByDescending(g => g.CreatedAt)
                .ToListAsync();
        }

        /// <summary>
        /// Busca um game pelo Id incluindo sua categoria.
        /// </summary>
        public async Task<Game?> GetByIdAsync(int id)
        {
            return await _context.Games
                .Include(g => g.Category)
                .FirstOrDefaultAsync(g => g.Id == id);
        }

        /// <summary>
        /// Retorna apenas os games marcados como destaque.
        ///  CONCEITO: Where() — filtra registros (equivalente ao WHERE do SQL).
        /// </summary>
        public async Task<IEnumerable<Game>> GetFeaturedAsync()
        {
            return await _context.Games
                .Include(g => g.Category)
                .Where(g => g.IsFeatured)  // WHERE IsFeatured = true
                .ToListAsync();
        }

        /// <summary>
        /// Retorna todos os games de uma categoria específica.
        /// </summary>
        public async Task<IEnumerable<Game>> GetByCategoryAsync(int categoryId)
        {
            return await _context.Games
                .Include(g => g.Category)
                .Where(g => g.CategoryId == categoryId)
                .ToListAsync();
        }

        /// <summary>
        /// Adiciona um novo game ao banco de dados.
        ///  CONCEITO: AddAsync() + SaveChangesAsync()
        /// AddAsync() marca a entidade para inserção.
        /// SaveChangesAsync() executa o INSERT no banco de dados.
        /// </summary>
        public async Task AddAsync(Game game)
        {
            await _context.Games.AddAsync(game);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Atualiza um game existente.
        ///  CONCEITO: Update() marca a entidade como modificada.
        /// SaveChangesAsync() executa o UPDATE no banco.
        /// </summary>
        public async Task UpdateAsync(Game game)
        {
            _context.Games.Update(game);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Remove um game do banco de dados.
        /// </summary>
        public async Task DeleteAsync(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game != null)
            {
                _context.Games.Remove(game);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Retorna o total de games cadastrados.
        ///  CONCEITO: CountAsync() — executa COUNT(*) no banco.
        /// </summary>
        public async Task<int> CountAsync()
        {
            return await _context.Games.CountAsync();
        }
    }
}
