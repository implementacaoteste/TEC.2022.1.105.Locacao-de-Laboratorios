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
    public partial class FormCadastroDeAtividade : Form
    {
        private int id;
        public Turma CursoSelecionado { get; private set; }
        public FormCadastroDeAtividade(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                Atividade _disciplina = (Atividade)disciplinaBindingSource.Current;
                disciplinaBindingSource.EndEdit();

                if (id == 0)
                {
                    _disciplina = new Atividade(); // Crie um novo objeto Turma se for um novo registro.
                    _disciplina.Nome = nomeTextBox.Text; // Atribua o nome do TextBox ao novo objeto.;
                    new AtividadeBLL().Inserir(_disciplina);
                }
                else
                {
                    new AtividadeBLL().Alterar(_disciplina);
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
        private void FormCadastroDisciplina_Load(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                    disciplinaBindingSource.AddNew();
                else
                    disciplinaBindingSource.DataSource = new AtividadeBLL().BuscarPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
