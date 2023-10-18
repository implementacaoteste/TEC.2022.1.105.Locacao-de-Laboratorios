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
        public int UserId;

        public FormLogin2()
        {
            InitializeComponent();
            Logou = false;
            UserId = 0;
            textBoxSenha.Text = "";
            textBoxSenha.UseSystemPasswordChar = false;
            textBoxUsuario.Text = "";
            labelErrorMessage.Visible = false;
            this.Show();
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
                if (textBoxUsuario.Text != "" && textBoxUsuario.TextLength > 3)
                {
                    if (textBoxSenha.Text != "")
                    {
                        var usuarioBLL = new UsuarioBLL();
                        usuarioBLL.Autenticar(textBoxUsuario.Text, textBoxSenha.Text);
                        Logou = true;

                        var usuarioLogado = usuarioBLL.ObterUsuarioLogado();
                        if (usuarioLogado != null)
                        {
                            UserId = usuarioLogado.Id;
                            MessageBox.Show($"Bem-vindo {usuarioLogado.Nome}!");
                        }

                        Close();
                    }
                    else
                    {
                        msgError("Favor digitar a senha.");
                    }
                }
                else
                {
                    msgError("Favor digitar a nome de usuário");
                }
            }
            catch (Exception ex)
            {
                labelErrorMessage.Text = "    " + ex.Message;
                labelErrorMessage.Visible = true;
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void msgError(string msg)
        {
            labelErrorMessage.Text = "    " + msg;
            labelErrorMessage.Visible = true;
            labelErrorMessage.ForeColor = Color.Red;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
