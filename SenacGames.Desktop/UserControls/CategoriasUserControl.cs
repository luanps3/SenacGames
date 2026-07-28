using SenacGames.Desktop.DTOs;
using SenacGames.Desktop.Services;
using SenacGames.Desktop.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacGames.Desktop.UserControls
{
    public partial class CategoriasUserControl : UserControl
    {
        private CategoriasApiService _categoriasService = null;
        private List<CategoriaResponseDto> _categorias = new();

        //Estado do formulário: null = modo de listagem, int = ID sendo editado
        private int? _editandoId = null;
        public CategoriasUserControl()
        {
            InitializeComponent();
        }

        private async void CategoriasUserControl_Load(object sender, EventArgs e)
        {
            //Guard: não executa em tempo de design
            if (DesignMode) return;

            //Inicializar o serviço
            _categoriasService = new CategoriasApiService();

            //Aplica o estilo ao DataGridView
            SenacTheme.AplicarEstiloGrid(gridCategorias);

            //Carregar os dados
            await CarregarDadosAsync();
        }

        private async Task CarregarDadosAsync()
        {
            gridCategorias.Rows.Clear();
            try
            {
                _categorias = await _categoriasService.GetAllAsync();
                foreach (var c in _categorias)
                    gridCategorias.Rows.Add(c.Id, c.Name, c.GameCount);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private CategoriaResponseDto? ObterCategoriaSelecionada()
        {
            if (gridCategorias.SelectedRows.Count == 0) return null;
            var id = Convert.ToInt32(gridCategorias.SelectedRows[0].Cells["Id"].Value);
            return _categorias.FirstOrDefault(c => c.Id == id);


        }



        private void btnNova_Click_1(object sender, EventArgs e) => MostrarFormulario(null);


        private void MostrarFormulario(CategoriaResponseDto? categoria)
        {
            _editandoId = categoria?.Id;
            txtNome.Text = categoria?.Name ?? string.Empty;
            lblFormTitulo.Text = categoria == null ? "Nova Categoria" : "Editar Categoria";
            pnlForm.Visible = true;
            txtNome.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var cat = ObterCategoriaSelecionada();
            if (cat == null)
            {
                MessageBox.Show("Selecione uma categoria para editar.", "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            MostrarFormulario(cat);
        }

        private async Task btnExcluir_Click(object sender, EventArgs e)
        {
            var cat = ObterCategoriaSelecionada();
            if (cat == null)
            {
                MessageBox.Show("Selecione uma categoria para excluir.", "Aviso",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return;
            }

            if (cat.GameCount > 0)
            {
                MessageBox.Show(
                    $"A categoria \"{cat.Name}\" possui {cat.GameCount} game(s) vinculado(s). \nRemova os games antes de excluir a categoria", 
                    "Não é possivel excluir",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return;
            }

            var conf = MessageBox.Show($"Excluir a categoria \"{cat.Name}\"?",
                "Confirmar Exclusão", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            return;

            if (conf != DialogResult.Yes) return;

            var (sucess, error) = await _categoriasService.DeleteAsync(cat.Id);
            if (sucess)
            {
                MessageBox.Show(
                   "Categoria Excluída!",
                   "Sucesso",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                await CarregarDadosAsync();
            }
            else
            {
                MessageBox.Show(
                   $"{error}",
                   "Erro",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
           


        }
    }
}
