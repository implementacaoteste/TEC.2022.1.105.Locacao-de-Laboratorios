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

        public FormCadastroSaidasAntecipadas(int _id = 0)
        {
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

            // Se o usuário logado for um professor, preencha o combobox com seu nome.
            if (usuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Professor"))
            {
                // Configure o ComboBox do Professor.
                comboBoxProfessor.DisplayMember = "Nome"; // Substitua "Nome" pelo nome da propriedade que contém o nome do professor.
                comboBoxProfessor.ValueMember = "Id";     // Substitua "Id" pelo nome da propriedade que contém o ID do professor.
                comboBoxProfessor.DataSource = new List<Usuario> { usuarioLogado }; // Mostre apenas o usuário logado.
            }
            // Se o usuário logado for um coordenador, preencha o combobox com uma lista de todos os professores.
            else if (usuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Coordenação" || grupo.NomeGrupo == "Administrador"))
            {
                comboBoxProfessor.DataSource = new UsuarioBLL().BuscarTodos();
            }

            // Configure o ComboBox do Status.
            comboBoxStatus.SelectedIndex = isNewRequest ? 0 : -1; // Se for uma nova solicitação, configure para "em análise".

            // Desabilite o campo do Coordenador para novas solicitações.
            coordenacaotextBox.Enabled = !isNewRequest;
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Quando o usuário selecionar uma opção diferente, atualize a variável de controle.
            isNewRequest = comboBoxStatus.SelectedIndex == 0;
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
                    usuarioBLL.ValidarPermissao(1); // Substitua 1 pelo ID da permissão que você deseja validar.

                    SaidasAntecipadas _saidaAntecipada = new SaidasAntecipadas();
                    // Preencha os campos do objeto SaidasAntecipadas.

                    _saidaAntecipada.IdAluno = idAlunoSelecionado;
                    _saidaAntecipada.IdProfessor = usuarioLogado.Id;
                    // Se for uma nova solicitação, defina o Coordenador como null.

                    _saidaAntecipada.Motivo = motivoTextBox.Text;

                    // Preencher Status com base na variável de controle isNewRequest.
                    _saidaAntecipada.Status = isNewRequest ? comboBoxStatus.Text : "em análise";

                    _saidaAntecipada.DataHoraSaida = DateTime.Now;
                    new SaidasAntecipadasBLL().Inserir(_saidaAntecipada);
                }
                else
                {
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
