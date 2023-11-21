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
    public partial class FormDashboard : Form
    {
        private Professor UsuarioLogado;
        private bool isProfessor = true;
        private bool isCoordenacao = true;
        private bool isAdmin = true;
        public FormDashboard()
        {
            InitializeComponent();
        }
        public void AtualizarDadosUsuario()
        {
            // O login foi feito com sucesso, agora podemos obter o usuário logado.

            // Carregue o usuário logado.
            UsuarioLogado = new ProfessorBLL().ObterUsuarioLogado();
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            List<GrupoUsuario> gruposDoUsuario = grupoUsuarioBLL.BuscarGrupoPorIdUsuario(UsuarioLogado.Id);
            UsuarioLogado.GrupoUsuarios = gruposDoUsuario;

            isProfessor = UsuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Professor");
            isCoordenacao = UsuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Coordenação");
            isAdmin = UsuarioLogado.GrupoUsuarios.Any(grupo => grupo.NomeGrupo == "Administrador");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss ");
            labelData.Text = DateTime.Now.ToLongDateString();
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

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            // Primeiro, atualize os dados do usuário logado
            AtualizarDadosUsuario();

            if (isAdmin || isCoordenacao)
            {
                // Se o usuário for admin ou coordenação, preencha o DataGridView com as reservas pendentes.
                List<Reserva> listReservas = new ReservaBLL().BuscarTodos();
                List<Reserva> reservasPendentes = listReservas.Where(reserva => reserva.StatusReserva == "Pendente").ToList();
                dadosDataGridView.DataSource = reservasPendentes;
                labelReservasPendentes.Visible = true;
            }
            else if (isProfessor)
            {
                // Se o usuário for um professor, preencha o DataGridView com as reservas feitas pelo professor logado.
                int idProfessorLogado = UsuarioLogado.Id; // Obtenha o ID do professor logado.
                List<Reserva> reservasProfessor = new ReservaBLL().BuscarPorSolicitante(UsuarioLogado.Nome);
                dadosDataGridView.DataSource = reservasProfessor;
                labelMinhasReservas.Visible = true;
            }
            else
            {
                // Se o usuário não se encaixar em nenhuma das categorias anteriores, defina o DataGridView como vazio ou algo apropriado.
                dadosDataGridView.DataSource = null;
                labelReservasPendentes.Visible = true;
            }
                // Chame o método para buscar usuários do grupo "Professor".
                List<Professor> professores = new GrupoUsuarioBLL().BuscarUsuariosPorGrupo("Professor");

                // Obtenha o número total de professores.
                int totalProfessores = professores.Count;

                // Atualize a Label com o número de professores.
                labelProfessor.Text = totalProfessores.ToString();

                // Chame o método para buscar usuários do grupo "Coordenação".
                List<Professor> coordenacao = new GrupoUsuarioBLL().BuscarUsuariosPorGrupo("Coordenação");

                // Obtenha o número total de coordenadores.
                int totalCoord = coordenacao.Count;

                // Atualize a Label com o número de coordenadores.
                labelCoordenador.Text = totalCoord.ToString();

                // Chame o método para buscar todos os alunos.
                List<Aluno> _alunos = new AlunoBLL().BuscarTodosAlunos();

                // Obtenha o número total de alunos.
                int totalAlunos = _alunos.Count;

                // Atualize a Label com o número de alunos.
                labelAlunos.Text = totalAlunos.ToString();

                // Chame o método para buscar todas as reservas.
                List<Reserva> _reservas = new ReservaBLL().BuscarTodos();

                // Obtenha o número total de reservas.
                int totalReservas = _reservas.Count;

                // Atualize a Label com o número de reservas feitas.
                labelReservas.Text = totalReservas.ToString();

                FormatarDataGridView(dadosDataGridView);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
