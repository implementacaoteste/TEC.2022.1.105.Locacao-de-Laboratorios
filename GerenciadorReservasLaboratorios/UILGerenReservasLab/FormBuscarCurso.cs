using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILGerenReservasLab
{
    public partial class FormBuscarCurso : Form
    {
        public Curso CursoSelecionado { get; private set; }

        public FormBuscarCurso()
        {
            InitializeComponent();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 01 } } };

                        cursoBindingSource.DataSource = new CursoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        cursoBindingSource.DataSource = new CursoBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;
                    case 2:
                        cursoBindingSource.DataSource = new CursoBLL().BuscarTodos();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cursoBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro");
                }
                int id = ((Curso)cursoBindingSource.Current).Id; // Use a propriedade correta para obter o ID do curso

                using (FormCadastroCurso frm = new FormCadastroCurso(true, id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cursoBindingSource.Count == 0)
                    throw new Exception("Não existe curso listado para ser excluído.");

                if (cursoBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este curso?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Curso)cursoBindingSource.Current).Id;
                new CursoBLL().Excluir(id);
                cursoBindingSource.RemoveCurrent();

                MessageBox.Show("Curso excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelecionarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                cursoBindingSource.EndEdit();

                if (cursoBindingSource.Count > 0)
                {
                    CursoSelecionado = (Curso)cursoBindingSource.Current;
                    Close();
                }
                else
                {
                    MessageBox.Show("Nenhum curso selecionado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastroCurso frm = new FormCadastroCurso())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(sender, e);
        }

        private void FormatarDataGridView(DataGridView dgv)
        {
            // Configurações gerais
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            // Outras configurações
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.FromArgb(64, 64, 64);
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Defina as configurações do cabeçalho de coluna
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Configurações específicas de cabeçalho de coluna e célula
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 30; // Largura das colunas de cabeçalho de linha
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

            // Configurações de células
            // Configuração do estilo padrão para células do DataGridView	
            dgv.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgv.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dgv.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            // Configuração do estilo do cabeçalho de linha
            dgv.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control;
            dgv.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgv.RowHeadersDefaultCellStyle.ForeColor = SystemColors.WindowText;
            dgv.RowHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgv.RowHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgv.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Outras configurações do cabeçalho de linha
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;

            // Configuração do estilo das células de dados
            dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            dgv.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgv.RowsDefaultCellStyle.ForeColor = SystemColors.Window;
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
        }

        private void FormBuscarCurso_Load(object sender, EventArgs e)
        {
            FormatarDataGridView(cursoDataGridView); // Este código formata o DataGridView
        }
    }
}
