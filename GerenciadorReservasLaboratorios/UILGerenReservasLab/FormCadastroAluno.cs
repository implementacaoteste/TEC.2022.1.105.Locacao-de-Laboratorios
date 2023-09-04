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
        private int id;

        public FormCadastroAluno(int _id = 0)
        {
            InitializeComponent();
            id = _id;

            if (id > 0)
            {
                // Busque o aluno com base no id e preencha os campos com os dados.
                Aluno aluno = new AlunoBLL().BuscarPorId(id);
                alunoBindingSource.DataSource = aluno;
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno _aluno = (Aluno)alunoBindingSource.Current;
                alunoBindingSource.EndEdit();

                if (id == 0)
                {
                    _aluno = new Aluno(); // Crie um novo objeto Aluno se for um novo registro.
                    _aluno.Nome = nomeTextBox.Text; // Atribua o nome do TextBox ao novo objeto.;
                    _aluno.Email = emailTextBox.Text;
                    _aluno.Matricula = matriculaTextBox.Text;
                    new AlunoBLL().Inserir(_aluno);
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
                throw;
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
    }
}
