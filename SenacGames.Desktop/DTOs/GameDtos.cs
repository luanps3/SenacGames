// =============================================================================
// SenacGames.Desktop - DTOs/GameDtos.cs
// =============================================================================
//  CONCEITO: DTOs de Games do Desktop
//
// Estes DTOs espelham os contratos da API de Games:
//   GET    /api/games         retorna lista de GameResponseDto
//   GET    /api/games/{id}    retorna GameResponseDto
//   POST   /api/games         recebe CreateGameDto
//   PUT    /api/games/{id}    recebe UpdateGameDto
//   DELETE /api/games/{id}    sem corpo
//
// IMPORTANTE: As propriedades devem ter os MESMOS NOMES que os campos JSON
// retornados pela API (System.Text.Json é case-insensitive por padrão).
// =============================================================================

namespace SenacGames.Desktop.DTOs
{
    /// <summary>
    /// DTO para representar um Game retornado pela API.
    /// Usado para leitura (listagem, visualização).
    /// </summary>
    public class GameResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }

        /// <summary>Nome da categoria (já resolvido pela API via JOIN)</summary>
        public string CategoryName { get; set; } = string.Empty;

        public bool IsFeatured { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    /// <summary>
    /// DTO para criação de um novo Game.
    /// Enviado no corpo do POST /api/games.
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
    /// Enviado no corpo do PUT /api/games/{id}.
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
