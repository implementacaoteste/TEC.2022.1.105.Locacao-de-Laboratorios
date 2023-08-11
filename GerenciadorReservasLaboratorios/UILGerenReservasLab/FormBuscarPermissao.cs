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
        }

        private void buttonBuscarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                if (radioButton_BuscarTodasPermissoes.Checked)
                {
                    permissaoBindingSource.DataSource = permissaoBLL.BuscarTodasPermissoes();
                }
                else if (radioButton_BuscarPorNome.Checked)
                {
                    permissaoBindingSource.DataSource = permissaoBLL.BuscarPermissao_PorNome(textBox1.Text);
                }
                else if (radioButton_BuscarPorId.Checked)
                {
                   permissaoBindingSource.DataSource = permissaoBLL.BuscarTodasPermissoes_PorId(Convert.ToInt32(textBox1.Text));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionarPermissao_Click(object sender, EventArgs e)
        {
            using (FormCadastrarPermissao frm = new FormCadastrarPermissao())
            {
                frm.ShowDialog();
            }
        }

        private void buttonAlterarPermissao_Click(object sender, EventArgs e)
        {

            try
            {
                int id = ((Permissao)permissaoBindingSource.Current).Id;
                using (FormCadastrarPermissao frm = new FormCadastrarPermissao(true, id ))
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
                if (permissaoBindingSource.Count == 0)
                {
                    MessageBox.Show("Não foi selecionado grupo para ser excluído!");
                    return;
                }
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                permissaoBLL.Excluir(((Permissao)permissaoBindingSource.Current));
                MessageBox.Show("Permissão excluído com sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdionarPermissaoGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultarGruposPermissao frm = new FormConsultarGruposPermissao())
                {
                    frm.ShowDialog();
                    if(frm.id == 0)
                    {
                        return;
                    }
                    GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                    int idPermissao = ((Permissao)permissaoBindingSource.Current).Id;
                    int idGrupo = frm.id;
                    grupoUsuarioBLL.VincularPermissaoGrupo(idGrupo, idPermissao);
                    MessageBox.Show("Permissão adicionada com sucesso!");
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
                if (permissaoBindingSource.Count > 0 && grupoUsuariosBindingSource.Count > 0)
                {
                    int id_grupo = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
                    int id_permissao = ((Permissao)permissaoBindingSource.Current).Id;
                    if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                    grupoUsuarioBLL.RemoverVinculoGrupoPermissao(id_grupo, id_permissao);
                    MessageBox.Show("Grupo removida com sucesso.");
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
    }
}
