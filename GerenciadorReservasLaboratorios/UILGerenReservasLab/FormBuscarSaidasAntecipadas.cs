﻿using BLL;
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
    public partial class FormBuscarSaidasAntecipadas : Form
    {
        public FormBuscarSaidasAntecipadas()
        {
            InitializeComponent();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 01 } } };

                        saidasAntecipadasBindingSource.DataSource = new SaidasAntecipadasBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        saidasAntecipadasBindingSource.DataSource = new SaidasAntecipadasBLL().BuscarPorNomeAluno(textBoxBuscar.Text);
                        break;
                    case 2:
                        saidasAntecipadasBindingSource.DataSource = new SaidasAntecipadasBLL().BuscarPorNomeProfessor(textBoxBuscar.Text);
                        break;
                    case 3:
                        saidasAntecipadasBindingSource.DataSource = new SaidasAntecipadasBLL().BuscarPorNomeCoordenacao(textBoxBuscar.Text);
                        break;
                    case 4:
                        saidasAntecipadasBindingSource.DataSource = new SaidasAntecipadasBLL().BuscarTodos();
                        break;
                    default:
                        break;

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
                if (saidasAntecipadasBindingSource.Count == 0)
                    throw new Exception("Não existe usuário listado para ser alterado.");

                int id = ((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).Id;

                using (FormCadastroSaidasAntecipadas frm = new FormCadastroSaidasAntecipadas(id))
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

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastroSaidasAntecipadas frm = new FormCadastroSaidasAntecipadas())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (saidasAntecipadasBindingSource.Count == 0)
                    throw new Exception("Não existe usuário listado para ser excluído.");

                if (saidasAntecipadasBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).Id;
                new SaidasAntecipadasBLL().Excluir(id);
                saidasAntecipadasBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSelecionarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se há alguma linha selecionada no DataGridView
                if (saidasAntecipadasDataGridView.SelectedRows.Count > 0)
                {
                    // Obtém o ID do registro selecionado
                    int idSelecionado = Convert.ToInt32(saidasAntecipadasDataGridView.SelectedRows[0].Cells["Id"].Value);

                    // Chama o método BuscarPorId da classe SaidasAntecipadasBLL para obter o registro
                    SaidasAntecipadas saidaAntecipada = new SaidasAntecipadasBLL().BuscarPorId(idSelecionado);

                    // Use o objeto saidaAntecipada para realizar as ações desejadas, por exemplo, preencher campos em um formulário.
                    // Exemplo: textBoxId.Text = saidaAntecipada.Id.ToString();
                }
                else
                {
                    MessageBox.Show("Selecione um registro para continuar.", "Seleção Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void FormBuscarSaidasAntecipadas_Load(object sender, EventArgs e)
        {
            // Carregue o usuário logado.
            Usuario usuarioLogado = new UsuarioBLL().ObterUsuarioLogado();
            List<GrupoUsuario> gruposDoUsuario = usuarioLogado.GrupoUsuarios;
            FormatarDataGridView(saidasAntecipadasDataGridView);
        }
    }
}
