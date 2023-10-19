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
    public partial class FormBuscarAluno : Form
    {
        public int opc;
        public int id;
        public Aluno AlunoSelecionado { get; private set; }


        public FormBuscarAluno()
        {
            InitializeComponent();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarAlunoPor.SelectedIndex)
                {
                    case 0:
                        opc = 0;
                        if (String.IsNullOrEmpty(textBoxAlunoBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 01 } } };
                        alunoBindingSource.DataSource = new AlunoBLL().BuscarPorId(Convert.ToInt32(textBoxAlunoBuscar.Text));
                        break;
                    case 1:
                        opc = 1;
                        alunoBindingSource.DataSource = new AlunoBLL().BuscarPorMatricula(textBoxAlunoBuscar.Text);
                        break;
                    case 2:
                        opc = 2;
                        alunoBindingSource.DataSource = new AlunoBLL().BuscarPorNome(textBoxAlunoBuscar.Text);
                        break;
                    case 3:
                        opc = 3;
                        alunoBindingSource.DataSource = new AlunoBLL().BuscarTodosAlunos();
                        break;
                    default:
                        MessageBox.Show("Escolha uma opção de busca");
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
                if (alunoBindingSource.Count == 0)
                    throw new Exception("Não existe usuário listado para ser alterado.");

                int id = ((Aluno)alunoBindingSource.Current).Id;

                using (FormCadastroAluno frm = new FormCadastroAluno(true, id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastroAluno frm = new FormCadastroAluno())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (alunoBindingSource.Count == 0)
                    throw new Exception("Não existe usuário listado para ser excluído.");

                if (alunoBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Aluno)alunoBindingSource.Current).Id;
                new UsuarioBLL().Excluir(id);
                alunoBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
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
        private void buttonSelecionarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                alunoBindingSource.EndEdit();

                if (alunoBindingSource.Count > 0)
                {
                    AlunoSelecionado = (Aluno)alunoBindingSource.Current;
                    Close();
                }
                else
                {
                    MessageBox.Show("Nenhum aluno selecionado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void FormBuscarAluno_Load(object sender, EventArgs e)
        {
            FormatarDataGridView(alunoDataGridView); // Este código formata o DataGridView
        }
    }
}
