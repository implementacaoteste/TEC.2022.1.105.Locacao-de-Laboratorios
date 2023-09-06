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
    public partial class FormBuscarPermissao : Form
    {
        public FormBuscarPermissao()
        {
            InitializeComponent();
            permissoesDataGridView.CellClick += new DataGridViewCellEventHandler(permissoesDataGridView_CellClick);
        }
        private void CarregarGruposDeUsuario(int idPermissao)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                List<GrupoUsuario> grupos = grupoUsuarioBLL.BuscarGrupoPor_IdPermissao(idPermissao);

                grupoUsuarioBindingSource.DataSource = grupos;
                grupoUsuarioDataGridView.DataSource = grupoUsuarioBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuscarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                if (radioButton_BuscarTodasPermissoes.Checked)
                {
                    permissoesBindingSource.DataSource = permissaoBLL.BuscarTodasPermissoes();
                }
                else if (radioButton_BuscarPorNome.Checked)
                {
                    permissoesBindingSource.DataSource = permissaoBLL.BuscarPermissaoPorDescricao(textBox1.Text);
                }
                else if (radioButton_BuscarPorId.Checked)
                {
                   permissoesBindingSource.DataSource = permissaoBLL.BuscarTodasPermissoesPorId(Convert.ToInt32(textBox1.Text));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionarPermissao_Click(object sender, EventArgs e)
        {
            using (FormCadastroPermissao frm = new FormCadastroPermissao())
            {
                frm.ShowDialog();
            }
        }

        private void buttonAlterarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ((Permissao)permissoesBindingSource.Current).Id;
                using (FormCadastroPermissao frm = new FormCadastroPermissao(true, id ))
                {
                    frm.ShowDialog();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonExcluirPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                if (permissoesBindingSource.Count == 0)
                {
                    MessageBox.Show("Não foi selecionado grupo para ser excluído!");
                    return;
                }
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                permissaoBLL.Excluir(((Permissao)permissoesBindingSource.Current));
                MessageBox.Show("Permissão excluído com sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionarPermissaoGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultarGruposPermissao frm = new FormConsultarGruposPermissao())
                {
                    frm.ShowDialog();
                    if(frm.Id == 0)
                    {
                        return;
                    }
                    GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                    int idPermissao = ((Permissao)permissoesBindingSource.Current).Id;
                    int idGrupo = frm.Id;
                    grupoUsuarioBLL.AdicionarPermissao(idGrupo, idPermissao);
                    MessageBox.Show("Permissão adicionada ao Grupo com sucesso!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
        private void buttonExcluirPermissaoGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
               PermissaoBLL permissaoBLL = new PermissaoBLL();
                if (permissoesBindingSource.Count > 0 && grupoUsuarioBindingSource.Count > 0)
                {
                    int id_grupo = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
                    int id_permissao = ((Permissao)permissoesBindingSource.Current).Id;
                    if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                    grupoUsuarioBLL.RemoverPermissao(id_grupo, id_permissao);
                    MessageBox.Show("Permissão removida deste Grupo com sucesso.");
                }
                else
                {
                    MessageBox.Show("Grupo de Usuário ou Permissão não selecionado");
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void permissoesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = permissoesDataGridView.Rows[e.RowIndex];
                int idPermissao = Convert.ToInt32(row.Cells["Id"].Value); // Suponha que o nome da coluna do ID seja "Id"

                // Chame um método para carregar os grupos de usuário associados a essa permissão
                CarregarGruposDeUsuario(idPermissao);
            }
        }
    }
}
