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
        public Aluno AlunoSelecionado { get; private set; }
        private int idAlunoSelecionado;
        // Variável para rastrear se é uma nova solicitação ou edição.
        private bool isNewRequest = true;
        private bool isProfessor = true;
        private bool isCoordenacao = true;

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
            // Carregue o usuário logado.
            Usuario usuarioLogado = new UsuarioBLL().ObterUsuarioLogado();

            // Determine se o usuário logado é um Professor.
            isProfessor = usuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Professor");

            // Determine se o usuário logado é da Coordenação.
            isCoordenacao = usuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Coordenação");

            // Se o usuário for um Professor e for uma nova solicitação, desabilite o campo coordenacaotextBox e configure o ComboBox do Status.
            if (isProfessor && isNewRequest)
            {
                coordenacaotextBox.Enabled = false;
                comboBoxStatus.SelectedIndex = 0; // Defina "Em Análise" como a opção selecionada.
            }
            else if (isProfessor && !isNewRequest)
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
                SaidasAntecipadas _saidasAntecipadas = (SaidasAntecipadas)saidasAntecipadasBindingSource.Current;
                saidasAntecipadasBindingSource.EndEdit();
                Usuario usuarioLogado = new UsuarioBLL().ObterUsuarioLogado();
                string nomeDoUsuario = usuarioLogado.NomeUsuario; // Obtenha o nome do usuário pelo ID.

                if (Id == 0)
                {
                    isNewRequest = true;

                    // Realize a validação de permissão antes de inserir a saída antecipada.
                    // Define o Id da Coordenacao como null ou Id do usuarioLogado com base na condição.
                    if (usuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Professor"))
                    {
                        usuarioBLL.ValidarPermissao(13); // Substitua 1 pelo ID da permissão que você deseja validar.
                        _saidasAntecipadas.IdProfessor = usuarioLogado.Id; // Define o ID do Professor como o ID do usuário logado.
                        //_saidasAntecipadas.IdCoordenacao = null; // Define o ID da Coordenação como null.
                    }
                    else if (usuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Coordenação"))
                    {
                        // Valide as permissões para a Coordenação, se necessário.
                        _saidasAntecipadas.IdProfessor = (int)comboBoxProfessor.SelectedValue; // Define o ID do Professor com base no ComboBox.
                        _saidasAntecipadas.IdCoordenacao = usuarioLogado.Id; // Define o ID da Coordenação como o ID do usuário logado.
                    }
                    _saidasAntecipadas.IdAluno = idAlunoSelecionado;
                    _saidasAntecipadas.Motivo = motivoTextBox.Text;

                    // Preencher Status com base na variável de controle isNewRequest.
                    _saidasAntecipadas.Status = isNewRequest ? comboBoxStatus.Text : "em análise";

                    _saidasAntecipadas.DataHoraSaida = DateTime.Now;
                    new SaidasAntecipadasBLL().Inserir(_saidasAntecipadas);
                }
                else
                {
                    usuarioBLL.ValidarPermissao(14);
                    isNewRequest = false;
                    new SaidasAntecipadasBLL().Alterar(_saidasAntecipadas);
                }
                MessageBox.Show($"Solicitação de saída antecipada registrada com sucesso por {nomeDoUsuario}!");
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
                        AlunoSelecionado = frm.AlunoSelecionado;
                        alunoTextBox.Text = AlunoSelecionado.Nome;

                        // Armazene o ID do aluno selecionado.
                        idAlunoSelecionado = AlunoSelecionado.Id;
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
