// =============================================================================
// SenacGames.Domain - Interface IGameRepository
// =============================================================================
//  CONCEITO IMPORTANTE:
// Uma INTERFACE define um CONTRATO - ela diz O QUE deve ser feito,
// mas NÃO diz COMO fazer. A implementação fica em outra camada.
//
// Isso é fundamental na arquitetura em camadas:
// - O Domain DEFINE a interface (o contrato)
// - O Infrastructure IMPLEMENTA a interface (o código real)
// - Isso permite trocar a implementação sem alterar o resto do sistema
// =============================================================================

using SenacGames.Domain.Entities;

namespace SenacGames.Domain.Interfaces
{
    /// <summary>
    /// Contrato do repositório de Games.
    /// Define as operações disponíveis para acessar dados de games.
    /// </summary>
    public interface IGameRepository
    {
        /// <summary>
        /// Retorna todos os games do banco de dados.
        /// </summary>
        Task<IEnumerable<Game>> GetAllAsync();

        /// <summary>
        /// Busca um game específico pelo seu Id.
        /// Retorna null se não encontrar.
        /// </summary>
        Task<Game?> GetByIdAsync(int id);

        /// <summary>
        /// Retorna apenas os games marcados como destaque (IsFeatured = true).
        /// </summary>
        Task<IEnumerable<Game>> GetFeaturedAsync();

        /// <summary>
        /// Retorna todos os games de uma categoria específica.
        /// </summary>
        Task<IEnumerable<Game>> GetByCategoryAsync(int categoryId);

        /// <summary>
        /// Adiciona um novo game ao banco de dados.
        /// </summary>
        Task AddAsync(Game game);

        /// <summary>
        /// Atualiza os dados de um game existente.
        /// </summary>
        Task UpdateAsync(Game game);

        /// <summary>
        /// Remove um game do banco de dados.
        /// </summary>
        Task DeleteAsync(int id);

        /// <summary>
        /// Retorna o total de games cadastrados.
        /// </summary>
        Task<int> CountAsync();
    }
}
