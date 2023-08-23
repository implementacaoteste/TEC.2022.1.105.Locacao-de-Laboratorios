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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            using (FormLogin frm = new FormLogin())
            {
                frm.ShowDialog();
                if (!frm.Logou)
                    Application.Exit();
            }
        }

        private void buttonCurso_Click(object sender, EventArgs e)
        {
            using (FormBuscarCurso frm = new FormBuscarCurso())
            {
                frm.ShowDialog();
            }
        }

        private void buttonReserva_Click(object sender, EventArgs e)
        {
            using (FormBuscarReserva frm = new FormBuscarReserva())
            {
                frm.ShowDialog();
            }
        }

        private void buttonSaidasAntecipadas_Click(object sender, EventArgs e)
        {
            using (FormBuscarSaidasAntecipadas frm = new FormBuscarSaidasAntecipadas())
            {
                frm.ShowDialog();
            }
        }

        private void buttonDisciplina_Click(object sender, EventArgs e)
        {
            using (FormBuscarDisciplina frm = new FormBuscarDisciplina())
            {
                frm.ShowDialog();
            }
        }
    }
}
