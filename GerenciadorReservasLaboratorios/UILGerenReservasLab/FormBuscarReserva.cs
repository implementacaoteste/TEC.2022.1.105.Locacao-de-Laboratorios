using BLL;
using Models;
using System;
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
                reservaBindingSource.DataSource = new ReservaBLL().BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterarReserva_Click(object sender, EventArgs e)
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
        private void buttonExcluirReserva_Click(object sender, EventArgs e)
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
        private void buttonInserirReserva_Click(object sender, EventArgs e)
        {
            using (FormBuscarReserva frm = new FormBuscarReserva())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
