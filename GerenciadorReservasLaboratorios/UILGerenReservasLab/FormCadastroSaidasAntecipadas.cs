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
    public partial class FormCadastroSaidasAntecipadas : Form
    {
        public int Id;
        private UsuarioBLL usuarioBLL = new UsuarioBLL();
        // Variável para rastrear se é uma nova solicitação ou edição.
        private bool isProfessor = true;
        private bool isCoordenacao = true;
        private bool isColab = true;
        private bool isAdmin = true;
        Usuario usuarioLogado;

        public FormCadastroSaidasAntecipadas(int _id = 0)
        {
            InitializeComponent();

            Id = _id;


            if (Id > 0)
            {
                // Busque a saída antecipada com base no id e preencha os campos com os dados.
                SaidasAntecipadas saidasAntecipadas = new SaidasAntecipadasBLL().BuscarPorId(Id);
                saidasAntecipadasBindingSource.DataSource = saidasAntecipadas;
            }
        }
        private void FormCadastroSaidasAntecipadas_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                saidasAntecipadasBindingSource.AddNew();
            else
            {
                saidasAntecipadasBindingSource.DataSource = new SaidasAntecipadasBLL().BuscarPorId(Id);
                alunoTextBox.Text = ((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).Aluno.Nome;
            }

            // Carregue o usuário logado.
            usuarioLogado = new UsuarioBLL().ObterUsuarioLogado();

            // Determine se o usuário logado é um Professor.
            isProfessor = usuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Professor");

            // Determine se o usuário logado é da Coordenação.
            isCoordenacao = usuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Coordenação");

            // Determine se o usuário logado é um Administrador.
            isAdmin = usuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Administrador");

            // Determine se o usuário logado é da Colaborador.
            isColab = usuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Colaborador");

            // Se o usuário for um Professor e for uma nova solicitação, desabilite o campo coordenacaotextBox e configure o ComboBox do Status.
            if (isProfessor && Id == 0)
            {
                coordenacaotextBox.Enabled = false;
                comboBoxStatus.SelectedIndex = 0; // Defina "Em Análise" como a opção selecionada.
            }
            else if (isProfessor)
            {
                // Se for uma edição por um Professor, desabilite os campos que não podem ser editados.
                // Desabilite outros campos que não podem ser editados.

                coordenacaotextBox.Enabled = false;
                comboBoxProfessor.Enabled = false;
                comboBoxStatus.Enabled = false;

            }

            // Se o usuário for da Coordenação, configure o ComboBox do Professor com uma lista de todos os professores.
            //Configure o campo para Coordenação com o nome do usuário logado.
            if (isCoordenacao)
            {
                comboBoxProfessor.DisplayMember = "Nome"; // Substitua "Nome" pelo nome da propriedade que contém o nome do professor.
                comboBoxProfessor.ValueMember = "Id";     // Substitua "Id" pelo nome da propriedade que contém o ID do professor.
                comboBoxProfessor.DataSource = new GrupoUsuarioBLL().BuscarUsuariosPorGrupo("Professor");
                coordenacaotextBox.Text = usuarioLogado.Nome;
            }
            else
            {
                // Se não for da Coordenação, mostre apenas o usuário logado no ComboBox do Professor.
                comboBoxProfessor.DisplayMember = "Nome"; // Substitua "Nome" pelo nome da propriedade que contém o nome do professor.
                comboBoxProfessor.ValueMember = "Id";     // Substitua "Id" pelo nome da propriedade que contém o ID do professor.
                comboBoxProfessor.DataSource = new List<Usuario> { usuarioLogado }; // Mostre apenas o usuário logado.
            }
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                saidasAntecipadasBindingSource.EndEdit();
                SaidasAntecipadas _saidasAntecipadas = (SaidasAntecipadas)saidasAntecipadasBindingSource.Current;
                Usuario usuarioLogado = new UsuarioBLL().ObterUsuarioLogado();
                List<GrupoUsuario> gruposDoUsuario = usuarioLogado.GrupoUsuarios;

                if (Id == 0)
                {
                    // Realize a validação de permissão antes de inserir a saída antecipada.
                    // Define o Id da Coordenacao como null ou Id do usuarioLogado com base na condição.
                    if (gruposDoUsuario.Any(grupo => grupo.NomeGrupo == "Professor"))
                    {
                        usuarioBLL.ValidarPermissao(13); // Substitua 1 pelo ID da permissão que você deseja validar.
                        ((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).IdProfessor = usuarioLogado.Id; // Define o ID do Professor como o ID do usuário logado.
                        //_saidasAntecipadas.IdCoordenacao = null; // Define o ID da Coordenação como null.
                    }
                    else if (gruposDoUsuario.Any(grupo => grupo.NomeGrupo == "Coordenação"))
                    {
                        // Valide as permissões para a Coordenação, se necessário.
                        ((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).IdProfessor = (int)comboBoxProfessor.SelectedValue; // Define o ID do Professor com base no ComboBox.
                        ((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).IdCoordenacao = usuarioLogado.Id; // Define o ID da Coordenação como o ID do usuário logado.
                    }
                    //((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).IdAluno = AlunoSelecionado.Id;
                    //_saidasAntecipadas.Motivo = motivoTextBox.Text;

                    // Preencher Status com base na variável de controle isNewRequest.
                    _saidasAntecipadas.Status = Id == 0 ? comboBoxStatus.Text : "em análise";

                    ((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).DataHoraSaida = DateTime.Now;
                    new SaidasAntecipadasBLL().Inserir(((SaidasAntecipadas)saidasAntecipadasBindingSource.Current));
                }
                else
                {
                    usuarioBLL.ValidarPermissao(14);
                    new SaidasAntecipadasBLL().Alterar(((SaidasAntecipadas)saidasAntecipadasBindingSource.Current));
                }
                MessageBox.Show($"Solicitação de saída antecipada registrada com sucesso por {usuarioLogado.NomeUsuario}!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonBuscarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarAluno frm = new FormBuscarAluno())
                {
                    frm.ShowDialog();
                    if (frm.AlunoSelecionado != null)
                    {
                        alunoTextBox.Text = frm.AlunoSelecionado.Nome;
                        ((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).IdAluno = frm.AlunoSelecionado.Id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
