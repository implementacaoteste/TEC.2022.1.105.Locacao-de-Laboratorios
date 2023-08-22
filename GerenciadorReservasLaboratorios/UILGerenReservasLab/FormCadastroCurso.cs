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
    public partial class FormCadastroCurso : Form
    {
        private int Id;
        public FormCadastroCurso(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }
        private void btnSalvarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                Curso _curso = (Curso)cursoBindingSource.Current;
                cursoBindingSource.EndEdit();
                if (Id == 0)
                    new CursoBLL().Inserir(_curso);
                else
                    new CursoBLL().Alterar(_curso);
                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }


        }
        private void btnCancelarCurso_Click(object sender, EventArgs e)
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
