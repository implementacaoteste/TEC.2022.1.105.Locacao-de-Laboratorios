using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UILGerenReservasLab
{
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuarioBindingSource.Count == 0)
                    throw new Exception("Não existe usuário listado para ser excluído.");

                if (usuarioBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Usuario)usuarioBindingSource.Current).Id;
                new UsuarioBLL().Excluir(id);
                usuarioBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAdicionarUsuario_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuarioBindingSource.Count == 0)
                    throw new Exception("Não existe usuário listado para ser alterado.");

                int id = ((Usuario)usuarioBindingSource.Current).Id;

                using (FormCadastroUsuario frm = new FormCadastroUsuario(id))
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
        private void buttonAdicionarGrupoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaGrupoUsuario frm = new FormConsultaGrupoUsuario())
                {
                    frm.ShowDialog();

                    int idUsuario = ((Usuario)usuarioBindingSource.Current).Id;
                    int idGrupoUsuarioSelecionado = frm.IdGrupoUsuarioSelecionado;

                    if (idGrupoUsuarioSelecionado != 0)
                    {
                        new UsuarioBLL().AdicionarGrupoUsuario(idUsuario, idGrupoUsuarioSelecionado);
                    }
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExcluirGrupoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (grupoUsuariosBindingSource.Count == 0)
                    throw new Exception("Não existe grupo listado para ser excluído.");

                int idGrupoUsuario = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
                int idUsuario = ((Usuario)usuarioBindingSource.Current).Id;
                new UsuarioBLL().RemoverGrupoUsuario(idUsuario, idGrupoUsuario);
                grupoUsuariosBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormBuscarUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void usuarioDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifique se a célula clicada é válida e não é o cabeçalho.
                if (e.RowIndex >= 0)
                {
                    // Obtenha o objeto Usuario da linha selecionada.
                    Usuario usuarioSelecionado = (Usuario)usuarioBindingSource.List[e.RowIndex];

                    // Use o ID do usuário para buscar os grupos de usuário associados.
                    List<GrupoUsuario> gruposUsuario = new GrupoUsuarioBLL().BuscarGrupoPorIdUsuario(usuarioSelecionado.Id);

                    // Carregue os grupos de usuário na grupoUsuarioDataGridView.
                    grupoUsuariosDataGridView.DataSource = gruposUsuario;
                }
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

        private void FormatarDataGridView2(DataGridView dgv)
        {
            // Configurações gerais
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
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
        private void FormBuscarUsuario_Load(object sender, EventArgs e)
        {
            FormatarDataGridView(usuarioDataGridView);
            FormatarDataGridView2(grupoUsuariosDataGridView);
        }
    }
}
