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
        public FormCadastroPredio()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomePredio.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo 'Nome Prédio' é obrigatório");
               
                txtNomePredio.Focus();
                return;
            }

        }

       
    }
}

