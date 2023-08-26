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
    public partial class FormModel : Form
    {
        public int Id;
        public FormModel(int x = 0)
        {
            InitializeComponent();
            Id = x;
        }
    }
}
