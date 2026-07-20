// =============================================================================
// SenacGames.Domain - Entidade Game
// =============================================================================
// Esta classe representa a entidade principal do sistema: um jogo (Game).
// Ela pertence à camada de DOMÍNIO, que é responsável por definir as entidades
// e regras de negócio do sistema.
//
//  CONCEITO IMPORTANTE:
// A camada Domain NÃO depende de nenhuma outra camada.
// Ela é o "coração" da aplicação e define O QUE o sistema é.
// =============================================================================

namespace SenacGames.Domain.Entities
{
    /// <summary>
    /// Representa um jogo no catálogo do SenacGames.
    /// Cada game possui um título, descrição, ano de lançamento,
    /// imagem de capa e pertence a uma categoria.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Identificador único do game (chave primária).
        /// O Entity Framework gera automaticamente esse valor.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Título do game. Exemplo: "God of War Ragnarök"
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Descrição detalhada do game.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Ano de lançamento do game.
        /// </summary>
        public int ReleaseYear { get; set; }

        /// <summary>
        /// URL da imagem de capa do game.
        /// </summary>
        public string CoverImageUrl { get; set; } = string.Empty;

        /// <summary>
        /// Chave estrangeira (FK) que relaciona o game com uma categoria.
        ///  CONCEITO: Foreign Key - conecta duas tabelas no banco de dados.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Indica se o game está em destaque na página inicial.
        /// </summary>
        public bool IsFeatured { get; set; }

        /// <summary>
        /// Data de criação do registro no banco de dados.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // =====================================================================
        // NAVIGATION PROPERTY (Propriedade de Navegação)
        // =====================================================================
        //  CONCEITO IMPORTANTE:
        // Navigation Properties permitem que o Entity Framework carregue
        // automaticamente os dados relacionados de outra tabela.
        // Aqui, cada Game "navega" até sua Category correspondente.
        // =====================================================================

        /// <summary>
        /// Categoria à qual este game pertence (propriedade de navegação).
        /// </summary>
        public virtual Category? Category { get; set; }
    }
}
