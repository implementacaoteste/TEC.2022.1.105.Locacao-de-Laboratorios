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
        public int Id;
        public FormCadastroDeDisciplina(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void btnSalvarDisciplina_Click(object sender, EventArgs e)
        {

            try
            {
               disciplinaBindingSource.EndEdit();

                if (Id == 0)
                    new DisciplinaBLL().Inserir((Disciplina)disciplinaBindingSource.Current);
                else
                    new DisciplinaBLL().Alterar((Disciplina)disciplinaBindingSource.Current);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        private void FormCadastroDisciplina_Load(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                    disciplinaBindingSource.AddNew();
                else
                    disciplinaBindingSource.DataSource = new DisciplinaBLL().BuscarPorId(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarDisciplina_Click(object sender, EventArgs e)
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
