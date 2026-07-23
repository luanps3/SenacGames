namespace SenacGames.Desktop.Forms
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pbLogo = new PictureBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            lblBemVindo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTextoFacaLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnSeparador = new Panel();
            lblEmail = new Label();
            lblSenha = new Label();
            pnSeparador2 = new Panel();
            lblProblemas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblApi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblVersao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblErro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblCarregando = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(23, 49);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(99, 62);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 5;
            txtEmail.CustomizableEdges = customizableEdges1;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(18, 174);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "seuemail@senacgames.com";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtEmail.Size = new Size(357, 36);
            txtEmail.TabIndex = 3;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.BorderRadius = 5;
            txtSenha.CustomizableEdges = customizableEdges3;
            txtSenha.DefaultText = "";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Segoe UI", 9F);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(18, 239);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "•••••••••••";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSenha.Size = new Size(357, 36);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // btnEntrar
            // 
            btnEntrar.BorderRadius = 10;
            btnEntrar.CustomizableEdges = customizableEdges5;
            btnEntrar.DisabledState.BorderColor = Color.DarkGray;
            btnEntrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEntrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEntrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEntrar.FillColor = Color.FromArgb(0, 77, 147);
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(18, 307);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEntrar.Size = new Size(357, 53);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.Click += btnEntrar_Click;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 15;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnFechar
            // 
            btnFechar.DisabledState.BorderColor = Color.DarkGray;
            btnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFechar.FillColor = Color.Maroon;
            btnFechar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(347, 9);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnFechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnFechar.Size = new Size(28, 28);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "X";
            btnFechar.Click += btnFechar_Click;
            // 
            // lblBemVindo
            // 
            lblBemVindo.BackColor = Color.Transparent;
            lblBemVindo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBemVindo.ForeColor = Color.FromArgb(0, 77, 147);
            lblBemVindo.Location = new Point(141, 49);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(156, 39);
            lblBemVindo.TabIndex = 6;
            lblBemVindo.Text = "Bem-Vindo!";
            // 
            // lblTextoFacaLogin
            // 
            lblTextoFacaLogin.BackColor = Color.Transparent;
            lblTextoFacaLogin.ForeColor = SystemColors.ControlDark;
            lblTextoFacaLogin.Location = new Point(141, 88);
            lblTextoFacaLogin.Name = "lblTextoFacaLogin";
            lblTextoFacaLogin.Size = new Size(172, 17);
            lblTextoFacaLogin.TabIndex = 7;
            lblTextoFacaLogin.Text = "Faça login com sua conta Senac";
            lblTextoFacaLogin.TextAlignment = ContentAlignment.TopCenter;
            // 
            // pnSeparador
            // 
            pnSeparador.BackColor = SystemColors.ActiveCaption;
            pnSeparador.BorderStyle = BorderStyle.FixedSingle;
            pnSeparador.ForeColor = SystemColors.MenuHighlight;
            pnSeparador.Location = new Point(23, 133);
            pnSeparador.Name = "pnSeparador";
            pnSeparador.Size = new Size(360, 1);
            pnSeparador.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(18, 156);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSenha.Location = new Point(18, 221);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(41, 15);
            lblSenha.TabIndex = 9;
            lblSenha.Text = "Senha";
            // 
            // pnSeparador2
            // 
            pnSeparador2.BackColor = SystemColors.ActiveCaption;
            pnSeparador2.BorderStyle = BorderStyle.FixedSingle;
            pnSeparador2.ForeColor = SystemColors.MenuHighlight;
            pnSeparador2.Location = new Point(18, 390);
            pnSeparador2.Name = "pnSeparador2";
            pnSeparador2.Size = new Size(360, 1);
            pnSeparador2.TabIndex = 8;
            // 
            // lblProblemas
            // 
            lblProblemas.BackColor = Color.Transparent;
            lblProblemas.ForeColor = SystemColors.ControlDark;
            lblProblemas.Location = new Point(18, 407);
            lblProblemas.Name = "lblProblemas";
            lblProblemas.Size = new Size(326, 17);
            lblProblemas.TabIndex = 7;
            lblProblemas.Text = "Problemas para acessar? Contate o administrador do sistema.";
            lblProblemas.TextAlignment = ContentAlignment.TopCenter;
            // 
            // lblApi
            // 
            lblApi.BackColor = Color.Transparent;
            lblApi.ForeColor = SystemColors.ControlDark;
            lblApi.Location = new Point(18, 433);
            lblApi.Name = "lblApi";
            lblApi.Size = new Size(36, 17);
            lblApi.TabIndex = 7;
            lblApi.Text = "API: ...";
            lblApi.TextAlignment = ContentAlignment.TopCenter;
            // 
            // lblVersao
            // 
            lblVersao.BackColor = Color.Transparent;
            lblVersao.ForeColor = SystemColors.ControlDark;
            lblVersao.Location = new Point(80, 471);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(228, 17);
            lblVersao.TabIndex = 7;
            lblVersao.Text = "Versão: 1.0.0 | ©️ Senac São Miguel Paulista";
            lblVersao.TextAlignment = ContentAlignment.TopCenter;
            // 
            // lblErro
            // 
            lblErro.BackColor = Color.Transparent;
            lblErro.ForeColor = Color.Maroon;
            lblErro.Location = new Point(18, 451);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(24, 17);
            lblErro.TabIndex = 7;
            lblErro.Text = "Erro";
            lblErro.TextAlignment = ContentAlignment.TopCenter;
            lblErro.Visible = false;
            // 
            // lblCarregando
            // 
            lblCarregando.BackColor = Color.Transparent;
            lblCarregando.ForeColor = SystemColors.ControlDark;
            lblCarregando.Location = new Point(158, 366);
            lblCarregando.Name = "lblCarregando";
            lblCarregando.Size = new Size(84, 17);
            lblCarregando.TabIndex = 7;
            lblCarregando.Text = "Autenticando...";
            lblCarregando.TextAlignment = ContentAlignment.TopCenter;
            lblCarregando.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 502);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(pnSeparador2);
            Controls.Add(pnSeparador);
            Controls.Add(lblVersao);
            Controls.Add(lblErro);
            Controls.Add(lblApi);
            Controls.Add(lblCarregando);
            Controls.Add(lblProblemas);
            Controls.Add(lblTextoFacaLogin);
            Controls.Add(lblBemVindo);
            Controls.Add(btnFechar);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(pbLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTextoFacaLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBemVindo;
        private Panel pnSeparador;
        private Label lblSenha;
        private Label lblEmail;
        private Panel pnSeparador2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProblemas;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblApi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVersao;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblErro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCarregando;
    }
}