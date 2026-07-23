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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlUsuario = new Panel();
            pnlHeader = new Panel();
            pnlLogo = new Panel();
            pnlSidebar = new Panel();
            pnlConteudo = new Panel();
            lblTituloApp = new Label();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUsuario
            // 
            pnlUsuario.Location = new Point(0, 0);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(200, 100);
            pnlUsuario.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(lblTituloApp);
            pnlHeader.Location = new Point(200, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(734, 100);
            pnlHeader.TabIndex = 0;
            // 
            // pnlLogo
            // 
            pnlLogo.Location = new Point(0, 100);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(200, 60);
            pnlLogo.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(guna2Button5);
            pnlSidebar.Controls.Add(guna2Button4);
            pnlSidebar.Controls.Add(guna2Button3);
            pnlSidebar.Controls.Add(guna2Button2);
            pnlSidebar.Controls.Add(guna2Button1);
            pnlSidebar.Location = new Point(0, 160);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 393);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlConteudo
            // 
            pnlConteudo.Location = new Point(206, 106);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(715, 436);
            pnlConteudo.TabIndex = 0;
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
            // btnLogout
            // 
            btnLogout.CustomizableEdges = customizableEdges13;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.Font = new Font("Segoe UI", 9F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(541, 26);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnLogout.Size = new Size(180, 45);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Sair";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges11;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(12, 6);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "Dashboard";
            // 
            // guna2Button2
            // 
            guna2Button2.CustomizableEdges = customizableEdges9;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(12, 57);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button2.Size = new Size(180, 45);
            guna2Button2.TabIndex = 1;
            guna2Button2.Text = "Games";
            // 
            // guna2Button3
            // 
            guna2Button3.CustomizableEdges = customizableEdges7;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.Font = new Font("Segoe UI", 9F);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(12, 108);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button3.Size = new Size(180, 45);
            guna2Button3.TabIndex = 1;
            guna2Button3.Text = "Categorias";
            // 
            // guna2Button4
            // 
            guna2Button4.CustomizableEdges = customizableEdges5;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.Font = new Font("Segoe UI", 9F);
            guna2Button4.ForeColor = Color.White;
            guna2Button4.Location = new Point(12, 159);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button4.Size = new Size(180, 45);
            guna2Button4.TabIndex = 1;
            guna2Button4.Text = "Usuários";
            // 
            // guna2Button5
            // 
            guna2Button5.CustomizableEdges = customizableEdges3;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.Font = new Font("Segoe UI", 9F);
            guna2Button5.ForeColor = Color.White;
            guna2Button5.Location = new Point(12, 210);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button5.Size = new Size(180, 45);
            guna2Button5.TabIndex = 1;
            guna2Button5.Text = "Meu Perfil";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 554);
            Controls.Add(pnlHeader);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlLogo);
            Controls.Add(pnlUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}