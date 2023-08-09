using Models;
using System;
using BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UILGerenReservasLab
{
    public partial class FormCadastroPredio : Form
    {
        public int Id;
        public FormCadastroPredio(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomePredio.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo 'Nome Prédio' é obrigatório");
               
                txtNomePredio.Focus();
                return;
            }
            try
            {
                predioBindingSource.EndEdit();

                Predio predio = ((Predio)predioBindingSource.Current, txtNomePredio.Text);
                if (Id == 0)
                    new PredioBLL().Inserir(predio);
                else
                    new PredioBLL().Alterar(predio);
                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
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

