// =============================================================================
// SenacGames.Desktop - UserControls/UsuariosUserControl.cs
// =============================================================================

using SenacGames.Desktop.DTOs;
using SenacGames.Desktop.Forms;
using SenacGames.Desktop.Helpers;
using SenacGames.Desktop.Services;
using SenacGames.Desktop.Themes;

namespace SenacGames.Desktop.UserControls
{
    public partial class UsuariosUserControl : UserControl
    {
        private UsuariosApiService _usuariosService = null!;
        private List<UsuarioResponseDto> _todosUsuarios = new();
        private List<string> _perfis = new();

        public UsuariosUserControl()
        {
            InitializeComponent();
        }

        private async void UsuariosUserControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            _usuariosService = new UsuariosApiService();
            SenacTheme.AplicarEstiloGrid(gridUsuarios);
            ConfigurarPermissoes();

            await CarregarDadosAsync();
        }

        private void ConfigurarPermissoes()
        {
            bool isAdmin = SessionManager.Instance.IsAdmin;
            btnNovo.Visible = isAdmin;
            btnEditar.Visible = isAdmin;
            btnExcluir.Visible = isAdmin;
        }

        private async Task CarregarDadosAsync()
        {
            gridUsuarios.Rows.Clear();

            try
            {
                var tarefaUsuarios = _usuariosService.GetAllAsync();
                var tarefaPerfis = _usuariosService.GetPerfisAsync();
                await Task.WhenAll(tarefaUsuarios, tarefaPerfis);

                _todosUsuarios = tarefaUsuarios.Result;
                _perfis = tarefaPerfis.Result;

                PopularGrid(_todosUsuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar usuários: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PopularGrid(List<UsuarioResponseDto> usuarios)
        {
            gridUsuarios.Rows.Clear();
            foreach (var u in usuarios)
            {
                gridUsuarios.Rows.Add(
                    u.Id,
                    u.Nome,
                    u.Email,
                    u.Perfil);
            }
        }

        private void TxtPesquisa_TextChanged(object? sender, EventArgs e) => FiltrarUsuarios();

        private void BtnPesquisar_Click(object? sender, EventArgs e) => FiltrarUsuarios();

        private void FiltrarUsuarios()
        {
            var termo = txtPesquisa.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(termo))
            {
                PopularGrid(_todosUsuarios);
                return;
            }

            var filtrados = _todosUsuarios
                .Where(u => u.Nome.Contains(termo, StringComparison.OrdinalIgnoreCase)
                         || u.Email.Contains(termo, StringComparison.OrdinalIgnoreCase))
                .ToList();

            PopularGrid(filtrados);
        }

        private async void BtnNovo_Click(object? sender, EventArgs e)
        {
            using var form = new UsuarioFormDialog(_perfis, null);
            if (form.ShowDialog() == DialogResult.OK && form.CreateDto != null)
            {
                var (success, _, error) = await _usuariosService.CreateAsync(form.CreateDto);
                if (success)
                {
                    MessageBox.Show("✅ Usuário criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CarregarDadosAsync();
                }
                else
                {
                    MessageBox.Show($"❌ {error}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnEditar_Click(object? sender, EventArgs e)
        {
            var usuario = ObterUsuarioSelecionado();
            if (usuario == null)
            {
                MessageBox.Show("Selecione um usuário para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new UsuarioFormDialog(_perfis, usuario);
            if (form.ShowDialog() == DialogResult.OK && form.UpdateDto != null)
            {
                var (success, _, error) = await _usuariosService.UpdateAsync(usuario.Id, form.UpdateDto);
                if (success)
                {
                    MessageBox.Show("✅ Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CarregarDadosAsync();
                }
                else
                {
                    MessageBox.Show($"❌ {error}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnExcluir_Click(object? sender, EventArgs e)
        {
            var usuario = ObterUsuarioSelecionado();
            if (usuario == null)
            {
                MessageBox.Show("Selecione um usuário para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var conf = MessageBox.Show(
                $"Tem certeza que deseja excluir o usuário:\n\"{usuario.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (conf != DialogResult.Yes) return;

            var (success, error) = await _usuariosService.DeleteAsync(usuario.Id);
            if (success)
            {
                MessageBox.Show("✅ Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CarregarDadosAsync();
            }
            else
            {
                MessageBox.Show($"❌ {error}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnAtualizar_Click(object? sender, EventArgs e) => await CarregarDadosAsync();

        private UsuarioResponseDto? ObterUsuarioSelecionado()
        {
            if (gridUsuarios.SelectedRows.Count == 0) return null;
            var row = gridUsuarios.SelectedRows[0];
            var id = row.Cells["colId"].Value?.ToString();
            return _todosUsuarios.FirstOrDefault(u => u.Id == id);
        }

        private void GridUsuarios_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
            => BtnEditar_Click(sender, e);
    }
}
