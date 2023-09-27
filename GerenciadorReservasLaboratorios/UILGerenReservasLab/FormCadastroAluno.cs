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
    public partial class FormCadastroAluno : Form
    {
        private int Id;

        public FormCadastroAluno(int _id = 0)
        {
            InitializeComponent();
            Id = _id;

            if (Id > 0)
            {
                // Busque o aluno com base no id e preencha os campos com os dados.
                Aluno aluno = new AlunoBLL().BuscarPorId(Id);
                alunoBindingSource.DataSource = aluno;
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
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

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {
            labelMenu.Text = "Cadastro de Alunos";
        }

    }
}
