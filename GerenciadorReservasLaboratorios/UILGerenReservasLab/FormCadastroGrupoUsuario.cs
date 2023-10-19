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
    public partial class FormCadastroGrupoUsuario : Form
    {
        public int Id;
        public FormCadastroGrupoUsuario(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void FormCadastroGrupoUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                    grupoUsuarioBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            labelMenu.Text = "Cadastro de Grupos de Usuário";
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                grupoUsuarioBindingSource.EndEdit();
                if (Id == 0)
                    new GrupoUsuarioBLL().Inserir((GrupoUsuario)grupoUsuarioBindingSource.Current);
                else
                    new GrupoUsuarioBLL().Alterar((GrupoUsuario)grupoUsuarioBindingSource.Current);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroGrupoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
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
