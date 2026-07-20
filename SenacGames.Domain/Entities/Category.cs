// =============================================================================
// SenacGames.Domain - Entidade Category
// =============================================================================
// Esta classe representa uma categoria de jogos no sistema.
// Exemplos: "Ação", "RPG", "Corrida", "Terror", etc.
//
//  CONCEITO IMPORTANTE:
// Uma Category possui MUITOS Games (relação 1:N - um para muitos).
// Isso significa que cada Category pode ter vários Games associados.
// =============================================================================

namespace SenacGames.Domain.Entities
{
    /// <summary>
    /// Representa uma categoria de games.
    /// Uma categoria agrupa games do mesmo gênero.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Identificador único da categoria (chave primária).
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da categoria. Exemplo: "Ação", "RPG", "Terror".
        /// </summary>
        public string Name { get; set; } = string.Empty;

        // =====================================================================
        // NAVIGATION PROPERTY - Coleção de Games
        // =====================================================================
        //  CONCEITO:
        // Uma Category pode ter VÁRIOS Games associados (relação 1:N).
        // O ICollection<Game> representa essa coleção de games.
        // O Entity Framework usa essa propriedade para fazer JOINs automáticos.
        // =====================================================================

        /// <summary>
        /// Lista de games que pertencem a esta categoria (propriedade de navegação).
        /// </summary>
        public virtual ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
