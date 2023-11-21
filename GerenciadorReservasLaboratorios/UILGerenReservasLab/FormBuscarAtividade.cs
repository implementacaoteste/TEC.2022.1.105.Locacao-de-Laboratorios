﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace UILGerenReservasLab
{
    public partial class FormBuscarAtividade : Form
    {
        public Atividade DisciSelecionado { get; private set; }

        public FormBuscarAtividade()
        {
            InitializeComponent();
        }
        private void FormBuscarDisciplina_Load(object sender, EventArgs e)
        {
            comboBoxBuscarpor.SelectedIndex = 2;
        }

        private bool shouldExecuteSearch = true;

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (shouldExecuteSearch)
                {
                    switch (comboBoxBuscarpor.SelectedIndex)
                    {
                        case 0:
                            if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            {
                                throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 31 } } };
                            }

                            disciplinaBindingSource.DataSource = new AtividadeBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                            break;
                        case 1:
                            disciplinaBindingSource.DataSource = new AtividadeBLL().BuscarPorNome(textBoxBuscar.Text);
                            break;

                        case 2:
                            disciplinaBindingSource.DataSource = new AtividadeBLL().BuscarTodos();
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (disciplinaBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe nenhum registro selecionado para alterar.");
                    return;
                }
                int id = ((Atividade)disciplinaBindingSource.Current).Id;

                using (FormCadastroDeAtividade frm = new FormCadastroDeAtividade(id))
                {
                    frm.ShowDialog();
                    // Defina shouldExecuteSearch com base na ação do formulário de edição
                    shouldExecuteSearch = frm.DialogResult == DialogResult.OK;
                }

                if (shouldExecuteSearch)
                {
                    buttonBuscar_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroDeAtividade frm = new FormCadastroDeAtividade())
                {
                    frm.ShowDialog();
                }

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
                if (disciplinaBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Atividade)disciplinaBindingSource.Current).Id;
                new AtividadeBLL().Excluir(id);
                disciplinaBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
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

        private void comboBoxBuscarpor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpar o DataGridView e o textBoxBuscar antes de carregar novos dados
            disciplinaBindingSource.DataSource = null; // Limpar o DataGridView
            textBoxBuscar.Text = ""; // Limpar o campo de busca
        }
        private void FormatarDataGridView(DataGridView dgv)
        {
            // Configurações gerais
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            // Outras configurações
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.FromArgb(64, 64, 64);
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Defina as configurações do cabeçalho de coluna
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Configurações específicas de cabeçalho de coluna e célula
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 30; // Largura das colunas de cabeçalho de linha
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

            // Configurações de células
            // Configuração do estilo padrão para células do DataGridView	
            dgv.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgv.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dgv.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            // Configuração do estilo do cabeçalho de linha
            dgv.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control;
            dgv.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgv.RowHeadersDefaultCellStyle.ForeColor = SystemColors.WindowText;
            dgv.RowHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgv.RowHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgv.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Outras configurações do cabeçalho de linha
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;

            // Configuração do estilo das células de dados
            dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            dgv.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgv.RowsDefaultCellStyle.ForeColor = SystemColors.Window;
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
        }
        private void FormBuscarDisciplina_Load_1(object sender, EventArgs e)
        {
            FormatarDataGridView(disciplinaDataGridView); // Este código formata o DataGridView
        }

        private void buttonSelecionarDisciplina_Click(object sender, EventArgs e)
        {
            try
            {
                disciplinaBindingSource.EndEdit();

                if (disciplinaBindingSource.Count > 0)
                {
                    DisciSelecionado = (Atividade)disciplinaBindingSource.Current;
                    Close();
                }
                else
                {
                    MessageBox.Show("Nenhuma atividade selecionada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}