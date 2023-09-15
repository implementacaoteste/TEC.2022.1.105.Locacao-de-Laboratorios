using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
                saidasAntecipadasBindingSource.DataSource = new SaidasAntecipadasBLL().BuscarPorId(Id);
            }
        }
        private void FormCadastroSaidasAntecipadas_Load(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                    saidasAntecipadasBindingSource.AddNew();
                else
                {
                    saidasAntecipadasBindingSource.DataSource = new SaidasAntecipadasBLL().BuscarPorId(Id);
                    //alunoTextBox.Text = ((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).Aluno.Nome;
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

                // Se o usuário for um Professor e for uma nova solicitação, desabilite o campo comboBoxCoordenador e configure o ComboBox do Status.
                if (isProfessor && Id == 0)
                {
                    comboBoxCoordenador.Enabled = false;
                    comboBoxStatus.SelectedIndex = 0; // Defina "Em Análise" como a opção selecionada.

                    // Se não for Administrador ou da Coordenação, mostre apenas o usuário logado no ComboBox do Professor.

                    comboBoxProfessor.DisplayMember = "Nome"; // Substitua "Nome" pelo nome da propriedade que contém o nome do professor.
                    comboBoxProfessor.ValueMember = "IdUser";     // Substitua "Id" pelo nome da propriedade que contém o ID do professor.
                    comboBoxProfessor.DataSource = new List<Usuario> { usuarioLogado }; // Mostre apenas o usuário logado.
                }
                else if (isProfessor)
                {
                    // Se for uma edição por um Professor, desabilite os campos que não podem ser editados.
                    comboBoxCoordenador.Enabled = false;
                    comboBoxProfessor.Enabled = false;
                    comboBoxStatus.Enabled = false;
                }
                if (isCoordenacao || isAdmin)
                {
                    comboBoxProfessor.DisplayMember = "Nome"; // Substitua "Nome" pelo nome da propriedade que contém o nome do professor.
                    comboBoxProfessor.ValueMember = "IdUser"; // Substitua "Id" pelo nome da propriedade que contém o ID do professor.
                    comboBoxProfessor.DataSource = new GrupoUsuarioBLL().BuscarUsuariosPorGrupo("Professor");

                    // Se for um Administrador, configure o ComboBox do Coordenador com todos os usuários do grupo "Coordenação".
                    if (isAdmin)
                    {
                        comboBoxCoordenador.DisplayMember = "Nome"; // Substitua "Nome" pelo nome da propriedade que contém o nome do coordenador.
                        comboBoxCoordenador.ValueMember = "IdUser"; // Substitua "Id" pelo nome da propriedade que contém o ID do coordenador.
                        comboBoxCoordenador.DataSource = new GrupoUsuarioBLL().BuscarUsuariosPorGrupo("Coordenação");
                    }
                }
                else if (isColab)
                {
                    // Se for um Colaborador, desabilite a edição de todos os campos.
                    alunoTextBox.Enabled = false;
                    comboBoxCoordenador.Enabled = false;
                    comboBoxProfessor.Enabled = false;
                    comboBoxStatus.Enabled = false;
                    dataHoraSaidaDateTimePicker.Enabled = false;
                    motivoTextBox.Enabled = false;
                }

                // Preencha o campo para Coordenação com o nome do usuário logado se não for um Administrador, Professor ou Colaborador.
                if (!isAdmin && !isColab && !isProfessor)
                {
                    comboBoxCoordenador.Text = usuarioLogado.Nome;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        ((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).IdProfessor = Convert.ToInt32(comboBoxProfessor.SelectedValue); // Define o ID do Professor com base no ComboBox.
                        ((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).IdCoordenacao = usuarioLogado.Id; // Define o ID da Coordenação como o ID do usuário logado.
                    }
                    else if (gruposDoUsuario.Any(grupo => grupo.NomeGrupo == "Administrador"))
                    {
                        // Valide as permissões para a Coordenação, se necessário.
                        ((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).IdProfessor = ((Usuario)comboBoxProfessor.SelectedValue).Id; // Define o ID do Professor com base no ComboBox.
                        ((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).IdCoordenacao = ((Usuario)comboBoxCoordenador.SelectedValue).Id; // Define o ID da Coordenação como o ID do usuário logado.
                    }
                    //((SaidasAntecipadas)saidasAntecipadasBindingSource.Current).IdAluno = AlunoSelecionado.Id;
                    //_saidasAntecipadas.Motivo = motivoTextBox.Text;

                    // Preencher Status com base na variável de controle isNewRequest.
                    _saidasAntecipadas.Status = Id == 0 ? comboBoxStatus.Text : "Em Análise";

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
