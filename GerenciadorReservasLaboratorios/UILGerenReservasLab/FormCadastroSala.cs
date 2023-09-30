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

            if (Id > 0)
            {
                // Busque a sala com base no id e preencha os campos com os dados.
                Sala sala = new SalaBLL().BuscarPorId(Id);
                salaBindingSource.DataSource = sala;
            }
        }

        private void buttonSalvarSala_Click(object sender, EventArgs e)
        {
            if (textBoxNomeSala.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo 'Nome Sala' é obrigatório");

                textBoxNomeSala.Focus();
                return;
            }
            try
            {
                
                salaBindingSource.EndEdit();

                Sala _sala = ((Sala)salaBindingSource.Current);
                if (Id == 0)
                {
                    _sala = new Sala(); // Crie um novo objeto Sala se for um novo registro.
                    _sala.Nome = textBoxNomeSala.Text; // Atribua o nome do TextBox ao novo objeto.
                    _sala.IdPredio = ((Sala)salaBindingSource.Current).IdPredio;

                    new SalaBLL().Inserir(_sala);
                }
                else
                    new SalaBLL().Alterar(_sala);
                
                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void buttonCancelarSala_Click(object sender, EventArgs e)
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

        private void FormCadastroSala_Load(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                salaBindingSource.AddNew();
            }
        }

        private void buttonBuscarPredio_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarPredio frm = new FormBuscarPredio())
                {
                    frm.ShowDialog();
                    if (frm.PredioSelecionado != null)
                    {
                        textBoxPredio.Text = frm.PredioSelecionado.Nome;
                        ((Sala)salaBindingSource.Current).IdPredio = frm.PredioSelecionado.Id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void estadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void tipoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
