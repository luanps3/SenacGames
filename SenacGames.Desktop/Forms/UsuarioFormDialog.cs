// =============================================================================
// SenacGames.Desktop - Forms/UsuarioFormDialog.cs
// =============================================================================

using SenacGames.Desktop.DTOs;
using SenacGames.Desktop.Themes;

namespace SenacGames.Desktop.Forms
{
    public partial class UsuarioFormDialog : Form
    {
        public CreateUsuarioDto? CreateDto { get; private set; }
        public UpdateUsuarioDto? UpdateDto { get; private set; }

        private List<string> _perfis = new();
        private UsuarioResponseDto? _usuarioExistente;

        public UsuarioFormDialog()
        {
            InitializeComponent();
        }

        public UsuarioFormDialog(List<string> perfis, UsuarioResponseDto? usuarioExistente = null)
            : this()
        {
            _perfis = perfis;
            _usuarioExistente = usuarioExistente;

            PreencherComboPerfis();

            if (_usuarioExistente != null)
            {
                lblTituloForm.Text = "Editar Usuário";
                txtNome.Text = _usuarioExistente.Nome;
                txtEmail.Text = _usuarioExistente.Email;
                
                if (cmbPerfil.Items.Contains(_usuarioExistente.Perfil))
                {
                    cmbPerfil.SelectedItem = _usuarioExistente.Perfil;
                }
            }
            else
            {
                lblTituloForm.Text = "Novo Usuário";
                if (cmbPerfil.Items.Count > 0)
                    cmbPerfil.SelectedIndex = 0;
            }

        }

        private void PreencherComboPerfis()
        {
            cmbPerfil.Items.Clear();
            foreach (var p in _perfis)
            {
                cmbPerfil.Items.Add(p);
            }
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Nome e Email são obrigatórios.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_usuarioExistente == null && string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Senha é obrigatória para novos usuários.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPerfil.SelectedItem == null)
            {
                MessageBox.Show("Selecione um perfil.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_usuarioExistente == null)
            {
                CreateDto = new CreateUsuarioDto
                {
                    Nome = txtNome.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Senha = txtSenha.Text,
                    ConfirmarSenha = txtConfirmarSenha.Text,
                    Perfil = cmbPerfil.SelectedItem.ToString()!
                };
            }
            else
            {
                UpdateDto = new UpdateUsuarioDto
                {
                    Nome = txtNome.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Senha = string.IsNullOrEmpty(txtSenha.Text) ? null : txtSenha.Text,
                    ConfirmarSenha = string.IsNullOrEmpty(txtConfirmarSenha.Text) ? null : txtConfirmarSenha.Text,
                    Perfil = cmbPerfil.SelectedItem.ToString()!
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancelar_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
