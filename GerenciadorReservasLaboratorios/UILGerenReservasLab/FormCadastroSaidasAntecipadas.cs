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
    public partial class FormCadastroSaidasAntecipadas : Form
    {
        public FormCadastroSaidasAntecipadas()
        {
            InitializeComponent();
        }
        private void idAlunoTextBox_TextChanged(object sender, EventArgs e)
        {
            // Abra uma janela de busca de alunos e preencha o campo Aluno ID com o valor selecionado.
            // Exemplo de código para abrir a janela de busca:
            FormBuscarAluno frm = new FormBuscarAluno();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                IdAlunoTextBox.Text = frm.AlunoSelecionado.Id.ToString();
            }
        }
        private void idProfessorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
