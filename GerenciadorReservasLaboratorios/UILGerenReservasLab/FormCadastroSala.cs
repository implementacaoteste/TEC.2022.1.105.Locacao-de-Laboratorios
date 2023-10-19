using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
                    _sala.Tipo = tipoTextBox.Text;
                    _sala.Descricao = descricaoTextBox.Text;
                    _sala.Estado = estadoTextBox.Text;
                    _sala.Capacidade = Convert.ToInt32(capacidadeTextBox.Text);

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
            labelMenu.Text = "Cadastro de Salas";
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
        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // METHOD TO DRAG THE FORM ---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
