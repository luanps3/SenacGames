// =============================================================================
// SenacGames.Desktop - UserControls/DashboardUserControl.cs
// =============================================================================
//  CONCEITO: UserControl de Dashboard
//
// O Dashboard exibe uma visão geral do sistema:
//   - Cards com métricas (total de games, categorias, usuários)
//   - Lista dos últimos games cadastrados
//   - Saudação personalizada para o usuário logado
//
// Como os dados chegam?
//   DashboardUserControl  GamesApiService  GET /api/games
//   DashboardUserControl  CategoriasApiService  GET /api/categories
// =============================================================================

using SenacGames.Desktop.Helpers;
using SenacGames.Desktop.Services;
using SenacGames.Desktop.Themes;

namespace SenacGames.Desktop.UserControls
{
    public partial class DashboardUserControl : UserControl
    {

        private GamesApiService _gameService = null;
        private CategoriasApiService _categoriasService = null;

        //=====================================================
        // CONSTRUTOR
        //=====================================================
        public DashboardUserControl()
        {
            InitializeComponent();
        }

      
        private async void DashboardUserControl_Load(object sender, EventArgs e)
        {
            //Guard: não executa em tempo de design
            if(DesignMode) return;

            //Inicializa serviços
            _gameService = new GamesApiService();
            _categoriasService = new CategoriasApiService();

            //Preenche dados dinâmicos da sessão
            lblTitulo.Text = $"Olá, {SessionManager.Instance.GetDisplayName()!} 👋";
            lblSubtitulo.Text = $"Bem-vindo ao SenacGames Desktop - {DateTime.Now:dddd, dd 'de' MMM 'de' yyyy}";

            //Aplica estilo no DataGridView(tabela)
            SenacTheme.AplicarEstiloGrid(gridUltimosGames);

            await CarregarDadosAsync();

        }

        private async Task CarregarDadosAsync()
        {
            SetCarregando(true);

            try
            {
                var tarefaGames = _gameService.GetAllAsync();
                var tarefaCategorias = _categoriasService.GetAllAsync();
                await Task.WhenAll(tarefaGames, tarefaCategorias);

                var games = tarefaGames.Result;
                var categorias = tarefaCategorias.Result;

                //Atualiza os dados do card
                AtualizarNumeroCard(cardGames, games.Count.ToString());
                AtualizarNumeroCard(cardCategorias, categorias.Count.ToString());

                //Popula o DataGridView(tabela) com os últimos 10 games.
                gridUltimosGames.Rows.Clear();
                foreach (var game in games.OrderByDescending(x => x.CreatedAt).Take(10))
                {
                    gridUltimosGames.Rows.Add(
                        game.Id,
                        game.Title,
                        game.CategoryName,
                        game.RealeaseYear,
                        game.IsFeatured,
                        game.CreatedAt.ToString("dd/MM/yyyy HH:mm")
                        );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                $"Erro ao carregar dados: {ex.Message}",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            finally
            {
                SetCarregando(false);
            }

        }

        private void AtualizarNumeroCard(Guna.UI2.WinForms.Guna2Panel card, string numero)
        {
            //'card.Controls' retorna a coleção de controles(elementos) filhos do panel
            //'OfType<Label>()' filtra apenas os controles do tipo 'Label'
            //'FirstOrDefault(...) pegao primeiro Label que satisfaz a condição ou null se nenhum. 
            //A condição 'l.Tag?.ToString() == "numero"' verifica o tag do Label (pode ser null) e compara com a string 
            var lblNumero = card.Controls.OfType<Label>().FirstOrDefault(l => l.Tag?.ToString() == "numero");

            if (lblNumero != null)
            {
                lblNumero.Text = numero;
            }
        }


        private void SetCarregando(bool carregando)
        {
            lblCarregando.Visible = carregando;
            cardGames.Visible = !carregando;
            cardCategorias.Visible = !carregando;
            lblUltimosGames.Visible = !carregando;
            gridUltimosGames.Visible = !carregando;
        }

    }
}
