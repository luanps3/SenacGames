// =============================================================================
// SenacGames.Application - GameService
// =============================================================================
//  CONCEITO IMPORTANTE: Implementação do Serviço
// Esta classe IMPLEMENTA a interface IGameService.
// Ela usa o repositório (IGameRepository) para acessar o banco de dados
// e converte as entidades em DTOs antes de retornar para o controller.
//
// MAPEAMENTO MANUAL:
// Neste projeto didático, fazemos o mapeamento Entidade  DTO manualmente.
// Em projetos maiores, você pode usar bibliotecas como AutoMapper.
// =============================================================================

using SenacGames.Application.DTOs;
using SenacGames.Application.Interfaces;
using SenacGames.Domain.Entities;
using SenacGames.Domain.Interfaces;

namespace SenacGames.Application.Services
{
    /// <summary>
    /// Serviço de Games — contém a lógica de aplicação para operações com games.
    /// </summary>
    public class GameService : IGameService
    {
        //  CONCEITO: Injeção de Dependência
        // O repositório é injetado via construtor. Isso permite que o .NET
        // forneça automaticamente a implementação correta em tempo de execução.
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        /// <summary>
        /// Retorna todos os games convertidos em DTOs.
        /// </summary>
        public async Task<IEnumerable<GameDto>> GetAllAsync()
        {
            var games = await _gameRepository.GetAllAsync();
            return games.Select(MapToDto);
        }

        /// <summary>
        /// Busca um game pelo Id e retorna como DTO.
        /// </summary>
        public async Task<GameDto?> GetByIdAsync(int id)
        {
            var game = await _gameRepository.GetByIdAsync(id);
            return game == null ? null : MapToDto(game);
        }

        /// <summary>
        /// Retorna os games em destaque.
        /// </summary>
        public async Task<IEnumerable<GameDto>> GetFeaturedAsync()
        {
            var games = await _gameRepository.GetFeaturedAsync();
            return games.Select(MapToDto);
        }

        /// <summary>
        /// Retorna os games de uma categoria específica.
        /// </summary>
        public async Task<IEnumerable<GameDto>> GetByCategoryAsync(int categoryId)
        {
            var games = await _gameRepository.GetByCategoryAsync(categoryId);
            return games.Select(MapToDto);
        }

        /// <summary>
        /// Cria um novo game a partir do DTO de criação.
        /// </summary>
        public async Task<GameDto> CreateAsync(CreateGameDto dto)
        {
            // Mapeia o DTO de criação para a entidade Game
            var game = new Game
            {
                Title = dto.Title,
                Description = dto.Description,
                ReleaseYear = dto.ReleaseYear,
                CoverImageUrl = dto.CoverImageUrl,
                CategoryId = dto.CategoryId,
                IsFeatured = dto.IsFeatured,
                CreatedAt = DateTime.Now
            };

            await _gameRepository.AddAsync(game);

            // Retorna o game criado como DTO
            return MapToDto(game);
        }

        /// <summary>
        /// Atualiza um game existente.
        /// </summary>
        public async Task<GameDto?> UpdateAsync(int id, UpdateGameDto dto)
        {
            var game = await _gameRepository.GetByIdAsync(id);
            if (game == null) return null;

            // Atualiza os campos do game com os dados do DTO
            game.Title = dto.Title;
            game.Description = dto.Description;
            game.ReleaseYear = dto.ReleaseYear;
            game.CoverImageUrl = dto.CoverImageUrl;
            game.CategoryId = dto.CategoryId;
            game.IsFeatured = dto.IsFeatured;

            await _gameRepository.UpdateAsync(game);
            return MapToDto(game);
        }

        /// <summary>
        /// Remove um game pelo Id.
        /// </summary>
        public async Task<bool> DeleteAsync(int id)
        {
            var game = await _gameRepository.GetByIdAsync(id);
            if (game == null) return false;

            await _gameRepository.DeleteAsync(id);
            return true;
        }

        /// <summary>
        /// Retorna o total de games.
        /// </summary>
        public async Task<int> CountAsync()
        {
            return await _gameRepository.CountAsync();
        }

        // =====================================================================
        // MÉTODO PRIVADO DE MAPEAMENTO
        // =====================================================================
        //  CONCEITO: Mapeamento Entidade  DTO
        // Este método converte uma entidade Game em um GameDto.
        // Ele é privado porque só é usado internamente pelo serviço.
        // =====================================================================
        private static GameDto MapToDto(Game game)
        {
            return new GameDto
            {
                Id = game.Id,
                Title = game.Title,
                Description = game.Description,
                ReleaseYear = game.ReleaseYear,
                CoverImageUrl = game.CoverImageUrl,
                CategoryId = game.CategoryId,
                CategoryName = game.Category?.Name ?? string.Empty,
                IsFeatured = game.IsFeatured,
                CreatedAt = game.CreatedAt
            };
        }
    }
}
