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
            try
            {
<<<<<<< Updated upstream
                /*
=======
                Predio predio = (Predio)predioBindingSource.Current;

                // Verificar se o campo "nome do prédio" está preenchido
                if (string.IsNullOrEmpty(predio.Nome))
                {
                    MessageBox.Show("O campo 'Nome do Prédio' é um campo obrigatório.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Abortar a operação de salvar
                }

>>>>>>> Stashed changes
                predioBindingSource.EndEdit();

                if (Id == 0)
                    new PredioBLL().Inserir((Predio)predioBindingSource.Current);
                else
<<<<<<< Updated upstream
                    new PredioBLL().Alterar(predio);
                */
=======
                    new PredioBLL().Alterar((Predio)predioBindingSource.Current);

>>>>>>> Stashed changes
                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

