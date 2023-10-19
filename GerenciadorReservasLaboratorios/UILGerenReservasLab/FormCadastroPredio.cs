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
using System.Runtime.InteropServices;

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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Predio _predio = (Predio)predioBindingSource.Current;
                predioBindingSource.EndEdit();

                if (Id == 0)
                {
                    _predio = new Predio(); // Crie um novo objeto Predio se for um novo registro.
                    _predio.Nome = nomeTextBox.Text;
                    _predio.Andares = andaresTextBox.Text;
                    _predio.Descricao = descricaoTextBox.Text;
                    _predio.Estado = estadoTextBox.Text;

                    // Verificar se o campo "nome do prédio" está preenchido
                    if (string.IsNullOrEmpty(_predio.Nome))
                    {
                        MessageBox.Show("O campo 'Nome do Prédio' deve ser preenchido antes de salvar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        nomeTextBox.Focus(); // Colocar o foco no campo de nome
                        return; // Abortar a operação de salvar
                    }
                    else if (string.IsNullOrEmpty(_predio.Andares))
                    {
                        MessageBox.Show("O campo 'Andares' deve ser preenchido antes de salvar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        andaresTextBox.Focus(); // Colocar o foco no campo de nome
                        return; // Abortar a operação de salvar
                    }
                    else if (string.IsNullOrEmpty(_predio.Descricao))
                    {
                        MessageBox.Show("O campo 'Descrição' deve ser preenchido antes de salvar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        descricaoTextBox.Focus(); // Colocar o foco no campo de nome
                        return; // Abortar a operação de salvar
                    }
                    if (string.IsNullOrEmpty(_predio.Estado))
                    {
                        MessageBox.Show("O campo 'Estado' deve ser preenchido antes de salvar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        estadoTextBox.Focus(); // Colocar o foco no campo de nome
                        return; // Abortar a operação de salvar
                    }
                    new PredioBLL().Inserir(_predio);
                    MessageBox.Show("Registro salvo com sucesso!");

                }
                else
                {
                    new PredioBLL().Alterar(_predio);
                    MessageBox.Show("Registro alterado com sucesso!");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
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

        private void andaresTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifique se a tecla pressionada é um dígito (0-9) ou uma tecla de controle.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Se não for um dígito, bloqueie a entrada.
                e.Handled = true;
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastroPredio_Load(object sender, EventArgs e)
        {
            labelMenu.Text = "Cadastro de Predio";
            try
            {
                if (Id == 0)
                    predioBindingSource.AddNew();
                else
                    predioBindingSource.DataSource = new PredioBLL().BuscarPorId(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroPredio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}

