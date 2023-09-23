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
    public partial class FormBuscarSala : Form
    {
        public FormBuscarSala()
        {
            InitializeComponent();
        }
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastroSala frm = new FormCadastroSala())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(txtBuscarSala.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 01 } } };

                        salaBindingSource.DataSource = new SalaBLL().BuscarPorId(Convert.ToInt32(txtBuscarSala.Text));
                        break;
                    case 1:
                        salaBindingSource.DataSource = new AlunoBLL().BuscarPorNome(txtBuscarSala.Text);
                        break;
                    case 2:
                        salaBindingSource.DataSource = new SalaBLL().BuscarTodos();
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
                if (salaBindingSource.Count == 0)
                    throw new Exception("Não existe Sala listada para ser alterada.");

                int id = ((Sala)salaBindingSource.Current).Id;

                using (FormCadastroSala frm = new FormCadastroSala(id))
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

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (salaBindingSource.Count == 0)
                    throw new Exception("Não existe Sala listada para ser excluída.");

                if (salaBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Sala)salaBindingSource.Current).Id;
                new UsuarioBLL().Excluir(id);
                salaBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
