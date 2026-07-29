// =============================================================================
// SenacGames.Desktop - Forms/GameFormDialog.Designer.cs
// =============================================================================
// ️ ARQUIVO GERADO PELO DESIGNER — NÃO EDITE MANUALMENTE
// Toda lógica de negócio deve estar em GameFormDialog.cs
// =============================================================================

namespace SenacGames.Desktop.Forms
{
    partial class GameFormDialog
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
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label lblCampTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private System.Windows.Forms.Label lblCampDesc;
        private Guna.UI2.WinForms.Guna2TextBox txtDescricao;
        private System.Windows.Forms.Label lblCampAno;
        private Guna.UI2.WinForms.Guna2TextBox txtAno;
        private System.Windows.Forms.Label lblCampCover;
        private Guna.UI2.WinForms.Guna2TextBox txtCoverUrl;
        private System.Windows.Forms.Label lblCampCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.CheckBox chkDestaque;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;

        // =====================================================================
        // INITIALIZECOMPONENT — formato padrão do Windows Forms Designer
        // =====================================================================
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ─── Instanciar todos os controles ────────────────────────────────
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.lblCampTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCampDesc = new System.Windows.Forms.Label();
            this.txtDescricao = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCampAno = new System.Windows.Forms.Label();
            this.txtAno = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCampCover = new System.Windows.Forms.Label();
            this.txtCoverUrl = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCampCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.chkDestaque = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();

            // SuspendLayout
            this.SuspendLayout();

            // ─── lblTituloForm ────────────────────────────────────────────────
            this.lblTituloForm.AutoSize = false;
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(0, 75, 135);
            this.lblTituloForm.Location = new System.Drawing.Point(24, 16);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(460, 36);
            this.lblTituloForm.TabIndex = 0;
            this.lblTituloForm.Text = "Game";

            // ─── lblCampTitulo ────────────────────────────────────────────────
            this.lblCampTitulo.AutoSize = false;
            this.lblCampTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCampTitulo.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblCampTitulo.Location = new System.Drawing.Point(24, 64);
            this.lblCampTitulo.Name = "lblCampTitulo";
            this.lblCampTitulo.Size = new System.Drawing.Size(460, 20);
            this.lblCampTitulo.TabIndex = 1;
            this.lblCampTitulo.Text = "TÍTULO DO GAME *";

            // ─── txtTitulo ────────────────────────────────────────────────────
            this.txtTitulo.BorderColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.txtTitulo.BorderRadius = 6;
            this.txtTitulo.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTitulo.Location = new System.Drawing.Point(24, 86);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceholderText = "Ex: Super Mario Bros.";
            this.txtTitulo.Size = new System.Drawing.Size(460, 40);
            this.txtTitulo.TabIndex = 2;

            // ─── lblCampDesc ──────────────────────────────────────────────────
            this.lblCampDesc.AutoSize = false;
            this.lblCampDesc.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCampDesc.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblCampDesc.Location = new System.Drawing.Point(24, 142);
            this.lblCampDesc.Name = "lblCampDesc";
            this.lblCampDesc.Size = new System.Drawing.Size(460, 20);
            this.lblCampDesc.TabIndex = 3;
            this.lblCampDesc.Text = "DESCRIÇÃO";

            // ─── txtDescricao ─────────────────────────────────────────────────
            this.txtDescricao.BorderColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.txtDescricao.BorderRadius = 6;
            this.txtDescricao.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDescricao.Location = new System.Drawing.Point(24, 164);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PlaceholderText = "Descrição do game...";
            this.txtDescricao.Size = new System.Drawing.Size(460, 80);
            this.txtDescricao.TabIndex = 4;

            // ─── lblCampAno ───────────────────────────────────────────────────
            this.lblCampAno.AutoSize = false;
            this.lblCampAno.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCampAno.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblCampAno.Location = new System.Drawing.Point(24, 260);
            this.lblCampAno.Name = "lblCampAno";
            this.lblCampAno.Size = new System.Drawing.Size(460, 20);
            this.lblCampAno.TabIndex = 5;
            this.lblCampAno.Text = "ANO DE LANÇAMENTO *";

            // ─── txtAno ───────────────────────────────────────────────────────
            this.txtAno.BorderColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.txtAno.BorderRadius = 6;
            this.txtAno.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtAno.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAno.Location = new System.Drawing.Point(24, 282);
            this.txtAno.Name = "txtAno";
            this.txtAno.PlaceholderText = "Ex: 2024";
            this.txtAno.Size = new System.Drawing.Size(460, 40);
            this.txtAno.TabIndex = 6;

            // ─── lblCampCover ─────────────────────────────────────────────────
            this.lblCampCover.AutoSize = false;
            this.lblCampCover.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCampCover.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblCampCover.Location = new System.Drawing.Point(24, 338);
            this.lblCampCover.Name = "lblCampCover";
            this.lblCampCover.Size = new System.Drawing.Size(460, 20);
            this.lblCampCover.TabIndex = 7;
            this.lblCampCover.Text = "URL DA CAPA";

            // ─── txtCoverUrl ──────────────────────────────────────────────────
            this.txtCoverUrl.BorderColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.txtCoverUrl.BorderRadius = 6;
            this.txtCoverUrl.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtCoverUrl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCoverUrl.Location = new System.Drawing.Point(24, 360);
            this.txtCoverUrl.Name = "txtCoverUrl";
            this.txtCoverUrl.PlaceholderText = "https://...";
            this.txtCoverUrl.Size = new System.Drawing.Size(460, 40);
            this.txtCoverUrl.TabIndex = 8;

            // ─── lblCampCategoria ─────────────────────────────────────────────
            this.lblCampCategoria.AutoSize = false;
            this.lblCampCategoria.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCampCategoria.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.lblCampCategoria.Location = new System.Drawing.Point(24, 416);
            this.lblCampCategoria.Name = "lblCampCategoria";
            this.lblCampCategoria.Size = new System.Drawing.Size(460, 20);
            this.lblCampCategoria.TabIndex = 9;
            this.lblCampCategoria.Text = "CATEGORIA *";

            // ─── cmbCategoria ─────────────────────────────────────────────────
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbCategoria.Location = new System.Drawing.Point(24, 438);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(460, 38);
            this.cmbCategoria.TabIndex = 10;

            // ─── chkDestaque ──────────────────────────────────────────────────
            this.chkDestaque.AutoSize = true;
            this.chkDestaque.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkDestaque.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.chkDestaque.Location = new System.Drawing.Point(24, 490);
            this.chkDestaque.Name = "chkDestaque";
            this.chkDestaque.TabIndex = 11;
            this.chkDestaque.Text = "⭐ Marcar como destaque";

            // ─── btnSalvar ────────────────────────────────────────────────────
            this.btnSalvar.BorderRadius = 8;
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(24, 520);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(140, 42);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "💾 Salvar";

            // ─── btnCancelar ──────────────────────────────────────────────────
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(224, 228, 235);
            this.btnCancelar.BorderRadius = 8;
            this.btnCancelar.BorderThickness = 1;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(51, 61, 75);
            this.btnCancelar.Location = new System.Drawing.Point(180, 520);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 42);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";

            // ─── Configuração do Form ─────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 580);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.lblCampTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCampDesc);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblCampAno);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblCampCover);
            this.Controls.Add(this.txtCoverUrl);
            this.Controls.Add(this.lblCampCategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.chkDestaque);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameFormDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game";

            // ─── Eventos ──────────────────────────────────────────────────────
            this.Load += new System.EventHandler(this.GameFormDialog_Load);
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);

            // ResumeLayout
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
