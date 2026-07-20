// =============================================================================
// SenacGames.Application - ViewModels
// =============================================================================
//  CONCEITO IMPORTANTE: ViewModels
// Um ViewModel é um objeto criado especificamente para uma View (tela).
// Ele contém EXATAMENTE os dados que aquela tela precisa exibir.
//
// Diferença entre DTO e ViewModel:
// - DTO: transferência genérica de dados entre camadas
// - ViewModel: dados específicos para uma tela/view
// =============================================================================

using SenacGames.Application.DTOs;

namespace SenacGames.Application.ViewModels
{
    /// <summary>
    /// ViewModel da página inicial (Home).
    /// Contém os games em destaque e as categorias para exibição.
    /// </summary>
    public class HomeViewModel
    {
        public IEnumerable<GameDto> FeaturedGames { get; set; } = new List<GameDto>();
        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
        public IEnumerable<GameDto> RecentGames { get; set; } = new List<GameDto>();
    }

    /// <summary>
    /// ViewModel da página de detalhes de um game.
    /// </summary>
    public class GameDetailsViewModel
    {
        public GameDto Game { get; set; } = new GameDto();
        public IEnumerable<GameDto> RelatedGames { get; set; } = new List<GameDto>();
    }

    /// <summary>
    /// ViewModel do Dashboard administrativo.
    /// Contém as métricas resumidas do sistema.
    /// </summary>
    public class DashboardViewModel
    {
        public int TotalGames { get; set; }
        public int TotalCategories { get; set; }
        public int FeaturedGames { get; set; }
        public IEnumerable<GameDto> RecentGames { get; set; } = new List<GameDto>();
    }

    /// <summary>
    /// ViewModel para o formulário de criação/edição de games.
    /// Inclui a lista de categorias para o select/dropdown.
    /// </summary>
    public class GameFormViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public bool IsFeatured { get; set; }

        /// <summary>
        /// Lista de categorias disponíveis para o dropdown do formulário.
        /// </summary>
        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
    }

    /// <summary>
    /// ViewModel para a lista de games com filtro por categoria.
    /// </summary>
    public class GameListViewModel
    {
        public IEnumerable<GameDto> Games { get; set; } = new List<GameDto>();
        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
        public int? SelectedCategoryId { get; set; }
    }
}
