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
    public partial class FormBuscarCurso : Form
    {
        private int id;
        public FormBuscarCurso(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (cursoBindingSource.Count == 0)
                    throw new Exception("Não existe curso listado para ser excluído.");

                if (cursoBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Aluno)cursoBindingSource.Current).Id;
                new UsuarioBLL().Excluir(id);
                cursoBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormBuscarCurso frm = new FormBuscarCurso())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cursoBindingSource.Count == 0)
                    throw new Exception("Não existe curso listado para ser alterado.");

                int id = ((Curso)cursoBindingSource.Current).Id;

                using (FormBuscarCurso frm = new FormBuscarCurso(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cursoBindingSource.DataSource = new CursoBLL().BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
