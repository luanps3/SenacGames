// =============================================================================
// SenacGames.Desktop - Forms/UsuarioFormDialog.Designer.cs
// =============================================================================
// ️ ARQUIVO GERADO PELO DESIGNER — NÃO EDITE MANUALMENTE
// Toda lógica de negócio deve estar em UsuarioFormDialog.cs
// =============================================================================

namespace SenacGames.Desktop.Forms
{
    partial class UsuarioFormDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // =====================================================================
        // DECLARAÇÕES DOS CONTROLES — todos como campos privados
        // =====================================================================
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private System.Windows.Forms.Label lblConf;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmar;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;

        // =====================================================================
        // INITIALIZECOMPONENT — formato padrão do Windows Forms Designer
        // =====================================================================
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ─── Instanciar todos os controles ────────────────────────────────
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblConf = new System.Windows.Forms.Label();
            this.txtConfirmar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();

            // SuspendLayout
            this.SuspendLayout();

            // ─── lblTitulo ────────────────────────────────────────────────────
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.lblTitulo.Location = new System.Drawing.Point(24, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "👤 Novo Usuário";

            // ─── lblEmail ─────────────────────────────────────────────────────
            this.lblEmail.AutoSize = false;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblEmail.Location = new System.Drawing.Point(24, 64);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(400, 18);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-MAIL *";

            // ─── txtEmail ─────────────────────────────────────────────────────
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.txtEmail.BorderRadius = 6;
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtEmail.Location = new System.Drawing.Point(24, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "usuario@email.com";
            this.txtEmail.Size = new System.Drawing.Size(400, 40);
            this.txtEmail.TabIndex = 2;

            // ─── lblSenha ─────────────────────────────────────────────────────
            this.lblSenha.AutoSize = false;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblSenha.Location = new System.Drawing.Point(24, 136);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(400, 18);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "SENHA *";

            // ─── txtSenha ─────────────────────────────────────────────────────
            this.txtSenha.BorderColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.txtSenha.BorderRadius = 6;
            this.txtSenha.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSenha.Location = new System.Drawing.Point(24, 156);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PlaceholderText = "••••••••";
            this.txtSenha.Size = new System.Drawing.Size(400, 40);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;

            // ─── lblConf ──────────────────────────────────────────────────────
            this.lblConf.AutoSize = false;
            this.lblConf.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblConf.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblConf.Location = new System.Drawing.Point(24, 208);
            this.lblConf.Name = "lblConf";
            this.lblConf.Size = new System.Drawing.Size(400, 18);
            this.lblConf.TabIndex = 5;
            this.lblConf.Text = "CONFIRMAR SENHA *";

            // ─── txtConfirmar ─────────────────────────────────────────────────
            this.txtConfirmar.BorderColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.txtConfirmar.BorderRadius = 6;
            this.txtConfirmar.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtConfirmar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtConfirmar.Location = new System.Drawing.Point(24, 228);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PlaceholderText = "••••••••";
            this.txtConfirmar.Size = new System.Drawing.Size(400, 40);
            this.txtConfirmar.TabIndex = 6;
            this.txtConfirmar.UseSystemPasswordChar = true;

            // ─── lblPerfil ────────────────────────────────────────────────────
            this.lblPerfil.AutoSize = false;
            this.lblPerfil.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPerfil.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblPerfil.Location = new System.Drawing.Point(24, 280);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(400, 18);
            this.lblPerfil.TabIndex = 7;
            this.lblPerfil.Text = "PERFIL (ROLE)";

            // ─── cmbPerfil ────────────────────────────────────────────────────
            this.cmbPerfil.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPerfil.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbPerfil.Items.AddRange(new object[] { "User", "Admin" });
            this.cmbPerfil.Location = new System.Drawing.Point(24, 300);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.SelectedIndex = 0;
            this.cmbPerfil.Size = new System.Drawing.Size(400, 38);
            this.cmbPerfil.TabIndex = 8;

            // ─── btnSalvar ────────────────────────────────────────────────────
            this.btnSalvar.BorderRadius = 8;
            this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(24, 358);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(160, 42);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "💾 Criar Usuário";

            // ─── btnCancelar ──────────────────────────────────────────────────
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.btnCancelar.BorderRadius = 8;
            this.btnCancelar.BorderThickness = 1;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.btnCancelar.Location = new System.Drawing.Point(200, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 42);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";

            // ─── Configuração do Form ─────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 420);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblConf);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsuarioFormDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo Usuário";

            // ─── Eventos ──────────────────────────────────────────────────────
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);

            // ResumeLayout
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
