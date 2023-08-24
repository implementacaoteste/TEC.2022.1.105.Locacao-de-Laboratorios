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
        private int id;
        public FormBuscarCurso(int _id = 0)
        {
            InitializeComponent();
            id = _id;
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

                if (MessageBox.Show("Deseja realmente excluir este registro?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Curso)cursoBindingSource.Current).Id;
                new CursoBLL().Excluir(id);
                cursoBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
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
            buttonBuscar_Click(null, null);
        }
        private void buttonAlterar_Click(object sender, EventArgs e)
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
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //CursoBLL cursoBLL = new CursoBLL();
            //if (buscarTextBox.Text == "")
            //    cursoBindingSource.DataSource = cursoBLL.BuscarTodos();
            //else
            //    cursoBindingSource.DataSource = cursoBLL.BuscarPorNome(buscarTextBox.Text);
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(buscarTextBox.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 01 } } };

                        cursoBindingSource.DataSource = new CursoBLL().BuscarPorId(Convert.ToInt32(buscarTextBox.Text));
                        break;
                    case 1:
                        cursoBindingSource.DataSource = new CursoBLL().BuscarPorNome(buscarTextBox.Text);
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
        private void cursoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //// Verifique se a seleção não está vazia
            //if (cursoDataGridView.SelectedRows.Count > 0)
            //{
            //    // Limpe o conteúdo do textbox de busca
            //    buscarTextBox.Text = "";
            //}
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
