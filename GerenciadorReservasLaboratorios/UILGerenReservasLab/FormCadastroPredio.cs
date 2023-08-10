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
                Predio predio = (Predio)predioBindingSource.Current;

                // Verificar se o campo "nome do prédio" está preenchido
                if (string.IsNullOrEmpty(predio.Nome))
                {
                    MessageBox.Show("O campo 'Nome do Prédio' deve ser preenchido antes de salvar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Abortar a operação de salvar
                }

                predioBindingSource.EndEdit();

                if (Id == 0)
                    new PredioBLL().Inserir((Predio)predioBindingSource.Current);
                else
                    new PredioBLL().Alterar((Predio)predioBindingSource.Current);

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

