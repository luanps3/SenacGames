// =============================================================================
// SenacGames.Desktop - Services/GamesApiService.cs
// =============================================================================
//  CONCEITO: Service de Games
//
// Realiza todas as operações CRUD de games via API REST:
//   GET    /api/games         Listar todos os games
//   GET    /api/games/{id}    Buscar game por ID
//   POST   /api/games         Criar game (requer Admin)
//   PUT    /api/games/{id}    Atualizar game (requer Admin)
//   DELETE /api/games/{id}    Excluir game (requer Admin)
//
// IMPORTANTE: As operações de escrita (POST, PUT, DELETE) requerem
// que o usuário esteja autenticado como Admin.
// A autorização é verificada pela própria API, não pelo Desktop.
// O Desktop não precisa verificar roles para fazer a chamada —
// mas deve controlar a INTERFACE (exibir/ocultar botões) baseado no perfil.
// =============================================================================

using SenacGames.Desktop.DTOs;
using SenacGames.Desktop.Helpers;

namespace SenacGames.Desktop.Services
{
    public class GamesApiService
    {
        private readonly HttpClientHelper _http;

        //Construtor - Inicializa junto com o código quando o mesmo é chamado.
        public GamesApiService()
        {
            _http = HttpClientHelper.Instance;
        }

        ///<summary>
        /// Lista todas os ganes via GET /api/games
        /// </summary>
        public async Task<List<GameResponseDto>> GetAllAsync()
        {
            try
            {
                var games = await _http.GetAsync<List<GameResponseDto>>("/api/games");
                return games ?? new List<GameResponseDto>();
            }
            catch
            {
                return new List<GameResponseDto>();
            }
        }

        /// <summary>
        /// Busca um game específico por ID via GET /api/games/{id} 
        /// </summary>
        public async Task<GameResponseDto> GetByIdAsync(int id)
        {
            return await _http.GetAsync<GameResponseDto>($"/api/games/{id}");
        }

        /// <summary>
        /// Cria um novo game via POST /api/games.
        /// Requer perfil Admin (verificado pela API).
        /// </summary>
        /// <param name="dto">Dados do game a ser criado</param>
        /// <returns>Game criado ou null em caso de erro</returns>
        public async Task<(bool Success, GameResponseDto? Game, string ErrorMessage)>
            CreateAsync(CreateGameDto dto)
        {
            return await _http.PostAsync<GameResponseDto>("/api/games", dto);
        }

        /// <summary>
        /// Atualiza um game existente via PUT /api/games/{id}.
        /// Requer perfil Admin (verificado pela API).
        /// </summary>
        public async Task<(bool Success, GameResponseDto? Game, string ErrorMessage)>
            UpdateAsync(int id, UpdateGameDto dto)
        {
            return await _http.PutAsync<GameResponseDto>($"/api/games/{id}", dto);
        }

        /// <summary>
        /// Exclui um game via DELETE /api/games/{id}.
        /// Requer perfil Admin (verificado pela API).
        /// </summary>
        public async Task<(bool Success, string ErrorMessage)> DeleteAsync(int id)
        {
            return await _http.DeleteAsync($"/api/games/{id}");
        }
    }

   
    
}
