// =============================================================================
// SenacGames.Desktop - Themes/SenacTheme.cs
// =============================================================================
//  CONCEITO: Design System / Theme Manager
//
// Centraliza TODAS as cores, fontes e estilos da aplicação.
// Por que centralizar?
//    Mudança de cor em um lugar  aplica em toda a aplicação
//    Consistência visual garantida
//    Facilita manutenção e customização
//
// Paleta oficial do Senac:
//   Azul Senac:    #004B87 (primário) / #0066CC (variante)
//   Laranja Senac: #FF6600 (destaque) / #FF8C00 (variante)
//   Branco:        #FFFFFF
//   Cinza claro:   #F5F5F5 / #E0E0E0
//   Grafite:       #333333 / #555555
//
// Inspiração:
//   - Portal Senac (https://www.sp.senac.br)
//   - Microsoft Fluent Design System
//   - Material Design
// =============================================================================

namespace SenacGames.Desktop.Themes
{
    /// <summary>
    /// Tema visual oficial do SenacGames Desktop.
    /// Define todas as cores, fontes e dimensões usadas na interface.
    /// </summary>
    public static class SenacTheme
    {
        // =====================================================================
        // PALETA DE CORES SENAC
        // =====================================================================

        /// <summary>Azul Senac primário — usado em sidebar, botões principais</summary>
        public static Color AzulPrimario => Color.FromArgb(0, 75, 135);         // #004B87

        /// <summary>Azul Senac variante — hover, bordas, links</summary>
        public static Color AzulVariante => Color.FromArgb(0, 102, 204);        // #0066CC

        /// <summary>Azul claro — fundo de cards, painéis informativos</summary>
        public static Color AzulClaro => Color.FromArgb(230, 242, 255);         // #E6F2FF

        /// <summary>Laranja Senac — botões de destaque, badges, ícones de alerta</summary>
        public static Color LaranjaPrimario => Color.FromArgb(255, 102, 0);     // #FF6600

        /// <summary>Laranja variante — hover, estados ativos</summary>
        public static Color LaranjaVariante => Color.FromArgb(255, 140, 0);     // #FF8C00

        /// <summary>Laranja suave — fundo de badges de destaque</summary>
        public static Color LaranjaClaro => Color.FromArgb(255, 243, 224);      // #FFF3E0

        /// <summary>Branco puro — fundos principais</summary>
        public static Color Branco => Color.White;

        /// <summary>Cinza claríssimo — fundo da janela principal</summary>
        public static Color CinzaFundo => Color.FromArgb(245, 247, 250);        // #F5F7FA

        /// <summary>Cinza claro — separadores, bordas suaves</summary>
        public static Color CinzaClaro => Color.FromArgb(224, 228, 235);        // #E0E4EB

        /// <summary>Cinza médio — texto secundário, placeholders</summary>
        public static Color CinzaMedio => Color.FromArgb(150, 160, 175);        // #96A0AF

        /// <summary>Grafite — texto principal</summary>
        public static Color GrafiteTexto => Color.FromArgb(51, 61, 75);         // #333D4B

        /// <summary>Grafite escuro — títulos, cabeçalhos</summary>
        public static Color GrafiteEscuro => Color.FromArgb(30, 38, 50);        // #1E2632

        // =====================================================================
        // CORES SEMÂNTICAS (STATUS)
        // =====================================================================

        public static Color Sucesso => Color.FromArgb(40, 167, 69);             // Verde
        public static Color Perigo => Color.FromArgb(220, 53, 69);              // Vermelho
        public static Color Aviso => Color.FromArgb(255, 193, 7);               // Amarelo
        public static Color Info => Color.FromArgb(23, 162, 184);               // Ciano

        // Versões claras das cores semânticas (para fundos de cards)
        public static Color SucessoClaro => Color.FromArgb(212, 237, 218);
        public static Color PerigoClaro => Color.FromArgb(248, 215, 218);
        public static Color AvisoClaro => Color.FromArgb(255, 243, 205);
        public static Color InfoClaro => Color.FromArgb(209, 236, 241);

        // =====================================================================
        // SIDEBAR
        // =====================================================================

        public static Color SidebarFundo => AzulPrimario;
        public static Color SidebarBotaoTexto => Color.White;
        public static Color SidebarBotaoHover => Color.FromArgb(0, 95, 165);    // Azul mais claro
        public static Color SidebarBotaoAtivo => LaranjaPrimario;
        public static Color SidebarDivisor => Color.FromArgb(0, 55, 115);

        // =====================================================================
        // CABEÇALHO (HEADER)
        // =====================================================================

