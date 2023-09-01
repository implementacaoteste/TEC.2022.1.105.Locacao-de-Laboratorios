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
    public partial class FormCadastroReservas : Form
    {
        private int Id;
        public FormCadastroReservas(int _id= 0)
        {
            InitializeComponent();
            Id = _id;
        }


        private void FormCadastroReservas_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Reserva _reserva = (Reserva)reservaBindingSource.Current;
                reservaBindingSource.EndEdit();
                if (Id == 0)
                    new ReservaBLL().Inserir(_reserva);
                else
                    new ReservaBLL().Alterar(_reserva);
                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            try
            {
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
