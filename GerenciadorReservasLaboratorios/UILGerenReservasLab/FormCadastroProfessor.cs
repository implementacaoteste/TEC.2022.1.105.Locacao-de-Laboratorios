using BLL;
using Models;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UILGerenReservasLab
{
    public partial class FormCadastroProfessor : Form
    {
        public int Id;

        public FormCadastroProfessor(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.EndEdit();

                if (Id == 0)
                    new ProfessorBLL().Inserir((Professor)usuarioBindingSource.Current, textBoxConfirmarSenha.Text);
                else
                    new ProfessorBLL().Alterar((Professor)usuarioBindingSource.Current, textBoxConfirmarSenha.Text);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();

            }
            catch (Exception ex)
            {
                if (new TratarErro().GetId(ex) == 1)
                    senhaTextBox.Focus();

                MessageBox.Show(ex.Message);
            }
        }
        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                    usuarioBindingSource.AddNew();
                else
                    usuarioBindingSource.DataSource = new ProfessorBLL().BuscarPorId(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            labelMenu.Text = "Cadastro de Professor";
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
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

        private void FormCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
