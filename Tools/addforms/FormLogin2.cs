using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UILGerenReservasLab
{
    public partial class FormLogin2 : Form
    {
        public bool Logou;

        public FormLogin2()
        {
            InitializeComponent();
            Logou = false;
        }

        private void pictureBoxSenha_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxSenha.UseSystemPasswordChar = false;
        }

        private void pictureBoxSenha_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxSenha.UseSystemPasswordChar = true;
        }
        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().Autenticar(textBoxUsuario.Text, textBoxSenha.Text);
                Logou = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
