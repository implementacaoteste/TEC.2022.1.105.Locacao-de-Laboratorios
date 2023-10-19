using Models;
using System;
using BLL;
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
    public partial class FormCadastroCurso : Form
    {
        private int Id;
        private bool alterar;

        public FormCadastroCurso(bool _alterar = false, int _id = 0)
        {
            InitializeComponent();
            Id = _id;
            alterar = _alterar;
            if (alterar)
                cursoBindingSource.DataSource = new CursoBLL().BuscarPorId(_id);
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
        private void buttonSalvarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                Curso _curso = (Curso)cursoBindingSource.Current;
                cursoBindingSource.EndEdit();

                if (Id == 0)
                {
                    _curso = new Curso(); // Crie um novo objeto Curso se for um novo registro.
                    _curso.Nome = nomeTextBox.Text; // Atribua o nome do TextBox ao novo objeto.
                    _curso.Turno = turnoTextBox.Text;
                    new CursoBLL().Inserir(_curso);
                }
                else
                {
                    new CursoBLL().Alterar(_curso);
                }

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void buttonCancelarCurso_Click(object sender, EventArgs e)
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

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastroCurso_Load(object sender, EventArgs e)
        {
            labelMenu.Text = "Cadastro de Curso (Unidade Curricular)";
        }
    }
}
