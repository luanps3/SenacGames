namespace SenacGames.Desktop.UserControls
{
    partial class GamesUserControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            gridGames = new DataGridView();
            pnlToolbar = new Panel();
            btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            btnEditar = new Guna.UI2.WinForms.Guna2Button();
            btnNova = new Guna.UI2.WinForms.Guna2Button();
            lblTitulo = new Label();
            btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            colReleaseYear = new DataGridViewTextBoxColumn();
            colIsFeatured = new DataGridViewCheckBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridGames).BeginInit();
            pnlToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // gridGames
            // 
            gridGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridGames.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colCategoryName, colReleaseYear, colIsFeatured, colCreatedAt });
            gridGames.Location = new Point(20, 168);
            gridGames.Name = "gridGames";
            gridGames.Size = new Size(681, 246);
            gridGames.TabIndex = 6;
            // 
            // pnlToolbar
            // 
            pnlToolbar.Controls.Add(guna2TextBox1);
            pnlToolbar.Controls.Add(btnPesquisar);
            pnlToolbar.Controls.Add(btnAtualizar);
            pnlToolbar.Controls.Add(btnExcluir);
            pnlToolbar.Controls.Add(btnEditar);
            pnlToolbar.Controls.Add(btnNova);
            pnlToolbar.Location = new Point(20, 62);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(681, 100);
            pnlToolbar.TabIndex = 5;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BorderRadius = 10;
            btnAtualizar.CustomizableEdges = customizableEdges13;
            btnAtualizar.DisabledState.BorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAtualizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAtualizar.FillColor = Color.Olive;
            btnAtualizar.Font = new Font("Segoe UI", 9F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(579, 54);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnAtualizar.Size = new Size(90, 36);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "🔄️ Atualizar";
            // 
            // btnExcluir
            // 
            btnExcluir.BorderRadius = 10;
            btnExcluir.CustomizableEdges = customizableEdges15;
            btnExcluir.DisabledState.BorderColor = Color.DarkGray;
            btnExcluir.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExcluir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExcluir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExcluir.FillColor = Color.FromArgb(192, 0, 0);
            btnExcluir.Font = new Font("Segoe UI", 9F);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(483, 54);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnExcluir.Size = new Size(90, 36);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "🗑️ Excluir";
            // 
            // btnEditar
            // 
            btnEditar.BorderRadius = 10;
            btnEditar.CustomizableEdges = customizableEdges17;
            btnEditar.DisabledState.BorderColor = Color.DarkGray;
            btnEditar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditar.FillColor = Color.FromArgb(0, 77, 147);
            btnEditar.Font = new Font("Segoe UI", 9F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(579, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnEditar.Size = new Size(90, 36);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "✏️ Editar";
            // 
            // btnNova
            // 
            btnNova.BorderRadius = 10;
            btnNova.CustomizableEdges = customizableEdges19;
            btnNova.DisabledState.BorderColor = Color.DarkGray;
            btnNova.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNova.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNova.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNova.FillColor = Color.Green;
            btnNova.Font = new Font("Segoe UI", 9F);
            btnNova.ForeColor = Color.White;
            btnNova.Location = new Point(483, 12);
            btnNova.Name = "btnNova";
            btnNova.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnNova.Size = new Size(90, 36);
            btnNova.TabIndex = 1;
            btnNova.Text = "+ Nova Categoria";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(266, 25);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "🎮 Gerenciamento de Games";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BorderRadius = 10;
            btnPesquisar.CustomizableEdges = customizableEdges21;
            btnPesquisar.DisabledState.BorderColor = Color.DarkGray;
            btnPesquisar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPesquisar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPesquisar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPesquisar.FillColor = Color.DodgerBlue;
            btnPesquisar.Font = new Font("Segoe UI", 9F);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(378, 25);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnPesquisar.Size = new Size(93, 44);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "🔎 Pesquisar";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.CustomizableEdges = customizableEdges23;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(13, 28);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges24;
            guna2TextBox1.Size = new Size(355, 36);
            guna2TextBox1.TabIndex = 2;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Título";
            colTitle.Name = "colTitle";
            colTitle.Width = 225;
            // 
            // colCategoryName
            // 
            colCategoryName.HeaderText = "Categoria";
            colCategoryName.Name = "colCategoryName";
            // 
            // colReleaseYear
            // 
            colReleaseYear.HeaderText = "Ano";
            colReleaseYear.Name = "colReleaseYear";
            // 
            // colIsFeatured
            // 
            colIsFeatured.HeaderText = "Destaque";
            colIsFeatured.Name = "colIsFeatured";
            colIsFeatured.Resizable = DataGridViewTriState.True;
            colIsFeatured.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colCreatedAt
            // 
            colCreatedAt.HeaderText = "Cadastrado em";
            colCreatedAt.Name = "colCreatedAt";
            // 
            // GamesUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridGames);
            Controls.Add(pnlToolbar);
            Controls.Add(lblTitulo);
            Name = "GamesUserControl";
            Size = new Size(715, 436);
            ((System.ComponentModel.ISupportInitialize)gridGames).EndInit();
            pnlToolbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridGames;
        private Panel pnlToolbar;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnNova;
        private Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colCategoryName;
        private DataGridViewTextBoxColumn colReleaseYear;
        private DataGridViewCheckBoxColumn colIsFeatured;
        private DataGridViewTextBoxColumn colCreatedAt;
    }
}
