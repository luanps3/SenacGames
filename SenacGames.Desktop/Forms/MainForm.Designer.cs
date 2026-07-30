namespace SenacGames.Desktop.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            pnlUsuario = new Panel();
            lblPerfil = new Label();
            lblUsuario = new Label();
            pnlHeader = new Panel();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            lblTituloApp = new Label();
            pnlLogo = new Panel();
            lblSidebarSub = new Label();
            lblSidebarLogo = new Label();
            pnlSidebar = new Panel();
            btnPerfil = new Guna.UI2.WinForms.Guna2Button();
            lblSessao = new Label();
            btnUsuarios = new Guna.UI2.WinForms.Guna2Button();
            btnCategorias = new Guna.UI2.WinForms.Guna2Button();
            btnGames = new Guna.UI2.WinForms.Guna2Button();
            btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            pnlConteudo = new Panel();
            pnlUsuario.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUsuario
            // 
            pnlUsuario.Controls.Add(lblPerfil);
            pnlUsuario.Controls.Add(lblUsuario);
            pnlUsuario.Location = new Point(0, 0);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(200, 100);
            pnlUsuario.TabIndex = 0;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPerfil.ForeColor = Color.FromArgb(0, 77, 147);
            lblPerfil.Location = new Point(15, 54);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(37, 17);
            lblPerfil.TabIndex = 0;
            lblPerfil.Text = "Perfil";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.FromArgb(0, 77, 147);
            lblUsuario.Location = new Point(15, 26);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(106, 23);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "\U0001f9d1‍💼 Usuário";
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(lblTituloApp);
            pnlHeader.Location = new Point(200, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(811, 100);
            pnlHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BorderColor = Color.Brown;
            btnLogout.BorderRadius = 5;
            btnLogout.CustomizableEdges = customizableEdges1;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.FillColor = Color.Maroon;
            btnLogout.Font = new Font("Segoe UI", 9F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(709, 36);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogout.Size = new Size(90, 33);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Sair";
            btnLogout.Click += btnLogout_Click;
            // 
            // lblTituloApp
            // 
            lblTituloApp.AutoSize = true;
            lblTituloApp.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloApp.ForeColor = Color.FromArgb(0, 77, 147);
            lblTituloApp.Location = new Point(23, 36);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Size = new Size(135, 23);
            lblTituloApp.TabIndex = 0;
            lblTituloApp.Text = "SenacGames";
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.MidnightBlue;
            pnlLogo.Controls.Add(lblSidebarSub);
            pnlLogo.Controls.Add(lblSidebarLogo);
            pnlLogo.Location = new Point(0, 100);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(200, 60);
            pnlLogo.TabIndex = 0;
            // 
            // lblSidebarSub
            // 
            lblSidebarSub.AutoSize = true;
            lblSidebarSub.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSidebarSub.ForeColor = Color.White;
            lblSidebarSub.Location = new Point(15, 33);
            lblSidebarSub.Name = "lblSidebarSub";
            lblSidebarSub.Size = new Size(126, 17);
            lblSidebarSub.TabIndex = 0;
            lblSidebarSub.Text = "Plataforma Desktop";
            // 
            // lblSidebarLogo
            // 
            lblSidebarLogo.AutoSize = true;
            lblSidebarLogo.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSidebarLogo.ForeColor = Color.White;
            lblSidebarLogo.Location = new Point(15, 10);
            lblSidebarLogo.Name = "lblSidebarLogo";
            lblSidebarLogo.Size = new Size(73, 23);
            lblSidebarLogo.TabIndex = 0;
            lblSidebarLogo.Text = "SENAC";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(0, 77, 147);
            pnlSidebar.Controls.Add(btnPerfil);
            pnlSidebar.Controls.Add(lblSessao);
            pnlSidebar.Controls.Add(btnUsuarios);
            pnlSidebar.Controls.Add(btnCategorias);
            pnlSidebar.Controls.Add(btnGames);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Location = new Point(0, 160);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 460);
            pnlSidebar.TabIndex = 0;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = SystemColors.Control;
            btnPerfil.CustomizableEdges = customizableEdges3;
            btnPerfil.DisabledState.BorderColor = Color.DarkGray;
            btnPerfil.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPerfil.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPerfil.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPerfil.FillColor = Color.FromArgb(0, 77, 147);
            btnPerfil.Font = new Font("Segoe UI", 9F);
            btnPerfil.ForeColor = Color.White;
            btnPerfil.Location = new Point(0, 186);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPerfil.Size = new Size(200, 45);
            btnPerfil.TabIndex = 1;
            btnPerfil.Text = "Meu Perfil";
            btnPerfil.Click += btnPerfil_Click;
            // 
            // lblSessao
            // 
            lblSessao.AutoSize = true;
            lblSessao.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblSessao.ForeColor = Color.White;
            lblSessao.Location = new Point(12, 425);
            lblSessao.Name = "lblSessao";
            lblSessao.Size = new Size(16, 16);
            lblSessao.TabIndex = 0;
            lblSessao.Text = "...";
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = SystemColors.Control;
            btnUsuarios.CustomizableEdges = customizableEdges5;
            btnUsuarios.DisabledState.BorderColor = Color.DarkGray;
            btnUsuarios.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUsuarios.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUsuarios.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUsuarios.FillColor = Color.FromArgb(0, 77, 147);
            btnUsuarios.Font = new Font("Segoe UI", 9F);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(0, 141);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnUsuarios.Size = new Size(200, 45);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = SystemColors.Control;
            btnCategorias.CustomizableEdges = customizableEdges7;
            btnCategorias.DisabledState.BorderColor = Color.DarkGray;
            btnCategorias.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCategorias.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCategorias.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCategorias.FillColor = Color.FromArgb(0, 77, 147);
            btnCategorias.Font = new Font("Segoe UI", 9F);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Location = new Point(0, 96);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnCategorias.Size = new Size(200, 45);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorias";
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnGames
            // 
            btnGames.BackColor = SystemColors.Control;
            btnGames.CustomizableEdges = customizableEdges9;
            btnGames.DisabledState.BorderColor = Color.DarkGray;
            btnGames.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGames.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGames.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGames.FillColor = Color.FromArgb(0, 77, 147);
            btnGames.Font = new Font("Segoe UI", 9F);
            btnGames.ForeColor = Color.White;
            btnGames.Location = new Point(0, 51);
            btnGames.Name = "btnGames";
            btnGames.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnGames.Size = new Size(200, 45);
            btnGames.TabIndex = 1;
            btnGames.Text = "Games";
            btnGames.Click += btnGames_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.Control;
            btnDashboard.CustomizableEdges = customizableEdges11;
            btnDashboard.DisabledState.BorderColor = Color.DarkGray;
            btnDashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDashboard.FillColor = Color.FromArgb(0, 77, 147);
            btnDashboard.Font = new Font("Segoe UI", 9F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 6);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnDashboard.Size = new Size(200, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlConteudo
            // 
            pnlConteudo.Location = new Point(206, 106);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(805, 501);
            pnlConteudo.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 619);
            Controls.Add(pnlHeader);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlLogo);
            Controls.Add(pnlUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUsuario;
        private Panel pnlHeader;
        private Panel pnlLogo;
        private Panel pnlSidebar;
        private Panel pnlConteudo;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Label lblTituloApp;
        private Guna.UI2.WinForms.Guna2Button btnPerfil;
        private Guna.UI2.WinForms.Guna2Button btnUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnCategorias;
        private Guna.UI2.WinForms.Guna2Button btnGames;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Label lblSidebarSub;
        private Label lblSidebarLogo;
        private Label lblPerfil;
        private Label lblUsuario;
        private Label lblSessao;
    }
}