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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTituloForm = new Label();
            lblCampTitulo = new Label();
            txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            lblCampDesc = new Label();
            txtDescricao = new Guna.UI2.WinForms.Guna2TextBox();
            lblCampAno = new Label();
            txtAno = new Guna.UI2.WinForms.Guna2TextBox();
            lblCampCover = new Label();
            txtCoverUrl = new Guna.UI2.WinForms.Guna2TextBox();
            lblCampCategoria = new Label();
            cmbCategoria = new ComboBox();
            chkDestaque = new CheckBox();
            btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // lblTituloForm
            // 
            lblTituloForm.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTituloForm.ForeColor = Color.FromArgb(0, 75, 135);
            lblTituloForm.Location = new Point(24, 16);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(460, 36);
            lblTituloForm.TabIndex = 0;
            lblTituloForm.Text = "Game";
            // 
            // lblCampTitulo
            // 
            lblCampTitulo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCampTitulo.ForeColor = Color.FromArgb(51, 61, 75);
            lblCampTitulo.Location = new Point(24, 64);
            lblCampTitulo.Name = "lblCampTitulo";
            lblCampTitulo.Size = new Size(460, 20);
            lblCampTitulo.TabIndex = 1;
            lblCampTitulo.Text = "TÍTULO DO GAME *";
            // 
            // txtTitulo
            // 
            txtTitulo.BorderColor = Color.FromArgb(224, 228, 235);
            txtTitulo.BorderRadius = 6;
            txtTitulo.CustomizableEdges = customizableEdges1;
            txtTitulo.DefaultText = "";
            txtTitulo.FillColor = Color.FromArgb(245, 247, 250);
            txtTitulo.Font = new Font("Segoe UI", 9.5F);
            txtTitulo.Location = new Point(24, 86);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Ex: Super Mario Bros.";
            txtTitulo.SelectedText = "";
            txtTitulo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTitulo.Size = new Size(460, 40);
            txtTitulo.TabIndex = 2;
            // 
            // lblCampDesc
            // 
            lblCampDesc.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCampDesc.ForeColor = Color.FromArgb(51, 61, 75);
            lblCampDesc.Location = new Point(24, 142);
            lblCampDesc.Name = "lblCampDesc";
            lblCampDesc.Size = new Size(460, 20);
            lblCampDesc.TabIndex = 3;
            lblCampDesc.Text = "DESCRIÇÃO";
            // 
            // txtDescricao
            // 
            txtDescricao.BorderColor = Color.FromArgb(224, 228, 235);
            txtDescricao.BorderRadius = 6;
            txtDescricao.CustomizableEdges = customizableEdges3;
            txtDescricao.DefaultText = "";
            txtDescricao.FillColor = Color.FromArgb(245, 247, 250);
            txtDescricao.Font = new Font("Segoe UI", 9.5F);
            txtDescricao.Location = new Point(24, 164);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição do game...";
            txtDescricao.SelectedText = "";
            txtDescricao.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtDescricao.Size = new Size(460, 80);
            txtDescricao.TabIndex = 4;
            // 
            // lblCampAno
            // 
            lblCampAno.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCampAno.ForeColor = Color.FromArgb(51, 61, 75);
            lblCampAno.Location = new Point(24, 260);
            lblCampAno.Name = "lblCampAno";
            lblCampAno.Size = new Size(460, 20);
            lblCampAno.TabIndex = 5;
            lblCampAno.Text = "ANO DE LANÇAMENTO *";
            // 
            // txtAno
            // 
            txtAno.BorderColor = Color.FromArgb(224, 228, 235);
            txtAno.BorderRadius = 6;
            txtAno.CustomizableEdges = customizableEdges5;
            txtAno.DefaultText = "";
            txtAno.FillColor = Color.FromArgb(245, 247, 250);
            txtAno.Font = new Font("Segoe UI", 9.5F);
            txtAno.Location = new Point(24, 282);
            txtAno.Name = "txtAno";
            txtAno.PlaceholderText = "Ex: 2024";
            txtAno.SelectedText = "";
            txtAno.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtAno.Size = new Size(460, 40);
            txtAno.TabIndex = 6;
            // 
            // lblCampCover
            // 
            lblCampCover.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCampCover.ForeColor = Color.FromArgb(51, 61, 75);
            lblCampCover.Location = new Point(24, 338);
            lblCampCover.Name = "lblCampCover";
            lblCampCover.Size = new Size(460, 20);
            lblCampCover.TabIndex = 7;
            lblCampCover.Text = "URL DA CAPA";
            // 
            // txtCoverUrl
            // 
            txtCoverUrl.BorderColor = Color.FromArgb(224, 228, 235);
            txtCoverUrl.BorderRadius = 6;
            txtCoverUrl.CustomizableEdges = customizableEdges7;
            txtCoverUrl.DefaultText = "";
            txtCoverUrl.FillColor = Color.FromArgb(245, 247, 250);
            txtCoverUrl.Font = new Font("Segoe UI", 9.5F);
            txtCoverUrl.Location = new Point(24, 360);
            txtCoverUrl.Name = "txtCoverUrl";
            txtCoverUrl.PlaceholderText = "https://...";
            txtCoverUrl.SelectedText = "";
            txtCoverUrl.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtCoverUrl.Size = new Size(460, 40);
            txtCoverUrl.TabIndex = 8;
            // 
            // lblCampCategoria
            // 
            lblCampCategoria.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCampCategoria.ForeColor = Color.FromArgb(51, 61, 75);
            lblCampCategoria.Location = new Point(24, 416);
            lblCampCategoria.Name = "lblCampCategoria";
            lblCampCategoria.Size = new Size(460, 20);
            lblCampCategoria.TabIndex = 9;
            lblCampCategoria.Text = "CATEGORIA *";
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(245, 247, 250);
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Segoe UI", 9.5F);
            cmbCategoria.Location = new Point(24, 438);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(460, 25);
            cmbCategoria.TabIndex = 10;
            // 
            // chkDestaque
            // 
            chkDestaque.AutoSize = true;
            chkDestaque.Font = new Font("Segoe UI", 9.5F);
            chkDestaque.ForeColor = Color.FromArgb(51, 61, 75);
            chkDestaque.Location = new Point(24, 490);
            chkDestaque.Name = "chkDestaque";
            chkDestaque.Size = new Size(179, 21);
            chkDestaque.TabIndex = 11;
            chkDestaque.Text = "⭐ Marcar como destaque";
            // 
            // btnSalvar
            // 
            btnSalvar.BorderRadius = 8;
            btnSalvar.CustomizableEdges = customizableEdges9;
            btnSalvar.FillColor = Color.FromArgb(40, 167, 69);
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(24, 520);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnSalvar.Size = new Size(140, 42);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "💾 Salvar";
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BorderColor = Color.FromArgb(224, 228, 235);
            btnCancelar.BorderRadius = 8;
            btnCancelar.BorderThickness = 1;
            btnCancelar.CustomizableEdges = customizableEdges11;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FillColor = Color.FromArgb(245, 247, 250);
            btnCancelar.Font = new Font("Segoe UI", 9.5F);
            btnCancelar.ForeColor = Color.FromArgb(51, 61, 75);
            btnCancelar.Location = new Point(180, 520);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnCancelar.Size = new Size(100, 42);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // GameFormDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(520, 580);
            Controls.Add(lblTituloForm);
            Controls.Add(lblCampTitulo);
            Controls.Add(txtTitulo);
            Controls.Add(lblCampDesc);
            Controls.Add(txtDescricao);
            Controls.Add(lblCampAno);
            Controls.Add(txtAno);
            Controls.Add(lblCampCover);
            Controls.Add(txtCoverUrl);
            Controls.Add(lblCampCategoria);
            Controls.Add(cmbCategoria);
            Controls.Add(chkDestaque);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GameFormDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Game";
            Load += GameFormDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
