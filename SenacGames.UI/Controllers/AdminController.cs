// =============================================================================
// SenacGames.UI - AdminController
// =============================================================================
//  CONCEITO: [Authorize] e Roles
// O atributo [Authorize(Roles = "Admin")] protege este controller.
// Apenas usuários autenticados COM a role "Admin" podem acessar.
// Se um usuário não autenticado tentar acessar, será redirecionado ao Login.
// Se não tiver a role Admin, será redirecionado ao AccessDenied.
// =============================================================================

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SenacGames.Application.DTOs;
using SenacGames.Application.Interfaces;
using SenacGames.Application.ViewModels;

namespace SenacGames.UI.Controllers
{
    /// <summary>
    /// Controller administrativo — Dashboard, CRUD de Games e Categorias.
    /// Requer autenticação e role "Admin".
    /// </summary>
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IGameService _gameService;
        private readonly ICategoryService _categoryService;

        public AdminController(IGameService gameService, ICategoryService categoryService)
        {
            _gameService = gameService;
            _categoryService = categoryService;
        }

        // =====================================================================
        // DASHBOARD
        // =====================================================================

        /// <summary>
        /// Dashboard administrativo — métricas do sistema.
        /// URL: /Admin ou /Admin/Index
        /// </summary>
        public async Task<IActionResult> Index()
        {
            ViewData["ActiveMenu"] = "Dashboard";
            ViewData["Title"] = "Dashboard";
            ViewData["Subtitle"] = "Resumo do sistema SenacGames";

            var viewModel = new DashboardViewModel
            {
                TotalGames = await _gameService.CountAsync(),
                TotalCategories = await _categoryService.CountAsync(),
                FeaturedGames = (await _gameService.GetFeaturedAsync()).Count(),
                RecentGames = (await _gameService.GetAllAsync()).Take(5)
            };

            return View(viewModel);
        }

        // =====================================================================
        // CRUD DE GAMES
        // =====================================================================

        /// <summary>
        /// Lista todos os games para gerenciamento.
        /// URL: /Admin/Games
        /// </summary>
        public async Task<IActionResult> Games()
        {
            ViewData["ActiveMenu"] = "Games";
            ViewData["Title"] = "Gerenciar Games";
            ViewData["Subtitle"] = "Cadastre, edite e exclua games do catálogo";

            var games = await _gameService.GetAllAsync();
            return View(games);
        }

        /// <summary>
        /// Formulário para criar um novo game.
        /// GET /Admin/CreateGame
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> CreateGame()
        {
            ViewData["ActiveMenu"] = "Games";
            ViewData["Title"] = "Cadastrar Novo Game";

            var categories = await _categoryService.GetAllAsync();
            var viewModel = new GameFormViewModel
            {
                Categories = categories,
                ReleaseYear = DateTime.Now.Year
            };

            return View(viewModel);
        }

        /// <summary>
        /// Processa a criação de um novo game.
        /// POST /Admin/CreateGame
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateGame(GameFormViewModel viewModel)
        {
            var dto = new CreateGameDto
            {
                Title = viewModel.Title,
                Description = viewModel.Description,
                ReleaseYear = viewModel.ReleaseYear,
                CoverImageUrl = viewModel.CoverImageUrl,
                CategoryId = viewModel.CategoryId,
                IsFeatured = viewModel.IsFeatured
            };

            await _gameService.CreateAsync(dto);
            TempData["Success"] = "Game cadastrado com sucesso!";
            return RedirectToAction(nameof(Games));
        }

        /// <summary>
        /// Formulário para editar um game existente.
        /// GET /Admin/EditGame/5
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> EditGame(int id)
        {
            ViewData["ActiveMenu"] = "Games";
            ViewData["Title"] = "Editar Game";

            var game = await _gameService.GetByIdAsync(id);
            if (game == null) return NotFound();

            var categories = await _categoryService.GetAllAsync();
            var viewModel = new GameFormViewModel
            {
                Id = game.Id,
                Title = game.Title,
                Description = game.Description,
                ReleaseYear = game.ReleaseYear,
                CoverImageUrl = game.CoverImageUrl,
                CategoryId = game.CategoryId,
                IsFeatured = game.IsFeatured,
                Categories = categories
            };

            return View(viewModel);
        }