        public static Color HeaderFundo => Color.White;
        public static Color HeaderBorda => CinzaClaro;
        public static Color HeaderTexto => GrafiteEscuro;

        // =====================================================================
        // CARDS (DASHBOARD)
        // =====================================================================

        public static Color CardFundo => Color.White;
        public static Color CardBorda => CinzaClaro;
        public static Color CardSombra => Color.FromArgb(20, 0, 0, 0);

        // =====================================================================
        // FORMULÁRIOS
        // =====================================================================

        public static Color InputFundo => Color.White;
        public static Color InputBorda => CinzaClaro;
        public static Color InputBordaFoco => AzulVariante;
        public static Color InputTexto => GrafiteTexto;
        public static Color InputPlaceholder => CinzaMedio;

        // =====================================================================
        // BOTÕES
        // =====================================================================

        public static Color BotaoPrimarioFundo => AzulPrimario;
        public static Color BotaoPrimarioTexto => Color.White;
        public static Color BotaoPrimarioHover => AzulVariante;

        public static Color BotaoSecundarioFundo => Color.White;
        public static Color BotaoSecundarioTexto => AzulPrimario;
        public static Color BotaoSecundarioBorda => AzulPrimario;

        public static Color BotaoPerigo => Perigo;
        public static Color BotaoSucesso => Sucesso;

        // =====================================================================
        // DATAGRIDVIEW
        // =====================================================================

        public static Color GridCabecalhoFundo => AzulPrimario;
        public static Color GridCabecalhoTexto => Color.White;
        public static Color GridLinhaPar => Color.White;
        public static Color GridLinhaImpar => Color.FromArgb(250, 251, 253);
        public static Color GridLinhaSelecionada => AzulClaro;
        public static Color GridTextoPrincipal => GrafiteTexto;
        public static Color GridBorda => CinzaClaro;

        // =====================================================================
        // TIPOGRAFIA
        // =====================================================================

        /// <summary>Fonte padrão do Windows (Fluent Design)</summary>
        public static string FonteBase => "Segoe UI";

        public static Font FontePequena => new(FonteBase, 8f);
        public static Font FonteNormal => new(FonteBase, 9f);
        public static Font FonteMedia => new(FonteBase, 10f);
        public static Font FonteTitulo => new(FonteBase, 13f, FontStyle.Bold);
        public static Font FonteSubtitulo => new(FonteBase, 11f, FontStyle.Bold);
        public static Font FonteGrande => new(FonteBase, 16f, FontStyle.Bold);
        public static Font FonteNumero => new(FonteBase, 24f, FontStyle.Bold);

        // =====================================================================
        // DIMENSÕES
        // =====================================================================

        /// <summary>Largura da sidebar lateral</summary>
        public static int SidebarLargura => 220;

        /// <summary>Altura do cabeçalho superior</summary>
        public static int HeaderAltura => 60;

        /// <summary>Raio de borda arredondada padrão</summary>
        public static int BorderRadius => 8;

        /// <summary>Espaçamento interno padrão (padding)</summary>
        public static int Padding => 16;

        // =====================================================================
        // MÉTODOS UTILITÁRIOS
        // =====================================================================

        /// <summary>
        /// Aplica o estilo Senac a um DataGridView.
        /// Centraliza toda a configuração visual da grade.
        /// </summary>
        public static void AplicarEstiloGrid(DataGridView grid)
        {
            // Estilo geral
            grid.BackgroundColor = CinzaFundo;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = CinzaClaro;

            // Cabeçalho
            grid.ColumnHeadersDefaultCellStyle.BackColor = GridCabecalhoFundo;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = GridCabecalhoTexto;
            grid.ColumnHeadersDefaultCellStyle.Font = FonteNormal;
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersHeight = 40;
            grid.EnableHeadersVisualStyles = false;

            // Linhas
            grid.DefaultCellStyle.BackColor = GridLinhaPar;
            grid.DefaultCellStyle.ForeColor = GridTextoPrincipal;
            grid.DefaultCellStyle.Font = FonteNormal;
            grid.DefaultCellStyle.SelectionBackColor = GridLinhaSelecionada;
            grid.DefaultCellStyle.SelectionForeColor = GrafiteEscuro;
            grid.DefaultCellStyle.Padding = new Padding(8, 4, 8, 4);

            // Linhas alternadas
            grid.AlternatingRowsDefaultCellStyle.BackColor = GridLinhaImpar;

            // Linha
            grid.RowHeadersVisible = false;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid.RowTemplate.Height = 38;

            // Seleção
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.ReadOnly = true;

            // Visual
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
        }
    }
}
