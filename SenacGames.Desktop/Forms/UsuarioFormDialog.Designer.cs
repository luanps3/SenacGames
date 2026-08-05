// =============================================================================
// SenacGames.Desktop - Forms/UsuarioFormDialog.Designer.cs
// =============================================================================

namespace SenacGames.Desktop.Forms
{
    partial class UsuarioFormDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label lblCampNome;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private System.Windows.Forms.Label lblCampEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblCampSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private System.Windows.Forms.Label lblCampConfirmarSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblCampPerfil;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.lblCampNome = new System.Windows.Forms.Label();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCampEmail = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCampSenha = new System.Windows.Forms.Label();
            this.txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCampConfirmarSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCampPerfil = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();

            // lblTituloForm
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.lblTituloForm.Location = new System.Drawing.Point(24, 16);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(460, 36);
            this.lblTituloForm.Text = "Usuário";

            // lblCampNome
            this.lblCampNome.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCampNome.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblCampNome.Location = new System.Drawing.Point(24, 64);
            this.lblCampNome.Name = "lblCampNome";
            this.lblCampNome.Size = new System.Drawing.Size(460, 20);
            this.lblCampNome.Text = "NOME *";

            // txtNome
            this.txtNome.BorderRadius = 6;
            this.txtNome.Location = new System.Drawing.Point(24, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(460, 40);

            // lblCampEmail
            this.lblCampEmail.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCampEmail.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblCampEmail.Location = new System.Drawing.Point(24, 136);
            this.lblCampEmail.Name = "lblCampEmail";
            this.lblCampEmail.Size = new System.Drawing.Size(460, 20);
            this.lblCampEmail.Text = "EMAIL *";

            // txtEmail
            this.txtEmail.BorderRadius = 6;
            this.txtEmail.Location = new System.Drawing.Point(24, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(460, 40);

            // lblCampSenha
            this.lblCampSenha.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCampSenha.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblCampSenha.Location = new System.Drawing.Point(24, 208);
            this.lblCampSenha.Name = "lblCampSenha";
            this.lblCampSenha.Size = new System.Drawing.Size(220, 20);
            this.lblCampSenha.Text = "SENHA";

            // txtSenha
            this.txtSenha.BorderRadius = 6;
            this.txtSenha.Location = new System.Drawing.Point(24, 230);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(220, 40);

            // lblCampConfirmarSenha
            this.lblCampConfirmarSenha.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCampConfirmarSenha.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblCampConfirmarSenha.Location = new System.Drawing.Point(264, 208);
            this.lblCampConfirmarSenha.Name = "lblCampConfirmarSenha";
            this.lblCampConfirmarSenha.Size = new System.Drawing.Size(220, 20);
            this.lblCampConfirmarSenha.Text = "CONFIRMAR SENHA";

            // txtConfirmarSenha
            this.txtConfirmarSenha.BorderRadius = 6;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(264, 230);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(220, 40);

            // lblCampPerfil
            this.lblCampPerfil.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCampPerfil.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblCampPerfil.Location = new System.Drawing.Point(24, 280);
            this.lblCampPerfil.Name = "lblCampPerfil";
            this.lblCampPerfil.Size = new System.Drawing.Size(460, 20);
            this.lblCampPerfil.Text = "PERFIL *";

            // cmbPerfil
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPerfil.Location = new System.Drawing.Point(24, 302);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(460, 31);

            // btnSalvar
            this.btnSalvar.BorderRadius = 6;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Location = new System.Drawing.Point(224, 360);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 45);
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);

            // btnCancelar
            this.btnCancelar.BorderRadius = 6;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(364, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 45);
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);

            // UsuarioFormDialog
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 430);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.lblCampPerfil);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.lblCampConfirmarSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblCampSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCampEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCampNome);
            this.Controls.Add(this.lblTituloForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsuarioFormDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
