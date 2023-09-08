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
    public partial class FormConsultaPermissao : Form
    {
        public int Id;
        public int opc;
        private string ultimaBusca;
        private bool buscou;
        public FormConsultaPermissao()
        {
            InitializeComponent();
            ultimaBusca = "";
            buscou = false;
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (permissaoBindingSource.Count > 0)
                {
                    Id = ((Permissao)permissaoBindingSource.Current).Id;
                    Close();
                }
                else
                    MessageBox.Show("Não existe permissão a ser selecionada.");
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
                switch (comboBoxBuscarPermissao.SelectedIndex)
                {
                    case 0:
                        opc = 0;
                        permissaoBindingSource.DataSource = new PermissaoBLL().BuscarTodasPermissoes();
                        break;
                    case 1:
                        opc = 1;
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 01 } } };
                        permissaoBindingSource.DataSource = new PermissaoBLL().BuscarTodasPermissoesPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 2:
                        opc = 2;
                        permissaoBindingSource.DataSource = new PermissaoBLL().BuscarPermissaoPorDescricao(textBoxBuscar.Text);
                        break;
                    default:
                        MessageBox.Show("Escolha uma opção de busca");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaPermissao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.Down)
            {
                permissaoBindingSource.MoveNext();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                permissaoBindingSource.MovePrevious();
                e.Handled = true;
            }
        }

        private void permissaoDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buttonSelecionar_Click(null, null);
        }
        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!buscou || ultimaBusca != textBoxBuscar.Text)
                {
                    buttonBuscar_Click(null, null);
                    ultimaBusca = textBoxBuscar.Text;
                    buscou = true;
                }
                else
                    buttonSelecionar_Click(null, null);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
