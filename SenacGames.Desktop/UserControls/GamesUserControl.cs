using SenacGames.Desktop.DTOs;
using SenacGames.Desktop.Forms;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e) => FiltrarGames();

        private async void btnNova_Click(object sender, EventArgs e)
        {
            using var form = new GameFormDialog(_categorias, null);
            if (form.ShowDialog() == DialogResult.OK && form.GameDto != null)
            {
                var (success, _, error) = await _gameService.CreateAsync(form.GameDto);
                if (success)
                {
                    MessageBox.Show("✅ Game criado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    await CarregarDadosAsync();
                }
                else
                {
                    MessageBox.Show($"❌ {error}",
                      "Erro",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                }
            }

        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var game = ObterGameSelecionado();
            if (game == null)
            {
                MessageBox.Show($"Selecione um game para editar.",
                      "Aviso",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
                return;
            }

            using var form = new GameFormDialog(_categorias, game);
            if (form.ShowDialog() == DialogResult.OK && form.UpdateDto != null)
            {
                var (success, _, error) = await _gameService.UpdateAsync(game.Id, form.UpdateDto);
                if (success)
                {
                    MessageBox.Show("✅ Game atualizado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    await CarregarDadosAsync();
                }
                else
                {
                    MessageBox.Show($"❌ {error}",
                      "Erro",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                }
            }
        }

        private GameResponseDto? ObterGameSelecionado()
        {
            if (gridGames.SelectedRows.Count == 0) return null;
            var row = gridGames.SelectedRows[0];
            var id = Convert.ToInt32(row.Cells["colId"].Value);
            return _todosGames.FirstOrDefault(g => g.Id == id);
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            var game = ObterGameSelecionado();
            if (game == null)
            {
                MessageBox.Show("Selecione um game para excluir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var conf = MessageBox.Show(
                $"Tem certeza que deseja excluir o game:\n\"{game.Title}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (conf != DialogResult.Yes) return;

            var (success, error) = await _gameService.DeleteAsync(game.Id);
            if (success)
            {
                MessageBox.Show("✅ Game excluído com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CarregarDadosAsync();
            }
            else
            {
                MessageBox.Show($"❌ {error}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAtualizar_Click(object sender, EventArgs e) => await CarregarDadosAsync();

    }
}
