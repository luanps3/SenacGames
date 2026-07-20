// =============================================================================
// SenacGames.API - GamesController
// =============================================================================
//  CONCEITO IMPORTANTE: API Controller
// Um API Controller é responsável por receber requisições HTTP
// e retornar respostas em formato JSON.
//
// Diferença entre API Controller e MVC Controller:
// - API Controller: retorna DADOS (JSON) — [ApiController]
// - MVC Controller: retorna VIEWS (HTML) — Controller normal
//
// Endpoints REST deste controller:
// GET    /api/games        Lista todos os games
// GET    /api/games/{id}   Busca um game pelo Id
// POST   /api/games        Cria um novo game
// PUT    /api/games/{id}   Atualiza um game existente
// DELETE /api/games/{id}   Remove um game
// =============================================================================

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SenacGames.Application.DTOs;
using SenacGames.Application.Interfaces;

namespace SenacGames.API.Controllers
{
    /// <summary>
    /// Controller REST para operações com Games.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly IGameService _gameService;

        //  CONCEITO: O serviço é injetado automaticamente pelo .NET (DI)
        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }

        /// <summary>
        /// Retorna todos os games.
        /// GET /api/games
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameDto>>> GetAll()
        {
            var games = await _gameService.GetAllAsync();
            return Ok(games);
        }

        /// <summary>
        /// Busca um game específico pelo Id.
        /// GET /api/games/{id}
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<GameDto>> GetById(int id)
        {
            var game = await _gameService.GetByIdAsync(id);

            if (game == null)
                return NotFound(new { message = "Game não encontrado." });

            return Ok(game);
        }

        /// <summary>
        /// Cria um novo game.
        /// POST /api/games
        /// Requer autenticação (somente admin pode criar games).
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<GameDto>> Create([FromBody] CreateGameDto dto)
        {
            var game = await _gameService.CreateAsync(dto);

            // Retorna 201 Created com a URL do recurso criado
            return CreatedAtAction(nameof(GetById), new { id = game.Id }, game);
        }

        /// <summary>
        /// Atualiza um game existente.
        /// PUT /api/games/{id}
        /// </summary>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<GameDto>> Update(int id, [FromBody] UpdateGameDto dto)
        {
            var game = await _gameService.UpdateAsync(id, dto);

            if (game == null)
                return NotFound(new { message = "Game não encontrado." });

            return Ok(game);
        }

        /// <summary>
        /// Remove um game.
        /// DELETE /api/games/{id}
        /// </summary>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _gameService.DeleteAsync(id);

            if (!deleted)
                return NotFound(new { message = "Game não encontrado." });

            return NoContent(); // Retorna 204 No Content (sucesso sem corpo)
        }
    }
}
