using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace UILGerenReservasLab
{
    public partial class FormBuscarDisciplina : Form
    {
        public FormBuscarDisciplina()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarpor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))

                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 31 } } };

                        disciplinaBindingSource.DataSource = new DisciplinaBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        disciplinaBindingSource.DataSource = new DisciplinaBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;

                    case 2:
                        disciplinaBindingSource.DataSource = new DisciplinaBLL().BuscarTodos();
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
                if (disciplinaBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe nenhum registro selecionado para alterar.");
                    return;
                }
                int id = ((Disciplina)disciplinaBindingSource.Current).Id;

                using (FormCadastroDeDisciplina frm = new FormCadastroDeDisciplina(id)) 
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
        private void FormBuscarDisciplina_Load(object sender, EventArgs e)
        {
            comboBoxBuscarpor.SelectedIndex = 3;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroDeDisciplina frm = new FormCadastroDeDisciplina())
                {
                    frm.ShowDialog();
                }

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
                if (disciplinaBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Disciplina)disciplinaBindingSource.Current).Id;
                new DisciplinaBLL().Excluir(id);
                disciplinaBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

    
}
