using Guna.UI2.WinForms;
using SenacGames.Desktop.Helpers;
using SenacGames.Desktop.Services;
using SenacGames.Desktop.Themes;
using SenacGames.Desktop.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacGames.Desktop.Forms
{
    public partial class MainForm : Form
    {
        //=======================================
        // CAMPOS PRIVADOS
        //=======================================

        /// <summary>
        /// UserControl atualmente exibido no painel de conteudo (pnlConteudo)
        /// </summary>
        private UserControl? _controleAtual;

        /// <summary>
        /// Botão da sidebar atualmente ativo.
        /// </summary>
        private Guna2Button? _botaoAtivo;

        /// <summary>
        /// Serviço de autenticação para logout.
        /// </summary>
        private AuthApiService _authService = null;


        /// <summary>
        /// Construtor padrão sem parâmetros
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Guard: não executa em tempo de design
            if (DesignMode) return;

            //Instancia o serviço
            _authService = new AuthApiService();

            // Atualiza o título com a versão
            this.Text = $"SenacGames Desktop - {AppConfig.Version}";

            //Preenche dados dinâmicos de sessão no header
            lblUsuario.Text = $"👷‍ {SessionManager.Instance.GetDisplayName()}";
            lblPerfil.Text = SessionManager.Instance.IsAdmin ? "🔑 Administrador" : "👀 Usuário Comum";
            lblPerfil.ForeColor = SessionManager.Instance.IsAdmin
                ? SenacTheme.LaranjaPrimario
                : SenacTheme.AzulVariante;
            lblSessao.Text = $"🟢 {SessionManager.Instance.GetEmail()}";

            // Configura permissões baseadas no perfil do usuário
            ConfigurarPermissoes();

            //Abre o DashBoard como tela inicial
            NavegarParaDashboard();
        }

        private void ConfigurarPermissoes()
        {
            var isAdmin = SessionManager.Instance.IsAdmin;

            btnCategorias.Visible = isAdmin;
            btnUsuarios.Visible = isAdmin;
        }

        private void NavegarParaDashboard()
        {
            Navegar(new DashboardUserControl(), btnDashboard);
        }

        private void Navegar(UserControl control, Guna2Button? botao = null)
        {
            //Remove o UserControl anterior
            if (_controleAtual != null)
            {
                pnlConteudo.Controls.Remove(_controleAtual);
                _controleAtual.Dispose();
                _controleAtual = null;
            }

            //Adiona o novo UserControl(Tela interna)
            control.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Add(control);
            _controleAtual = control;

            AtualizarBotaoAtivo(botao);
        }
        private void AtualizarBotaoAtivo(Guna2Button? botao)
        {
            if (_botaoAtivo != null)
            {
                _botaoAtivo.FillColor = Color.Transparent;
                _botaoAtivo.ForeColor = Color.White;

                _botaoAtivo = botao;
                if (_botaoAtivo != null)
                {
                    _botaoAtivo.FillColor = Color.FromArgb(0, 50, 110);
                    _botaoAtivo.ForeColor = Color.White;
                    _botaoAtivo.CustomBorderColor = SenacTheme.LaranjaPrimario;

                }
            }
        }

        private async Task btnLogout_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show(
                "Deseja realmente sair do sistema?", 
                "Confirmar Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes) return;

            try
            {
                await _authService.LogoutAsync();
            }
            catch
            {
                // Mesmo se a API falhar, limpa a sessão local
            }
            finally
            {
                SessionManager.Instance.Clear();
                this.Close();
            }
        }
    }
}
