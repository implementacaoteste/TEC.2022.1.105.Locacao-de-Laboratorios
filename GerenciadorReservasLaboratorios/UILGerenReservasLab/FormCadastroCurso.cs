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
          

        }
    }
}
