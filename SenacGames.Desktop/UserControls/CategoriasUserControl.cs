// =============================================================================
// SenacGames.Desktop - UserControls/CategoriasUserControl.cs
// =============================================================================
//  CONCEITO: UserControl de CRUD de Categorias
//
// Permite gerenciar categorias de games:
//   GET    /api/categories         Listar
//   POST   /api/categories         Criar (Admin)
//   PUT    /api/categories/{id}    Editar (Admin)
//   DELETE /api/categories/{id}    Excluir (Admin)
//
// NOTA: Este módulo é exclusivo para Administradores.
// =============================================================================

using SenacGames.Desktop.DTOs;
using SenacGames.Desktop.Services;
using SenacGames.Desktop.Themes;

namespace SenacGames.Desktop.UserControls
{
    /// <summary>
    /// Módulo de gerenciamento de Categorias.
    /// CRUD completo via API REST (somente Admin).
    /// </summary>
    public partial class CategoriasUserControl : UserControl
    {
        // =====================================================================
        // SERVIÇOS E DADOS
        // =====================================================================
        private CategoriasApiService _categoriasService = null!;
        private List<CategoriaResponseDto> _categorias = new();

        // Estado do formulário: null = modo listagem, int = ID sendo editado
        private int? _editandoId = null;

        // =====================================================================
        // CONSTRUTOR
        // =====================================================================

        /// <summary>
        /// Construtor padrão sem parâmetros — compatível com o Designer.
        /// </summary>
        public CategoriasUserControl()
        {
            InitializeComponent();
        }

        // =====================================================================
        // EVENTO LOAD
        // =====================================================================

        private async void CategoriasUserControl_Load(object sender, EventArgs e)
        {
            // Guard: não executa em tempo de design
            if (DesignMode) return;

            // Inicializa serviço
            _categoriasService = new CategoriasApiService();

            // Aplica estilo ao grid
            SenacTheme.AplicarEstiloGrid(gridCategorias);

            // Carrega dados
            await CarregarDadosAsync();
        }

        // =====================================================================
        // DADOS
        // =====================================================================
        private async Task CarregarDadosAsync()
        {
            gridCategorias.Rows.Clear();
            try
            {
                _categorias = await _categoriasService.GetAllAsync();
                foreach (var c in _categorias)
                    gridCategorias.Rows.Add(c.Id, c.Name, c.GameCount);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // =====================================================================
        // FORMULÁRIO
        // =====================================================================
        private void MostrarFormulario(CategoriaResponseDto? categoria)
        {
            _editandoId = categoria?.Id;
            txtNome.Text = categoria?.Name ?? string.Empty;
            lblFormTitulo.Text = categoria == null ? "Nova Categoria" : "Editar Categoria";
            pnlForm.Visible = true;
            txtNome.Focus();
        }

        private void OcultarFormulario()
        {
            pnlForm.Visible = false;
            _editandoId = null;
            txtNome.Clear();
        }

        // =====================================================================
        // EVENTOS DOS BOTÕES
        // =====================================================================

        private void BtnNova_Click(object? sender, EventArgs e)
            => MostrarFormulario(null);

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            var cat = ObterCategoriaSelecionada();
            if (cat == null)
            {
                MessageBox.Show("Selecione uma categoria para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MostrarFormulario(cat);
        }

        private async void BtnExcluir_Click(object? sender, EventArgs e)
        {
            var cat = ObterCategoriaSelecionada();
            if (cat == null)
            {
                MessageBox.Show("Selecione uma categoria para excluir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cat.GameCount > 0)
            {
                MessageBox.Show(
                    $"A categoria \"{cat.Name}\" possui {cat.GameCount} game(s) vinculado(s).\nRemova os games antes de excluir.",
                    "Não é possível excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var conf = MessageBox.Show(
                $"Excluir a categoria \"{cat.Name}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (conf != DialogResult.Yes) return;

            var (success, error) = await _categoriasService.DeleteAsync(cat.Id);
            if (success)
            {
                MessageBox.Show("✅ Categoria excluída!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CarregarDadosAsync();
            }
            else
            {
                MessageBox.Show($"❌ {error}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnAtualizar_Click(object? sender, EventArgs e)
            => await CarregarDadosAsync();

        private async void BtnSalvar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome da categoria.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success;
            string error;

            if (_editandoId == null)
            {
                var dto = new CreateCategoriaDto { Name = txtNome.Text.Trim() };
                var result = await _categoriasService.CreateAsync(dto);
                success = result.Success;
                error = result.ErrorMessage;
            }
            else
            {
                var dto = new UpdateCategoriaDto { Name = txtNome.Text.Trim() };
                var result = await _categoriasService.UpdateAsync(_editandoId.Value, dto);
                success = result.Success;
                error = result.ErrorMessage;
            }

            if (success)
            {
                MessageBox.Show("✅ Salvo com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcultarFormulario();
                await CarregarDadosAsync();
            }
            else
            {
                MessageBox.Show($"❌ {error}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object? sender, EventArgs e)
            => OcultarFormulario();

        // =====================================================================
        // AUXILIARES
        // =====================================================================
        private CategoriaResponseDto? ObterCategoriaSelecionada()
        {
            if (gridCategorias.SelectedRows.Count == 0) return null;
            var id = Convert.ToInt32(gridCategorias.SelectedRows[0].Cells["colId"].Value);
            return _categorias.FirstOrDefault(c => c.Id == id);
        }

        private void btnNova_Click_1(object sender, EventArgs e)
         => MostrarFormulario(null);

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            var cat = ObterCategoriaSelecionada();
            if (cat == null)
            {
                MessageBox.Show("Selecione uma categoria para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MostrarFormulario(cat);
        }

        private async void btnExcluir_Click_1(object sender, EventArgs e)
        {
            var cat = ObterCategoriaSelecionada();
            if (cat == null)
            {
                MessageBox.Show("Selecione uma categoria para excluir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cat.GameCount > 0)
            {
                MessageBox.Show(
                    $"A categoria \"{cat.Name}\" possui {cat.GameCount} game(s) vinculado(s).\nRemova os games antes de excluir.",
                    "Não é possível excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var conf = MessageBox.Show(
                $"Excluir a categoria \"{cat.Name}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (conf != DialogResult.Yes) return;

            var (success, error) = await _categoriasService.DeleteAsync(cat.Id);
            if (success)
            {
                MessageBox.Show("✅ Categoria excluída!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private async void btnAtualizar_Click_1(object sender, EventArgs e) => await CarregarDadosAsync();

        private async void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome da categoria", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success;
            string error;

            if (_editandoId == null)
            {
                var dto = new CreateCategoriaDto { Name = txtNome.Text.Trim() };
                var result = await _categoriasService.CreateAsync(dto);
                success = result.Success;
                error = result.ErrorMessage;
            }
            else
            {
                var dto = new UpdateCategoriaDto { Name = txtNome.Text.Trim() };
                var result = await _categoriasService.UpdateAsync(_editandoId.Value, dto);
                success = result.Success;
                error = result.ErrorMessage;
            }

            if (success)
            {
                MessageBox.Show("✅ Salvo com sucesso!", "Sucesso",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcultarFormulario();
                await CarregarDadosAsync();
            }


        }

        private void btnCancelar_Click_1(object sender, EventArgs e) => OcultarFormulario();

    }
}