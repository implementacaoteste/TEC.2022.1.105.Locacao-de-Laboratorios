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
using System.IO;
using System.Runtime.InteropServices;

namespace UILGerenReservasLab
{
    public partial class FormCadastroAluno : Form
    {
        private int Id;
        private string caminhoDaImagem;
        private bool alterar;

        public FormCadastroAluno(bool _alterar = false, int _id = 0)
        {
            InitializeComponent();
            Id = _id;
            alterar = _alterar;
            if (alterar)
                alunoBindingSource.DataSource = new AlunoBLL().BuscarPorId(Id);
        }
        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {
            labelMenu.Text = "Cadastro de Alunos";
        }
        //private void buttonAdicionarFoto_Click(object sender, EventArgs e)
        //{
        //    // Caminho da foto padrão
        //    string caminhoFotoPadrao = @"C:\IMG\Fotos\Alunos\fotoPadrao.png";

        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif|Todos os Arquivos|*.*";
        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        caminhoDaImagem = openFileDialog.FileName;

        //        // Aqui você pode carregar a imagem no PictureBox
        //        pictureBoxAluno.Image = Image.FromFile(caminhoDaImagem);
        //    }
        //    else
        //    {
        //        // Se o caminho da foto for nulo, atribui o caminho da foto padrão
        //        if (caminhoDaImagem == null)
        //        {
        //            caminhoDaImagem = caminhoFotoPadrao;
        //        }
        //    }
        //}

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

        private void buttonSalvarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno _aluno = (Aluno)alunoBindingSource.Current;
                alunoBindingSource.EndEdit();

                if (Id == 0)
                {
                    _aluno = new Aluno();
                    _aluno.Nome = nomeTextBox.Text;
                    _aluno.Email = emailTextBox.Text;
                    _aluno.Matricula = matriculaTextBox.Text;
                    _aluno.EndeFoto = caminhoDaImagem;

                    // Insira o aluno no banco de dados
                    int novoId = new AlunoBLL().Inserir(_aluno);

                    // Atualize o ID do aluno com o ID gerado pelo banco
                    _aluno.Id = novoId;
                }
                else
                {
                    new AlunoBLL().Alterar(_aluno);
                }

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelarAluno_Click(object sender, EventArgs e)
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
