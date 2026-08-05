// =============================================================================
// SenacGames.Desktop - DTOs/CategoriaDtos.cs
// =============================================================================
//  CONCEITO: DTOs de Categorias do Desktop
//
// Espelham os contratos da API de Categorias:
//   GET    /api/categories         retorna lista de CategoriaResponseDto
//   POST   /api/categories         recebe CreateCategoriaDto
//   PUT    /api/categories/{id}    recebe UpdateCategoriaDto
//   DELETE /api/categories/{id}    sem corpo
// =============================================================================

namespace SenacGames.Desktop.DTOs
{
    /// <summary>
    /// DTO para representar uma Categoria retornada pela API.
    /// </summary>
    public class CategoriaResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        /// <summary>Quantidade de games nesta categoria (calculado pela API)</summary>
        public int GameCount { get; set; }
    }

    /// <summary>
    /// DTO para criação de uma nova Categoria.
    /// Enviado no corpo do POST /api/categories.
    /// </summary>
    public class CreateCategoriaDto
    {
        public string Name { get; set; } = string.Empty;
    }

    /// <summary>
    /// DTO para atualização de uma Categoria existente.
    /// Enviado no corpo do PUT /api/categories/{id}.
    /// </summary>
    public class UpdateCategoriaDto
    {
        public string Name { get; set; } = string.Empty;
    }
}