        /// <summary>
        /// Processa a edição de um game.
        /// POST /Admin/EditGame/5
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditGame(int id, GameFormViewModel viewModel)
        {
            var dto = new UpdateGameDto
            {
                Title = viewModel.Title,
                Description = viewModel.Description,
                ReleaseYear = viewModel.ReleaseYear,
                CoverImageUrl = viewModel.CoverImageUrl,
                CategoryId = viewModel.CategoryId,
                IsFeatured = viewModel.IsFeatured
            };

            var result = await _gameService.UpdateAsync(id, dto);

            if (result == null)
                return NotFound();

            TempData["Success"] = "Game atualizado com sucesso!";
            return RedirectToAction(nameof(Games));
        }

        /// <summary>
        /// Confirmação de exclusão de game.
        /// GET /Admin/DeleteGame/5
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> DeleteGame(int id)
        {
            ViewData["ActiveMenu"] = "Games";
            ViewData["Title"] = "Excluir Game";

            var game = await _gameService.GetByIdAsync(id);
            if (game == null) return NotFound();

            return View(game);
        }

        /// <summary>
        /// Processa a exclusão de um game.
        /// POST /Admin/DeleteGameConfirmed/5
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteGameConfirmed(int id)
        {
            await _gameService.DeleteAsync(id);
            TempData["Success"] = "Game excluído com sucesso!";
            return RedirectToAction(nameof(Games));
        }

        // =====================================================================
        // CRUD DE CATEGORIAS
        // =====================================================================

        /// <summary>
        /// Lista todas as categorias para gerenciamento.
        /// URL: /Admin/Categories
        /// </summary>
        public async Task<IActionResult> Categories()
        {
            ViewData["ActiveMenu"] = "Categories";
            ViewData["Title"] = "Gerenciar Categorias";
            ViewData["Subtitle"] = "Cadastre, edite e exclua categorias de games";

            var categories = await _categoryService.GetAllAsync();
            return View(categories);
        }

        /// <summary>
        /// Formulário para criar uma nova categoria.
        /// GET /Admin/CreateCategory
        /// </summary>
        [HttpGet]
        public IActionResult CreateCategory()
        {
            ViewData["ActiveMenu"] = "Categories";
            ViewData["Title"] = "Nova Categoria";
            return View();
        }

        /// <summary>
        /// Processa a criação de uma nova categoria.
        /// POST /Admin/CreateCategory
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto dto)
        {
            await _categoryService.CreateAsync(dto);
            TempData["Success"] = "Categoria cadastrada com sucesso!";
            return RedirectToAction(nameof(Categories));
        }

        /// <summary>
        /// Formulário para editar uma categoria.
        /// GET /Admin/EditCategory/5
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> EditCategory(int id)
        {
            ViewData["ActiveMenu"] = "Categories";
            ViewData["Title"] = "Editar Categoria";

            var category = await _categoryService.GetByIdAsync(id);
            if (category == null) return NotFound();

            return View(category);
        }

        /// <summary>
        /// Processa a edição de uma categoria.
        /// POST /Admin/EditCategory/5
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCategory(int id, UpdateCategoryDto dto)
        {
            var result = await _categoryService.UpdateAsync(id, dto);
            if (result == null) return NotFound();

            TempData["Success"] = "Categoria atualizada com sucesso!";
            return RedirectToAction(nameof(Categories));
        }

        /// <summary>
        /// Confirmação de exclusão de categoria.
        /// GET /Admin/DeleteCategory/5
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            ViewData["ActiveMenu"] = "Categories";
            ViewData["Title"] = "Excluir Categoria";

            var category = await _categoryService.GetByIdAsync(id);
            if (category == null) return NotFound();

            return View(category);
        }

        /// <summary>
        /// Processa a exclusão de uma categoria.
        /// POST /Admin/DeleteCategoryConfirmed/5
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCategoryConfirmed(int id)
        {
            var deleted = await _categoryService.DeleteAsync(id);
            if (!deleted)
            {
                TempData["Error"] = "Não é possível excluir uma categoria que possui games associados.";
                return RedirectToAction(nameof(Categories));
            }

            TempData["Success"] = "Categoria excluída com sucesso!";
            return RedirectToAction(nameof(Categories));
        }
    }
}
