// =============================================================================
// SenacGames.Application - Interface IGameService
// =============================================================================
//  CONCEITO IMPORTANTE: Service Layer (Camada de Serviço)
// A camada Application contém os SERVIÇOS que orquestram as operações.
// Ela é a "ponte" entre os Controllers e os Repositories.
//
// Fluxo: Controller  Service  Repository  Banco de Dados
//
// O Service é responsável por:
// - Orquestrar chamadas ao repositório
// - Mapear Entidades para DTOs (e vice-versa)
// - Aplicar regras de aplicação (validações, etc.)
// =============================================================================

using SenacGames.Application.DTOs;

namespace SenacGames.Application.Interfaces
{
    /// <summary>
    /// Contrato do serviço de Games.
    /// Define as operações de negócio disponíveis para games.
    /// </summary>
    public interface IGameService
    {
        Task<IEnumerable<GameDto>> GetAllAsync();
        Task<GameDto?> GetByIdAsync(int id);
        Task<IEnumerable<GameDto>> GetFeaturedAsync();
        Task<IEnumerable<GameDto>> GetByCategoryAsync(int categoryId);
        Task<GameDto> CreateAsync(CreateGameDto dto);
        Task<GameDto?> UpdateAsync(int id, UpdateGameDto dto);
        Task<bool> DeleteAsync(int id);
        Task<int> CountAsync();
    }
}
