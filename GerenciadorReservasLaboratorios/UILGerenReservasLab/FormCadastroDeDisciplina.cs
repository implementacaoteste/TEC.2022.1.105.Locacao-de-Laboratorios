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
    public partial class FormCadastroDeDisciplina : Form
    {
        private int id;
        public Curso CursoSelecionado { get; private set; }
        public FormCadastroDeDisciplina(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                Disciplina _disciplina = (Disciplina)disciplinaBindingSource.Current;
                disciplinaBindingSource.EndEdit();

                if (id == 0)
                {
                    _disciplina = new Disciplina(); // Crie um novo objeto Curso se for um novo registro.
                    _disciplina.Nome = nomeTextBox.Text; // Atribua o nome do TextBox ao novo objeto.;
                    new DisciplinaBLL().Inserir(_disciplina);
                }
                else
                {
                    new DisciplinaBLL().Alterar(_disciplina);
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
                    disciplinaBindingSource.DataSource = new DisciplinaBLL().BuscarPorId(id);
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

        private void buttonBuscarIdCurso_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarCurso frm = new FormBuscarCurso())
                {
                    frm.ShowDialog();
                    if (frm.CursoSelecionado != null)
                    {
                        CursoSelecionado = frm.CursoSelecionado;
                        idCursoTextBox.Text = Convert.ToString(CursoSelecionado.Id);
                    }
                }
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
    }
    
}
