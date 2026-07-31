// =============================================================================
// SenacGames.Desktop - Forms/GameFormDialog.cs
// =============================================================================
//  CONCEITO: Dialog de Formulário de Game
//
// Um Dialog é um formulário auxiliar que:
//   - Abre SOBRE o formulário pai (ShowDialog)
//   - Bloqueia a interação com o pai enquanto está aberto
//   - Retorna um resultado (OK ou Cancel)
//
// Usado para: criar e editar games.
// Recebe categorias já carregadas para evitar nova chamada à API.
// =============================================================================

using SenacGames.Desktop.DTOs;
using SenacGames.Desktop.Themes;

namespace SenacGames.Desktop.Forms
{
    /// <summary>
    /// Formulário de criação/edição de Game.
    /// Retorna CreateGameDto (novo) ou UpdateGameDto (edição).
    /// </summary>
    public partial class GameFormDialog : Form
    {
        // =====================================================================
        // PROPRIEDADES DE SAÍDA
        // =====================================================================

        /// <summary>DTO preenchido quando no modo de criação (OK)</summary>
        public CreateGameDto? GameDto { get; private set; }

        /// <summary>DTO preenchido quando no modo de edição (OK)</summary>
        public UpdateGameDto? UpdateDto { get; private set; }

        // =====================================================================
        // CAMPOS PRIVADOS
        // =====================================================================
        private List<CategoriaResponseDto> _categorias = new();
        private GameResponseDto? _gameExistente;

        // =====================================================================
        // CONSTRUTORES
        // =====================================================================

        /// <summary>
        /// Construtor padrão sem parâmetros — necessário para o Designer.
        /// Use o construtor com parâmetros em produção.
        /// </summary>
        public GameFormDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Construtor de produção com categorias e game opcional.
        /// </summary>
        /// <param name="categorias">Lista de categorias para o ComboBox</param>
        /// <param name="game">null para criação, game existente para edição</param>
        public GameFormDialog(List<CategoriaResponseDto> categorias, GameResponseDto? game)
        {
            _categorias = categorias;
            _gameExistente = game;
            InitializeComponent();
        }



        // =====================================================================
        // EVENTO LOAD
        // =====================================================================

        private void GameFormDialog_Load(object sender, EventArgs e)
        {
            //Guard
            if (DesignMode) return;

            // Configura título baseado no modo (criação/edição)
            this.Text = _gameExistente == null ? "Novo Game" : "Editar Game";
            lblTituloForm.Text = _gameExistente == null ? "➕ Novo Game" : "✏️ Editar Game";

            //Popula o ComboBox de categorias
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Selecione uma categoria...");
            foreach (var cat in _categorias)
                cmbCategoria.Items.Add(cat.Name);
            cmbCategoria.SelectedIndex = 0;

            //Preenche campos se estiver no modo edição
            PreencherCampos();

        }

        // =====================================================================
        // PREENCHIMENTO (MODO EDIÇÃO)
        // =====================================================================

        private void PreencherCampos()
        {
            if (_gameExistente == null) return;

            txtTitulo.Text = _gameExistente.Title;
            txtDescricao.Text = _gameExistente.Description;
            txtAno.Text = _gameExistente.ReleaseYear.ToString();
            txtCoverUrl.Text = _gameExistente.CoverImageUrl;
            chkDestaque.Checked = _gameExistente.IsFeatured;

            var idx = _categorias.FindIndex(c => c.Id == _gameExistente.CategoryId);
            if (idx >= 0) cmbCategoria.SelectedIndex = idx + 1;

        }





        // =====================================================================
        // SALVAR
        // =====================================================================
        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show(
                    "Informe o título do game.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAno.Text, out int ano) || ano < 1970 || ano > DateTime.Now.Year + 2)
            {
                MessageBox.Show(
                 "Informe um ano válido.",
                 "Validação",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategoria.SelectedIndex <= 0)
            {
                MessageBox.Show(
                 "Selecione uma categoria",
                 "Validação",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                return;
            }

            var categoriaIdx = cmbCategoria.SelectedIndex - 1;
            var categoriaId = _categorias[categoriaIdx].Id;

            if (_gameExistente == null)
            {
                GameDto = new CreateGameDto
                {
                    Title = txtTitulo.Text.Trim(),
                    Description = txtDescricao.Text.Trim(),
                    ReleaseYear = ano,
                    CoverImageUrl = txtCoverUrl.Text.Trim(),
                    CategoryId = categoriaId,
                    IsFeatured = chkDestaque.Checked
                };
            }
            else
            {
                UpdateDto = new UpdateGameDto
                {
                    Title = txtTitulo.Text.Trim(),
                    Description = txtDescricao.Text.Trim(),
                    ReleaseYear = ano,
                    CoverImageUrl = txtCoverUrl.Text.Trim(),
                    CategoryId = categoriaId,
                    IsFeatured = chkDestaque.Checked
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
