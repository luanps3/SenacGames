// =============================================================================
// SenacGames.Desktop - Forms/UsuarioFormDialog.cs
// =============================================================================
//  CONCEITO: Dialog de Formulário de Usuário
//
// Formulário auxiliar para criação de novos usuários via API.
// Coleta: email, senha, confirmação de senha e perfil (role).
// =============================================================================

using SenacGames.Desktop.DTOs;

namespace SenacGames.Desktop.Forms
{
    /// <summary>
    /// Formulário de criação de novo usuário.
    /// </summary>
    public partial class UsuarioFormDialog : Form
    {
        /// <summary>DTO preenchido ao confirmar (OK)</summary>
        public CreateUsuarioDto? CreateDto { get; private set; }

        // =====================================================================
        // CONSTRUTOR
        // =====================================================================

        /// <summary>
        /// Construtor padrão sem parâmetros — compatível com o Designer.
        /// </summary>
        public UsuarioFormDialog()
        {
            InitializeComponent();
        }

        // =====================================================================
        // EVENTOS
        // =====================================================================

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Informe o e-mail.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text) || txtSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSenha.Text != txtConfirmar.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CreateDto = new CreateUsuarioDto
            {
                Email = txtEmail.Text.Trim(),
                Password = txtSenha.Text,
                ConfirmPassword = txtConfirmar.Text,
                Role = cmbPerfil.SelectedItem?.ToString() ?? "User"
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
