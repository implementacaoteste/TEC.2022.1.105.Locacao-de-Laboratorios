using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UILGerenReservasLab
{
    public partial class FormCadastroSaidasAntecipadas : Form
    {
        public int Id;
        private UsuarioBLL usuarioBLL = new UsuarioBLL();

        private bool isProfessor = true;
        private bool isCoordenacao = true;
        private bool isAdmin = true;
        Usuario usuarioLogado;

        public FormCadastroSaidasAntecipadas(int _id = 0)
        {
            InitializeComponent();

            Id = _id;

            if (Id > 0)
            {
                // Busque a saída antecipada com base no Id e preencha os campos com os dados.
                SaidasAntecipadas saidaAntecipada = new SaidasAntecipadasBLL().BuscarPorId(Id);

                if (saidaAntecipada != null)
                {
                    saidasAntecipadasBindingSource.DataSource = saidaAntecipada;
                }
                else
                {
                    MessageBox.Show("Registro não encontrado.");
                    this.Close();
                }
            }
        }
        private void FormCadastroSaidasAntecipadas_Load(object sender, EventArgs e)
        {
            try
            {
                DeterminarTipoDeUsuario();

                if (Id == 0)
                {
                    saidasAntecipadasBindingSource.AddNew();
                    ConfigurarComboBox();
                }
                else
                {
                    ConfigurarComboBox();
                    // Busque todos os dados necessários para preencher os ComboBoxes.
                    List<Usuario> professores = new GrupoUsuarioBLL().BuscarUsuariosPorGrupo("Professor");
                    List<Usuario> coordenadores = new GrupoUsuarioBLL().BuscarUsuariosPorGrupo("Coordenação");

                    // Defina as fontes de dados para os ComboBoxes.
                    comboBoxProfessor.DataSource = professores;
                    comboBoxCoordenador.DataSource = coordenadores;

                    // Preencha os valores selecionados nos ComboBoxes com base nos dados do registro existente.
                    SaidasAntecipadas sa = new SaidasAntecipadasBLL().BuscarPorId(Id);
                    saidasAntecipadasBindingSource.DataSource = sa;
                    alunoTextBox.Text = sa.Aluno.Nome;
                    comboBoxStatus.SelectedText = sa.Status;
                    motivoTextBox.Text = sa.Motivo;

                    // Encontre o professor com o Id correspondente e selecione-o.
                    comboBoxProfessor.SelectedItem = professores.FirstOrDefault(p => p.Id == sa.IdProfessor);

                    // Encontre o coordenador com o Id correspondente e selecione-o.
                    comboBoxCoordenador.SelectedItem = coordenadores.FirstOrDefault(c => c.Id == sa.IdCoordenacao);

                    // Desabilite os ComboBoxes que não podem ser editados.
                    if (isProfessor)
                    {
                        comboBoxCoordenador.Enabled = false; // Bloquear a edição do ComboBox de Coordenação para Professores.
                        comboBoxProfessor.Enabled = false; // Bloquear a edição do ComboBox de Professor para Professores.
                        comboBoxStatus.Enabled = false; // Bloquear a edição do ComboBox de Status para Professores.
                    }
                    else if (isCoordenacao)
                    {
                        comboBoxCoordenador.Enabled = false; // Bloquear a edição do ComboBox de Coordenação para Coordenadores.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeterminarTipoDeUsuario()
        {
            // Carregue o usuário logado.
            usuarioLogado = new UsuarioBLL().ObterUsuarioLogado();
            List<GrupoUsuario> gruposDoUsuario = usuarioLogado.GrupoUsuarios;

            isProfessor = usuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Professor");
            isCoordenacao = usuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Coordenação");
            isAdmin = usuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Administrador");
        }

        // Faz a configuração dos comboBox de Professor e Coordenador para mostrar o nome na tela ao invés do ID
        private void ConfigurarComboBox()
        {
            // Define o nome como a propriedade a ser exibida e o ID como o valor a ser retornado quando uma linha for selecionada.
            // Aqui são propriedades; se estivéssemos vinculando a uma tabela de banco de dados ou
            // consulta, esses poderiam ser nomes de colunas.
            comboBoxProfessor.DisplayMember = "Nome";
            comboBoxProfessor.ValueMember = "IdUser";

            comboBoxCoordenador.DisplayMember = "Nome";
            comboBoxCoordenador.ValueMember = "IdUser";

            DeterminarTipoDeUsuario();

            if (Id == 0)
            {
                // Carregue os valores dos ComboBox Professor e Coordenação de acordo com o tipo de usuário.
                if (isAdmin)
                {
                    comboBoxProfessor.DataSource = new GrupoUsuarioBLL().BuscarUsuariosPorGrupo("Professor");
                    comboBoxCoordenador.DataSource = new GrupoUsuarioBLL().BuscarUsuariosPorGrupo("Coordenação");
                }
                else if (isCoordenacao)
                {
                    comboBoxProfessor.DataSource = new GrupoUsuarioBLL().BuscarUsuariosPorGrupo("Professor");
                    comboBoxCoordenador.DataSource = new List<Usuario> { usuarioLogado };
                }
                else if (isProfessor)
                {
                    comboBoxProfessor.DataSource = new List<Usuario> { usuarioLogado };
                    comboBoxCoordenador.Enabled = false; // Bloquear a edição do ComboBox de Coordenação para Professores.
                }
                // Verifique se os ComboBoxes não estão vazios.
                if (comboBoxProfessor.DataSource != null && comboBoxCoordenador.DataSource != null)
                {
                    // Carregue os dados nos ComboBoxes.
                    comboBoxProfessor.DataSource = comboBoxProfessor.DataSource;
                    comboBoxCoordenador.DataSource = comboBoxCoordenador.DataSource;
                }
            }
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                saidasAntecipadasBindingSource.EndEdit();
                SaidasAntecipadas _saidasAntecipadas = (SaidasAntecipadas)saidasAntecipadasBindingSource.Current;
                DeterminarTipoDeUsuario();

                if (Id == 0)
                {
                    // Realize a validação de permissão antes de inserir a saída antecipada.
                    usuarioBLL.ValidarPermissao(13); // Substitua 13 pelo ID da permissão que você deseja validar.

                    // Define o Id da Coordenacao como null ou Id do usuarioLogado com base na condição.
                    if (isProfessor)
                    {
                        _saidasAntecipadas.IdProfessor = usuarioLogado.Id; // Define o ID do Professor como o ID do usuário logado.
                                                                                                                    // Preencher Status com base na variável de controle isNewRequest.
                        _saidasAntecipadas.Status = Id == 0 ? comboBoxStatus.Text : "Em Análise";
                        //_saidasAntecipadas.IdCoordenacao = null; // Define o ID da Coordenação como null.
                    }
                    else if (isCoordenacao)
                    {
                        // Valide as permissões para a Coordenação, se necessário.
                        _saidasAntecipadas.IdProfessor = ((Usuario)comboBoxProfessor.SelectedValue).Id; // Define o ID do Professor com base no ComboBox.
                        _saidasAntecipadas.IdCoordenacao = usuarioLogado.Id; // Define o ID da Coordenação como o ID do usuário logado.
                    }
                    else if (isAdmin)
                    {
                        // Valide as permissões para a administração, se necessário.
                        _saidasAntecipadas.IdProfessor = ((Usuario)comboBoxProfessor.SelectedValue).Id; // Define o ID do Professor com base no ComboBox.
                        _saidasAntecipadas.IdCoordenacao = ((Usuario)comboBoxCoordenador.SelectedValue).Id; // Define o ID da Coordenação com base no ComboBox.
                    }
                    //((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).IdAluno = AlunoSelecionado.Id;
                    //_saidasAntecipadas.Motivo = motivoTextBox.Text;

                    _saidasAntecipadas.Status = comboBoxStatus.Text;
                    _saidasAntecipadas.Motivo = motivoTextBox.Text;

                    _saidasAntecipadas.DataHoraSaida = DateTime.Now;
                    new SaidasAntecipadasBLL().Inserir(_saidasAntecipadas);
                    MessageBox.Show($"Solicitação de saída antecipada registrada com sucesso por {usuarioLogado.NomeUsuario}!");
                    this.Close();
                }
                else
                {
                    usuarioBLL.ValidarPermissao(14);
                    _saidasAntecipadas.IdProfessor = ((Usuario)comboBoxProfessor.SelectedValue).Id;
                    _saidasAntecipadas.IdCoordenacao = ((Usuario)comboBoxCoordenador.SelectedValue).Id;
                    _saidasAntecipadas.Status = comboBoxStatus.SelectedItem.ToString(); // Obtenha a string selecionada.
                    _saidasAntecipadas.Motivo = motivoTextBox.Text;
                    new SaidasAntecipadasBLL().Alterar(_saidasAntecipadas);
                    MessageBox.Show($"Solicitação de saída antecipada alterada com sucesso por {usuarioLogado.NomeUsuario}!");
                    this.Close();
                }
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

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // METHOD TO DRAG THE FORM ---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
