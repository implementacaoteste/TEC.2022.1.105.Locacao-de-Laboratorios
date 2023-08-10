using BLL;
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

     
    }
}
