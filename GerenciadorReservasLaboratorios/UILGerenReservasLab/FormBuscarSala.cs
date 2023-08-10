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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(txtBuscarSala.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 01 } } };

                        salaBindingSource.DataSource = new AlunoBLL().BuscarPorId(Convert.ToInt32(txtBuscarSala.Text));
                        break;
                    case 1:
                        salaBindingSource.DataSource = new AlunoBLL().BuscarPorNome(txtBuscarSala.Text);
                        break;
                    case 2:
                        salaBindingSource.DataSource = new AlunoBLL().BuscarPorMatricula(txtBuscarSala.Text);
                        break;
                    case 3:
                        salaBindingSource.DataSource = new AlunoBLL().BuscarTodos();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
           
        }
    }
}
