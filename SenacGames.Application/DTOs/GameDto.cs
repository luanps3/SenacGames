// =============================================================================
// SenacGames.Application - DTO GameDto
// =============================================================================
//  CONCEITO IMPORTANTE: DTO (Data Transfer Object)
// Um DTO é um objeto usado para TRANSFERIR dados entre camadas.
// Ele contém apenas os dados necessários, sem lógica de negócio.
//
// Por que usar DTOs ao invés de enviar a Entidade diretamente?
// 1. Segurança: evita expor dados internos do banco
// 2. Flexibilidade: permite enviar apenas os campos necessários
// 3. Desacoplamento: a API não depende da estrutura do banco
// =============================================================================

namespace SenacGames.Application.DTOs
{
    /// <summary>
    /// DTO para transferência de dados de um Game.
    /// Usado para retornar informações de games na API e nas Views.
    /// </summary>
    public class GameDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }

        /// <summary>
        /// Nome da categoria (obtido via JOIN com a tabela Categories).
        /// Evita que o front-end precise fazer uma segunda requisição.
        /// </summary>
        public string CategoryName { get; set; } = string.Empty;

        public bool IsFeatured { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    /// <summary>
    /// DTO para criação de um novo Game.
    /// Contém apenas os campos que o usuário precisa preencher.
    /// Note que Id e CreatedAt NÃO estão aqui — são gerados automaticamente.
    /// </summary>
    public class CreateGameDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public bool IsFeatured { get; set; }
    }

    /// <summary>
    /// DTO para atualização de um Game existente.
    /// </summary>
    public class UpdateGameDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public bool IsFeatured { get; set; }
    }
}
