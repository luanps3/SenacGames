// =============================================================================
// SenacGames.Desktop - UserControls/UsuariosUserControl.Designer.cs
// =============================================================================
// ️ ARQUIVO GERADO PELO DESIGNER — NÃO EDITE MANUALMENTE
// Toda lógica de negócio deve estar em UsuariosUserControl.cs
// =============================================================================

namespace SenacGames.Desktop.UserControls
{
    partial class UsuariosUserControl
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
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlToolbar;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private Guna.UI2.WinForms.Guna2Button btnNovo;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerfil;

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
            lblTitulo = new Label();
            lblInfo = new Label();
            pnlToolbar = new Panel();
            txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            btnNovo = new Guna.UI2.WinForms.Guna2Button();
            btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            gridUsuarios = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colPerfil = new DataGridViewTextBoxColumn();
            pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 38, 50);
            lblTitulo.Location = new Point(24, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(500, 36);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "👥 Gerenciamento de Usuários";
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI", 9F);
            lblInfo.ForeColor = Color.FromArgb(150, 160, 175);
            lblInfo.Location = new Point(24, 54);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(700, 24);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "ℹ Gerencia usuários do ASP.NET Core Identity registrados na aplicação.";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(txtPesquisa);
            pnlToolbar.Controls.Add(btnNovo);
            pnlToolbar.Controls.Add(btnExcluir);
            pnlToolbar.Controls.Add(btnAtualizar);
            pnlToolbar.Location = new Point(24, 88);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(762, 56);
            pnlToolbar.TabIndex = 2;
            // 
            // txtPesquisa
            // 
            txtPesquisa.BorderColor = Color.FromArgb(224, 228, 235);
            txtPesquisa.BorderRadius = 6;
            txtPesquisa.CustomizableEdges = customizableEdges1;
            txtPesquisa.DefaultText = "";
            txtPesquisa.FillColor = Color.FromArgb(245, 247, 250);
            txtPesquisa.Font = new Font("Segoe UI", 9.5F);
            txtPesquisa.Location = new Point(8, 9);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "🔍 Pesquisar por email...";
            txtPesquisa.SelectedText = "";
            txtPesquisa.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtPesquisa.Size = new Size(250, 38);
            txtPesquisa.TabIndex = 0;
            // 
            // btnNovo
            // 
            btnNovo.Animated = true;
            btnNovo.BorderRadius = 6;
            btnNovo.CustomizableEdges = customizableEdges3;
            btnNovo.FillColor = Color.FromArgb(40, 167, 69);
            btnNovo.Font = new Font("Segoe UI", 9F);
            btnNovo.ForeColor = Color.White;
            btnNovo.Location = new Point(270, 9);
            btnNovo.Name = "btnNovo";
            btnNovo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnNovo.Size = new Size(140, 38);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "+ Novo Usuário";
            // 
            // btnExcluir
            // 
            btnExcluir.Animated = true;
            btnExcluir.BorderRadius = 6;
            btnExcluir.CustomizableEdges = customizableEdges5;
            btnExcluir.FillColor = Color.FromArgb(220, 53, 69);
            btnExcluir.Font = new Font("Segoe UI", 9F);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(422, 9);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnExcluir.Size = new Size(100, 38);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "🗑 Excluir";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Animated = true;
            btnAtualizar.BorderRadius = 6;
            btnAtualizar.CustomizableEdges = customizableEdges7;
            btnAtualizar.FillColor = Color.FromArgb(150, 160, 175);
            btnAtualizar.Font = new Font("Segoe UI", 9F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(534, 9);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAtualizar.Size = new Size(110, 38);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "↺ Atualizar";
            // 
            // gridUsuarios
            // 
            gridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsuarios.Columns.AddRange(new DataGridViewColumn[] { colId, colEmail, colPerfil });
            gridUsuarios.Location = new Point(24, 154);
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.Size = new Size(762, 320);
            gridUsuarios.TabIndex = 3;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.Width = 200;
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.HeaderText = "E-mail / Usuário";
            colEmail.Name = "colEmail";
            // 
            // colPerfil
            // 
            colPerfil.HeaderText = "Perfil";
            colPerfil.Name = "colPerfil";
            colPerfil.Width = 160;
            // 
            // UsuariosUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(lblTitulo);
            Controls.Add(lblInfo);
            Controls.Add(pnlToolbar);
            Controls.Add(gridUsuarios);
            Name = "UsuariosUserControl";
            Padding = new Padding(24);
            Size = new Size(805, 501);
            pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).EndInit();
            ResumeLayout(false);
        }
    }
}
