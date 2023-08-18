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
    public partial class FormBuscarSaidasAntecipadas : Form
    {
        public FormBuscarSaidasAntecipadas()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                saidasAntecipadasBindingSource.DataSource = new SaidasAntecipadasBLL().BuscarTodos();
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
                if (saidasAntecipadasBindingSource.Count == 0)
                    throw new Exception("Não existe usuário listado para ser alterado.");

                int id = ((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).Id;

                using (FormCadastroSaidasAntecipadas frm = new FormCadastroSaidasAntecipadas(id))
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
            using (FormCadastroSaidasAntecipadas frm = new FormCadastroSaidasAntecipadas())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (saidasAntecipadasBindingSource.Count == 0)
                    throw new Exception("Não existe usuário listado para ser excluído.");

                if (saidasAntecipadasBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).Id;
                new SaidasAntecipadasBLL().Excluir(id);
                saidasAntecipadasBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
