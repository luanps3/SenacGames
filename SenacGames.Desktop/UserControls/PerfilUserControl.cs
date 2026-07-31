// =============================================================================
// SenacGames.Desktop - UserControls/PerfilUserControl.cs
// =============================================================================
//  CONCEITO: UserControl de Perfil do Usuário
//
// Exibe as informações do usuário atualmente logado.
// Dados obtidos do SessionManager (armazenados após o login).
// =============================================================================

using SenacGames.Desktop.Helpers;
using SenacGames.Desktop.Services;
using SenacGames.Desktop.Themes;

namespace SenacGames.Desktop.UserControls
{
    /// <summary>
    /// Tela de perfil do usuário logado.
    /// </summary>
    public partial class PerfilUserControl : UserControl
    {
        // =====================================================================
        // SERVIÇOS (inicializados no Load)
        // =====================================================================

        // =====================================================================
        // CONSTRUTOR
        // =====================================================================

        /// <summary>
        /// Construtor padrão sem parâmetros — compatível com o Designer.
        /// </summary>
        public PerfilUserControl()
        {
            InitializeComponent();
        }

        private void PerfilUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
