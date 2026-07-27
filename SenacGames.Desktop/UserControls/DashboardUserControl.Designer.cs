namespace SenacGames.Desktop.UserControls
{
    partial class DashboardUserControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblCarregando = new Label();
            cardCategoriasLblDesc = new Label();
            lblUltimosGames = new Label();
            cardGames = new Guna.UI2.WinForms.Guna2Panel();
            pnlCorGames = new Guna.UI2.WinForms.Guna2Panel();
            cardGamesLblDesc = new Label();
            cardGamesLblNumero = new Label();
            cardGamesLblTitulo = new Label();
            cardCategorias = new Guna.UI2.WinForms.Guna2Panel();
            cardCategoriasLblNumero = new Label();
            cardCategoriasLblTitulo = new Label();
            pnlCorCategorias = new Guna.UI2.WinForms.Guna2Panel();
            gridUltimosGames = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            colReleaseYear = new DataGridViewTextBoxColumn();
            colIsFeatured = new DataGridViewCheckBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            cardGames.SuspendLayout();
            cardCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridUltimosGames).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(25, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(77, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Olá! 👋";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Century Gothic", 10F);
            lblSubtitulo.ForeColor = SystemColors.ControlDark;
            lblSubtitulo.Location = new Point(25, 50);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(262, 19);
            lblSubtitulo.TabIndex = 0;
            lblSubtitulo.Text = "Bem-vindo ao SenacGames Desktop";
            // 
            // lblCarregando
            // 
            lblCarregando.AutoSize = true;
            lblCarregando.Font = new Font("Century Gothic", 10F);
            lblCarregando.ForeColor = Color.DodgerBlue;
            lblCarregando.Location = new Point(25, 76);
            lblCarregando.Name = "lblCarregando";
            lblCarregando.Size = new Size(221, 19);
            lblCarregando.TabIndex = 0;
            lblCarregando.Text = "⌛Carregando dados da API...";
            // 
            // cardCategoriasLblDesc
            // 
            cardCategoriasLblDesc.AutoSize = true;
            cardCategoriasLblDesc.BackColor = Color.White;
            cardCategoriasLblDesc.Font = new Font("Century Gothic", 8.25F);
            cardCategoriasLblDesc.ForeColor = SystemColors.ControlDark;
            cardCategoriasLblDesc.Location = new Point(20, 83);
            cardCategoriasLblDesc.Name = "cardCategoriasLblDesc";
            cardCategoriasLblDesc.Size = new Size(111, 16);
            cardCategoriasLblDesc.TabIndex = 0;
            cardCategoriasLblDesc.Text = "Total de categorias";
            // 
            // lblUltimosGames
            // 
            lblUltimosGames.AutoSize = true;
            lblUltimosGames.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUltimosGames.Location = new Point(25, 253);
            lblUltimosGames.Name = "lblUltimosGames";
            lblUltimosGames.Size = new Size(233, 19);
            lblUltimosGames.TabIndex = 0;
            lblUltimosGames.Text = "💾 Últimos games cadastrados";
            // 
            // cardGames
            // 
            cardGames.BorderRadius = 10;
            cardGames.Controls.Add(pnlCorGames);
            cardGames.Controls.Add(cardGamesLblDesc);
            cardGames.Controls.Add(cardGamesLblNumero);
            cardGames.Controls.Add(cardGamesLblTitulo);
            cardGames.CustomizableEdges = customizableEdges3;
            cardGames.FillColor = Color.White;
            cardGames.Location = new Point(25, 108);
            cardGames.Name = "cardGames";
            cardGames.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cardGames.Size = new Size(210, 120);
            cardGames.TabIndex = 1;
            // 
            // pnlCorGames
            // 
            pnlCorGames.CustomizableEdges = customizableEdges1;
            pnlCorGames.FillColor = Color.FromArgb(0, 77, 147);
            pnlCorGames.Location = new Point(0, 0);
            pnlCorGames.Name = "pnlCorGames";
            pnlCorGames.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlCorGames.Size = new Size(210, 10);
            pnlCorGames.TabIndex = 2;
            // 
            // cardGamesLblDesc
            // 
            cardGamesLblDesc.AutoSize = true;
            cardGamesLblDesc.BackColor = Color.White;
            cardGamesLblDesc.Font = new Font("Century Gothic", 8.25F);
            cardGamesLblDesc.ForeColor = SystemColors.ControlDark;
            cardGamesLblDesc.Location = new Point(12, 83);
            cardGamesLblDesc.Name = "cardGamesLblDesc";
            cardGamesLblDesc.Size = new Size(162, 16);
            cardGamesLblDesc.TabIndex = 3;
            cardGamesLblDesc.Text = "Total de games cadastrados";
            // 
            // cardGamesLblNumero
            // 
            cardGamesLblNumero.AutoSize = true;
            cardGamesLblNumero.BackColor = Color.White;
            cardGamesLblNumero.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardGamesLblNumero.Location = new Point(12, 38);
            cardGamesLblNumero.Name = "cardGamesLblNumero";
            cardGamesLblNumero.Size = new Size(38, 45);
            cardGamesLblNumero.TabIndex = 2;
            cardGamesLblNumero.Text = "0";
            // 
            // cardGamesLblTitulo
            // 
            cardGamesLblTitulo.AutoSize = true;
            cardGamesLblTitulo.BackColor = Color.White;
            cardGamesLblTitulo.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            cardGamesLblTitulo.ForeColor = Color.FromArgb(0, 77, 147);
            cardGamesLblTitulo.Location = new Point(12, 19);
            cardGamesLblTitulo.Name = "cardGamesLblTitulo";
            cardGamesLblTitulo.Size = new Size(89, 19);
            cardGamesLblTitulo.TabIndex = 1;
            cardGamesLblTitulo.Text = "🎮 Games";
            // 
            // cardCategorias
            // 
            cardCategorias.Controls.Add(cardCategoriasLblNumero);
            cardCategorias.Controls.Add(cardCategoriasLblTitulo);
            cardCategorias.Controls.Add(cardCategoriasLblDesc);
            cardCategorias.CustomizableEdges = customizableEdges5;
            cardCategorias.FillColor = Color.White;
            cardCategorias.Location = new Point(262, 108);
            cardCategorias.Name = "cardCategorias";
            cardCategorias.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cardCategorias.Size = new Size(210, 120);
            cardCategorias.TabIndex = 1;
            // 
            // cardCategoriasLblNumero
            // 
            cardCategoriasLblNumero.AutoSize = true;
            cardCategoriasLblNumero.BackColor = Color.White;
            cardCategoriasLblNumero.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardCategoriasLblNumero.Location = new Point(20, 38);
            cardCategoriasLblNumero.Name = "cardCategoriasLblNumero";
            cardCategoriasLblNumero.Size = new Size(38, 45);
            cardCategoriasLblNumero.TabIndex = 2;
            cardCategoriasLblNumero.Text = "0";
            // 
            // cardCategoriasLblTitulo
            // 
            cardCategoriasLblTitulo.AutoSize = true;
            cardCategoriasLblTitulo.BackColor = Color.White;
            cardCategoriasLblTitulo.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            cardCategoriasLblTitulo.ForeColor = Color.FromArgb(248, 148, 27);
            cardCategoriasLblTitulo.Location = new Point(20, 19);
            cardCategoriasLblTitulo.Name = "cardCategoriasLblTitulo";
            cardCategoriasLblTitulo.Size = new Size(117, 19);
            cardCategoriasLblTitulo.TabIndex = 1;
            cardCategoriasLblTitulo.Text = "🏷️ Categorias";
            // 
            // pnlCorCategorias
            // 
            pnlCorCategorias.CustomizableEdges = customizableEdges7;
            pnlCorCategorias.FillColor = Color.FromArgb(248, 148, 27);
            pnlCorCategorias.Location = new Point(262, 108);
            pnlCorCategorias.Name = "pnlCorCategorias";
            pnlCorCategorias.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnlCorCategorias.Size = new Size(210, 10);
            pnlCorCategorias.TabIndex = 2;
            // 
            // gridUltimosGames
            // 
            gridUltimosGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUltimosGames.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colCategoryName, colReleaseYear, colIsFeatured, colCreatedAt });
            gridUltimosGames.Location = new Point(32, 281);
            gridUltimosGames.Name = "gridUltimosGames";
            gridUltimosGames.Size = new Size(653, 139);
            gridUltimosGames.TabIndex = 3;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.Width = 50;
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Título";
            colTitle.Name = "colTitle";
            colTitle.Width = 150;
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
            // 
            // colCreatedAt
            // 
            colCreatedAt.HeaderText = "Cadastrado em";
            colCreatedAt.Name = "colCreatedAt";
            colCreatedAt.Resizable = DataGridViewTriState.True;
            colCreatedAt.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DashboardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridUltimosGames);
            Controls.Add(pnlCorCategorias);
            Controls.Add(cardCategorias);
            Controls.Add(cardGames);
            Controls.Add(lblUltimosGames);
            Controls.Add(lblCarregando);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Name = "DashboardUserControl";
            Size = new Size(715, 436);
            Load += DashboardUserControl_Load;
            cardGames.ResumeLayout(false);
            cardGames.PerformLayout();
            cardCategorias.ResumeLayout(false);
            cardCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridUltimosGames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblCarregando;
        private Label cardCategoriasLblDesc;
        private Label lblUltimosGames;
        private Label label9;
        private Label label10;
        private Guna.UI2.WinForms.Guna2Panel cardGames;
        private Label cardGamesLblTitulo;
        private Guna.UI2.WinForms.Guna2Panel cardCategorias;
        private Label cardCategoriasLblTitulo;
        private Label cardGamesLblNumero;
        private Label cardCategoriasLblNumero;
        private Label cardGamesLblDesc;
        private Guna.UI2.WinForms.Guna2Panel pnlCorGames;
        private Guna.UI2.WinForms.Guna2Panel pnlCorCategorias;
        private DataGridView gridUltimosGames;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colCategoryName;
        private DataGridViewTextBoxColumn colReleaseYear;
        private DataGridViewCheckBoxColumn colIsFeatured;
        private DataGridViewTextBoxColumn colCreatedAt;
    }
}
