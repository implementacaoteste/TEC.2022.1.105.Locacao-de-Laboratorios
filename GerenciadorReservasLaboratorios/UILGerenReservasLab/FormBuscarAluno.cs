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

        public FormBuscarAluno()
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

                       alunoBindingSource.DataSource = new AlunoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        alunoBindingSource.DataSource = new AlunoBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;
                    case 2:
                        alunoBindingSource.DataSource = new AlunoBLL().BuscarPorMatricula(textBoxBuscar.Text);
                        break;
                    case 3:
                        alunoBindingSource.DataSource = new AlunoBLL().BuscarTodos();
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

        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                alunoBindingSource.DataSource = new AlunoBLL().BuscarTodos();
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

                using (FormCadastroAluno frm = new FormCadastroAluno(id))
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
    }
}
