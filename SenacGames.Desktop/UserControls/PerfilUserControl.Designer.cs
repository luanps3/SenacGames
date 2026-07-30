// =============================================================================
// SenacGames.Desktop - UserControls/PerfilUserControl.Designer.cs
// =============================================================================
// ️ ARQUIVO GERADO PELO DESIGNER — NÃO EDITE MANUALMENTE
// Toda lógica de negócio deve estar em PerfilUserControl.cs
// =============================================================================

namespace SenacGames.Desktop.UserControls
{
    partial class PerfilUserControl
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
        private Guna.UI2.WinForms.Guna2Panel card;
        private Guna.UI2.WinForms.Guna2Panel pnlAvatar;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblBadge;
        private System.Windows.Forms.Panel sep;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblEmailValor;
        private System.Windows.Forms.Label lblApiLabel;
        private System.Windows.Forms.Label lblApiValor;
        private System.Windows.Forms.Label lblRolesLabel;
        private System.Windows.Forms.Label lblRolesValor;

        // =====================================================================
        // INITIALIZECOMPONENT — formato padrão do Windows Forms Designer
        // =====================================================================
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTitulo = new Label();
            card = new Guna.UI2.WinForms.Guna2Panel();
            pnlAvatar = new Guna.UI2.WinForms.Guna2Panel();
            lblAvatar = new Label();
            lblNome = new Label();
            lblBadge = new Label();
            sep = new Panel();
            lblEmailLabel = new Label();
            lblEmailValor = new Label();
            lblApiLabel = new Label();
            lblApiValor = new Label();
            lblRolesLabel = new Label();
            lblRolesValor = new Label();
            card.SuspendLayout();
            pnlAvatar.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 38, 50);
            lblTitulo.Location = new Point(126, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(520, 36);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "⚙️ Meu Perfil";
            // 
            // card
            // 
            card.BackColor = Color.Transparent;
            card.BorderRadius = 12;
            card.Controls.Add(pnlAvatar);
            card.Controls.Add(lblNome);
            card.Controls.Add(lblBadge);
            card.Controls.Add(sep);
            card.Controls.Add(lblEmailLabel);
            card.Controls.Add(lblEmailValor);
            card.Controls.Add(lblApiLabel);
            card.Controls.Add(lblApiValor);
            card.Controls.Add(lblRolesLabel);
            card.Controls.Add(lblRolesValor);
            card.CustomizableEdges = customizableEdges3;
            card.FillColor = Color.White;
            card.Location = new Point(126, 72);
            card.Name = "card";
            card.ShadowDecoration.Color = Color.FromArgb(10, 0, 0, 0);
            card.ShadowDecoration.CustomizableEdges = customizableEdges4;
            card.ShadowDecoration.Depth = 10;
            card.ShadowDecoration.Enabled = true;
            card.Size = new Size(520, 380);
            card.TabIndex = 1;
            // 
            // pnlAvatar
            // 
            pnlAvatar.BorderRadius = 40;
            pnlAvatar.Controls.Add(lblAvatar);
            pnlAvatar.CustomizableEdges = customizableEdges1;
            pnlAvatar.FillColor = Color.FromArgb(0, 75, 135);
            pnlAvatar.Location = new Point(210, 24);
            pnlAvatar.Name = "pnlAvatar";
            pnlAvatar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlAvatar.Size = new Size(80, 80);
            pnlAvatar.TabIndex = 0;
            // 
            // lblAvatar
            // 
            lblAvatar.Dock = DockStyle.Fill;
            lblAvatar.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblAvatar.ForeColor = Color.White;
            lblAvatar.Location = new Point(0, 0);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(80, 80);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "U";
            lblAvatar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNome.ForeColor = Color.FromArgb(30, 38, 50);
            lblNome.Location = new Point(20, 118);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(460, 30);
            lblNome.TabIndex = 1;
            lblNome.Text = "Usuário";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBadge
            // 
            lblBadge.BackColor = Color.FromArgb(0, 102, 204);
            lblBadge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBadge.ForeColor = Color.White;
            lblBadge.Location = new Point(170, 150);
            lblBadge.Name = "lblBadge";
            lblBadge.Size = new Size(160, 28);
            lblBadge.TabIndex = 2;
            lblBadge.Text = "Perfil";
            lblBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sep
            // 
            sep.BackColor = Color.FromArgb(224, 228, 235);
            sep.Location = new Point(20, 196);
            sep.Name = "sep";
            sep.Size = new Size(460, 1);
            sep.TabIndex = 3;
            // 
            // lblEmailLabel
            // 
            lblEmailLabel.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblEmailLabel.ForeColor = Color.FromArgb(150, 160, 175);
            lblEmailLabel.Location = new Point(20, 216);
            lblEmailLabel.Name = "lblEmailLabel";
            lblEmailLabel.Size = new Size(460, 18);
            lblEmailLabel.TabIndex = 4;
            lblEmailLabel.Text = "E-MAIL";
            // 
            // lblEmailValor
            // 
            lblEmailValor.Font = new Font("Segoe UI", 9.5F);
            lblEmailValor.ForeColor = Color.FromArgb(51, 61, 75);
            lblEmailValor.Location = new Point(20, 234);
            lblEmailValor.Name = "lblEmailValor";
            lblEmailValor.Size = new Size(460, 22);
            lblEmailValor.TabIndex = 5;
            lblEmailValor.Text = "...";
            // 
            // lblApiLabel
            // 
            lblApiLabel.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblApiLabel.ForeColor = Color.FromArgb(150, 160, 175);
            lblApiLabel.Location = new Point(20, 268);
            lblApiLabel.Name = "lblApiLabel";
            lblApiLabel.Size = new Size(460, 18);
            lblApiLabel.TabIndex = 6;
            lblApiLabel.Text = "API CONECTADA";
            // 
            // lblApiValor
            // 
            lblApiValor.Font = new Font("Segoe UI", 9.5F);
            lblApiValor.ForeColor = Color.FromArgb(51, 61, 75);
            lblApiValor.Location = new Point(20, 286);
            lblApiValor.Name = "lblApiValor";
            lblApiValor.Size = new Size(460, 22);
            lblApiValor.TabIndex = 7;
            lblApiValor.Text = "...";
            // 
            // lblRolesLabel
            // 
            lblRolesLabel.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblRolesLabel.ForeColor = Color.FromArgb(150, 160, 175);
            lblRolesLabel.Location = new Point(20, 320);
            lblRolesLabel.Name = "lblRolesLabel";
            lblRolesLabel.Size = new Size(460, 18);
            lblRolesLabel.TabIndex = 8;
            lblRolesLabel.Text = "PERMISSÕES";
            // 
            // lblRolesValor
            // 
            lblRolesValor.Font = new Font("Segoe UI", 9.5F);
            lblRolesValor.ForeColor = Color.FromArgb(51, 61, 75);
            lblRolesValor.Location = new Point(20, 338);
            lblRolesValor.Name = "lblRolesValor";
            lblRolesValor.Size = new Size(460, 22);
            lblRolesValor.TabIndex = 9;
            lblRolesValor.Text = "...";
            // 
            // PerfilUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(lblTitulo);
            Controls.Add(card);
            Name = "PerfilUserControl";
            Padding = new Padding(24);
            Size = new Size(805, 501);
            card.ResumeLayout(false);
            pnlAvatar.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
