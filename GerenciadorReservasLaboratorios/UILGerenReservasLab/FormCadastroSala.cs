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
    public partial class FormCadastroSala : Form
    {
        public int Id;
        public FormCadastroSala(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void btnSalvarSala_Click(object sender, EventArgs e)
        {
            if (txtNomeSala.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo 'Nome Sala' é obrigatório");

                txtNomeSala.Focus();
                return;
            }
            try
            {
                
                salaBindingSource.EndEdit();

                Sala sala = ((Sala)salaBindingSource.Current);
                if (Id == 0)
                    new SalaBLL().Inserir(sala);
                else
                    new SalaBLL().Alterar(sala);
                
                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnCancelarSala_Click(object sender, EventArgs e)
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
