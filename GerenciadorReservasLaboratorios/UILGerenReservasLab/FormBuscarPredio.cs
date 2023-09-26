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
    public partial class FormBuscarPredio : Form
    {
        public Predio PredioSelecionado { get; private set; }
        public int opc;
        public int id;
        public FormBuscarPredio()
        {
            InitializeComponent();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelecionarPredio_Click(object sender, EventArgs e)
        {
            try
            {
                predioBindingSource.EndEdit();

                if (predioBindingSource.Count > 0)
                {
                    PredioSelecionado = (Predio)predioBindingSource.Current;
                    Close();
                }
                else
                {
                    MessageBox.Show("Nenhum predio selecionado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastroPredio frm = new FormCadastroPredio())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            switch (comboBoxBuscarPor.SelectedIndex)
            {
                case 0:
                    opc = 0;
                    if (String.IsNullOrEmpty(txtBuscarPredio.Text))
                        throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 01 } } };
                    predioBindingSource.DataSource = new PredioBLL().BuscarPorId(Convert.ToInt32(txtBuscarPredio.Text));
                    break;
                case 1:
                    opc = 1;
                    predioBindingSource.DataSource = new PredioBLL().BuscarPorNome(txtBuscarPredio.Text);
                    break;
                case 2:
                    opc = 3;
                    predioBindingSource.DataSource = new PredioBLL().BuscarTodos();
                    break;
                default:
                    MessageBox.Show("Escolha uma opção de busca");
                    break;
            }

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (predioBindingSource.Count == 0)
                    throw new Exception("Não existe prédio listado para ser alterado.");

                int id = ((Predio)predioBindingSource.Current).Id;

                using (FormCadastroPredio frm = new FormCadastroPredio(id))
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

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (predioBindingSource.Count == 0)
                    throw new Exception("Não existe prédio listado para ser excluído.");

                if (predioBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Predio)predioBindingSource.Current).Id;
                new PredioBLL().Excluir(id);
                predioBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
