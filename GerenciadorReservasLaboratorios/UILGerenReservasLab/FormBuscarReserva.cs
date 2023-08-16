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
    public partial class FormBuscarReserva : Form
    {
        public FormBuscarReserva()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                reservaBindingSource.DataSource = new CursoBLL().BuscarTodos();
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
                if (reservaBindingSource.Count == 0)
                    throw new Exception("Não existe reserva listado para ser alterado.");

                int id = ((Reserva)reservaBindingSource.Current).Id;

                using (FormCadastroReservas frm = new FormCadastroReservas(id))
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

        private void buttonAdicionarUsuario_Click(object sender, EventArgs e)
        {

            using (FormBuscarReserva frm = new FormBuscarReserva())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {


            try
            {
                if (reservaBindingSource.Count == 0)
                    throw new Exception("Não existe reserva  para ser excluído.");

                if (reservaBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe reserva para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Reserva)reservaBindingSource.Current).Id;
                new UsuarioBLL().Excluir(id);
                reservaBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
