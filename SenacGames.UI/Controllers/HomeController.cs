// =============================================================================
// SenacGames.UI - HomeController
// =============================================================================
//  CONCEITO: Controller MVC
// Um Controller recebe requisições HTTP e retorna Views (páginas HTML).
// Cada método público (Action) corresponde a uma URL.
// Exemplo: HomeController.Index()  URL: /Home/Index ou /
// =============================================================================

using Microsoft.AspNetCore.Mvc;
using SenacGames.Application.Interfaces;
using SenacGames.Application.ViewModels;

namespace SenacGames.UI.Controllers
{
    /// <summary>
    /// Controller da página inicial (Home).
    /// Área PÚBLICA — qualquer usuário pode acessar.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly IGameService _gameService;
        private readonly ICategoryService _categoryService;

        //  CONCEITO: Dependency Injection no Controller
        // Os serviços são injetados automaticamente pelo .NET
        public HomeController(IGameService gameService, ICategoryService categoryService)
        {
            _gameService = gameService;
            _categoryService = categoryService;
        }

        /// <summary>
        /// Página inicial — exibe games em destaque e categorias.
        /// URL: / ou /Home/Index
        /// </summary>
        public async Task<IActionResult> Index()
        {
            // Monta o ViewModel com os dados que a View precisa
            var viewModel = new HomeViewModel
            {
                FeaturedGames = await _gameService.GetFeaturedAsync(),
                Categories = await _categoryService.GetAllAsync(),
                RecentGames = await _gameService.GetAllAsync()
            };

            return View(viewModel);
        }
    }
}
