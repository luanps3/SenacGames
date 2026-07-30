using SenacGames.Desktop.DTOs;
using SenacGames.Desktop.Helpers;
using SenacGames.Desktop.Services;
using SenacGames.Desktop.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Core;

namespace SenacGames.Desktop.UserControls
{
    public partial class GamesUserControl : UserControl
    {

        //=================================================
        // SERVIÇOS (Inicilizados no Load)
        //=================================================
        private GamesApiService _gameService = null;
        private CategoriasApiService _categoriasService = null;

        //=================================================
        // DADOS
        //=================================================
        private List<GameResponseDto> _todosGames = new();
        private List<CategoriaResponseDto> _categorias = new();

        //=================================================
        // CONSTRUTOR
        //=================================================
        public GamesUserControl()
        {
            InitializeComponent();
        }

        private async void GamesUserControl_Load(object sender, EventArgs e)
        {
            //Guard: não executa em tempo de Design
            if (DesignMode) return;

            //Inicializa serviços
            _gameService = new GamesApiService();
            _categoriasService = new CategoriasApiService();

            //Aplica o tema no DataGridView
            SenacTheme.AplicarEstiloGrid(gridGames);

            //Configurar permissões
            ConfigurarPermissoes();

            //Reservado para CarregarDados
            await CarregarDadosAsync();
        }

        private void ConfigurarPermissoes()
        {
            bool isAdmin = SessionManager.Instance.IsAdmin;
            btnNova.Visible = isAdmin;
            btnEditar.Visible = isAdmin;
            btnExcluir.Visible = isAdmin;
        }

        private async Task CarregarDadosAsync()
        {
            gridGames.Rows.Clear();

            try
            {
                var tarefaGames = _gameService.GetAllAsync();
                var tarefaCategorias = _categoriasService.GetAllAsync();
                await Task.WhenAll(tarefaGames, tarefaCategorias);

                _todosGames = tarefaGames.Result;
                _categorias = tarefaCategorias.Result;

                PopularGrid(_todosGames);

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao carregar games: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void PopularGrid(List<GameResponseDto> games)
        {
            gridGames.Rows.Clear();
            foreach (var g in games)
            {
                gridGames.Rows.Add(
                    g.Id,
                    g.Title,
                    g.CategoryName,
                    g.ReleaseYear,
                    g.IsFeatured,
                    g.CreatedAt.ToString("dd/MM/yyyy HH:mm"));

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e) => FiltrarGames();
       

        private void FiltrarGames()
        {
            var termo = txtPesquisa.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(termo))
            {
                PopularGrid(_todosGames);
                return;
            }

            var filtrados = _todosGames
                .Where(g => g.Title.Contains(termo, StringComparison.OrdinalIgnoreCase) 
                || g.CategoryName.Contains(termo, StringComparison.OrdinalIgnoreCase))
                .ToList();

            PopularGrid(filtrados);
        }

    }
}
