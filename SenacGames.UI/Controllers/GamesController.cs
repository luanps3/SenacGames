// =============================================================================
// SenacGames.UI - GamesController (Área Pública)
// =============================================================================
// Controller para as páginas públicas de games.
// Permite visualizar o catálogo e detalhes dos games SEM autenticação.
// =============================================================================

using Microsoft.AspNetCore.Mvc;
using SenacGames.Application.Interfaces;
using SenacGames.Application.ViewModels;

namespace SenacGames.UI.Controllers
{
    /// <summary>
    /// Controller público de Games — catálogo e detalhes.
    /// NÃO requer autenticação.
    /// </summary>
    public class GamesController : Controller
    {
        private readonly IGameService _gameService;
        private readonly ICategoryService _categoryService;

        public GamesController(IGameService gameService, ICategoryService categoryService)
        {
            _gameService = gameService;
            _categoryService = categoryService;
        }

        /// <summary>
        /// Catálogo de games com filtro por categoria.
        /// URL: /Games ou /Games/Index
        /// </summary>
        public async Task<IActionResult> Index(int? categoryId)
        {
            var viewModel = new GameListViewModel
            {
                Categories = await _categoryService.GetAllAsync(),
                SelectedCategoryId = categoryId
            };

            // Se uma categoria foi selecionada, filtra os games
            if (categoryId.HasValue)
            {
                viewModel.Games = await _gameService.GetByCategoryAsync(categoryId.Value);
            }
            else
            {
                viewModel.Games = await _gameService.GetAllAsync();
            }

            return View(viewModel);
        }

        /// <summary>
        /// Detalhes de um game específico.
        /// URL: /Games/Details/5
        /// </summary>
        public async Task<IActionResult> Details(int id)
        {
            var game = await _gameService.GetByIdAsync(id);

            if (game == null)
                return NotFound();

            // Busca games relacionados (mesma categoria)
            var relatedGames = await _gameService.GetByCategoryAsync(game.CategoryId);

            var viewModel = new GameDetailsViewModel
            {
                Game = game,
                RelatedGames = relatedGames.Where(g => g.Id != game.Id).Take(4)
            };

            return View(viewModel);
        }
    }
}
