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
    public partial class FormCadastroReservas : Form
    {
        public int Id;
        private UsuarioBLL usuarioBLL = new UsuarioBLL();
        Usuario usuarioLogado;

        // Variável de instância para armazenar a hora selecionada
        private TimeSpan horaSelecionada;

        private bool isProfessor = true;
        private bool isCoordenacao = true;
        private bool isAdmin = true;

        public FormCadastroReservas(int _id = 0)
        {
            InitializeComponent();
            Id = _id;

            if (Id > 0)
            {
                // Busque a reserva com base no Id e preencha os campos com os dados.
                Reserva reserva = new ReservaBLL().BuscarPorId(Id);

                if (reserva != null)
                {
                    reservaBindingSource.DataSource = reserva;
                }
                else
                {
                    MessageBox.Show("Registro não encontrado.");
                    this.Close();
                }
            }
        }

        private void FormCadastroReservas_Load(object sender, EventArgs e)
        {
            DeterminarTipoDeUsuario();

            if (Id == 0)
            {
                // Carregue os dados para preencher os ComboBoxes.
                CarregarComboBoxSolicitante();
                CarregarComboBoxSala();
                CarregarComboBoxCurso();
                CarregarComboBoxDisciplina();

                reservaDataDateTimePicker.Enabled = false;
                reservaHoraDateTimePicker.Enabled = false;

                // Desabilite o groupBoxLiberarChave por padrão.
                groupBoxLiberarChave.Enabled = false;

                if (isProfessor)
                {
                    // Configurar comboBoxStatus com o valor "Pendente" se o usuário for um professor.
                    comboBoxStatus.DataSource = new List<string> { "Pendente" };
                }
            }
            else
            {
                // Carregue os dados necessários para preencher os ComboBoxes.
                CarregarComboBoxSolicitante();
                CarregarComboBoxSala();
                CarregarComboBoxCurso();
                CarregarComboBoxDisciplina();

                // Obtenha a reserva existente do banco de dados com base no Id.
                Reserva reserva = new ReservaBLL().BuscarPorId(Id);

                if (reserva != null)
                {
                    reservaBindingSource.DataSource = reserva;
                }
                else
                {
                    MessageBox.Show("Registro não encontrado.");
                    this.Close();
                }
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

        private void CarregarComboBoxSolicitante()
        {
            if (Id == 0)
            {
                if(isCoordenacao || isAdmin)
                {
                    // Carregue os usuários do banco de dados.
                    List<Usuario> usuarios = new UsuarioBLL().BuscarTodos();

                    // Defina a fonte de dados para o ComboBox de solicitante.
                    comboBoxSolicitante.DisplayMember = "Nome";
                    comboBoxSolicitante.ValueMember = "Id";
                    comboBoxSolicitante.DataSource = usuarios;
                }
                else if (isProfessor)
                {
                    // Usuário é professor
                    comboBoxSolicitante.DisplayMember = "Nome";
                    comboBoxSolicitante.ValueMember = "Id";
                    comboBoxSolicitante.DataSource = new List<Usuario> { usuarioLogado }; // Definir a fonte dos dados
                }
            }
        }
        private void CarregarComboBoxResponsavel()
        {
            if (Id == 0)
            {
                if(isCoordenacao || isAdmin)
                {
                    // Defina a fonte de dados para o ComboBox de solicitante.
                    comboBoxResponsavel.DisplayMember = "Nome";
                    comboBoxResponsavel.ValueMember = "Id";
                    comboBoxResponsavel.DataSource = new List<Usuario> { usuarioLogado };
                }
                else if (isProfessor)
                {
                    comboBoxResponsavel.DataSource = null; // Limpar fonte de dados
                    comboBoxResponsavel.Enabled = false; // Desativar o ComboBox
                }
            }
        }
        private void CarregarComboBoxSala()
        {
            // Carregue as salas do banco de dados.
            List<Sala> salas = new SalaBLL().BuscarTodos();

            // Defina a fonte de dados para o ComboBox de sala.
            comboBoxSala.DisplayMember = "Nome";
            comboBoxSala.ValueMember = "Id";
            comboBoxSala.DataSource = salas;
        }

        private void CarregarComboBoxCurso()
        {
            // Carregue os cursos do banco de dados.
            List<Curso> cursos = new CursoBLL().BuscarTodos();

            // Defina a fonte de dados para o ComboBox de curso.
            comboBoxCurso.DisplayMember = "Nome";
            comboBoxCurso.ValueMember = "Id";
            comboBoxCurso.DataSource = cursos;
        }

        private void CarregarComboBoxDisciplina()
        {
            // Carregue as disciplinas do banco de dados.
            List<Disciplina> disciplinas = new DisciplinaBLL().BuscarTodos();

            // Defina a fonte de dados para o ComboBox de disciplina.
            comboBoxDisciplina.DisplayMember = "Nome";
            comboBoxDisciplina.ValueMember = "Id";
            comboBoxDisciplina.DataSource = disciplinas;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                reservaBindingSource.EndEdit();
                Reserva _reserva = (Reserva)reservaBindingSource.Current;

                if (Id == 0)
                {
                    usuarioBLL.ValidarPermissao(13);
                    horaSelecionada = reservaHoraDateTimePicker.Value.TimeOfDay;

                    _reserva = new Reserva();
                    _reserva.IdResponsavel = usuarioLogado.Id;
                    _reserva.IdSolicitante = (int)comboBoxSolicitante.SelectedValue;
                    _reserva.IdSala = (int)comboBoxSala.SelectedValue;
                    _reserva.IdCurso = (int)comboBoxCurso.SelectedValue;
                    _reserva.IdDisciplina = (int)comboBoxDisciplina.SelectedValue;
                    _reserva.Status = comboBoxStatus.SelectedItem.ToString();
                    _reserva.Turno = comboBoxTurno.SelectedItem.ToString();
                    _reserva.Observacoes = observacoesTextBox.Text;
                    _reserva.ReservaData = reservaDataDateTimePicker.Value;
                    _reserva.ReservaHora = horaSelecionada;

                    // Defina as datas padrão desejadas aqui.
                    _reserva.DataRetirada = DateTime.Now; // Por exemplo, definir a data mínima.
                    _reserva.DataDevolucao = DateTime.Now; // Por exemplo, definir a data mínima.

                    new ReservaBLL().Inserir(_reserva);
                }
                else
                {
                    new ReservaBLL().Alterar(_reserva);
                }
                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
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

        private void comboBoxSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilita o campo reservaDataDateTimePicker
            reservaDataDateTimePicker.Enabled = true;
        }

        private void reservaDataDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Habilita o campo reservaHoraDateTimePicker
            reservaHoraDateTimePicker.Enabled = true;
        }

        private void reservaHoraDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Obtenha a sala selecionada
            Sala salaSelecionada = (Sala)comboBoxSala.SelectedItem;

            if (salaSelecionada != null)
            {
                int idSala = salaSelecionada.Id;
                DateTime dataSelecionada = reservaDataDateTimePicker.Value.Date;
                horaSelecionada = reservaHoraDateTimePicker.Value.TimeOfDay;

                // Verifique se já existe uma reserva conflitante usando o método ExisteReservasDuplicadas
                bool reservaConflitante = new ReservaBLL().ExisteReservasDuplicadas(idSala, dataSelecionada, horaSelecionada);

                // Atualize o estado do botão "Salvar" e exiba um aviso
                if (reservaConflitante)
                {
                    // Desabilite o botão "Salvar"
                    buttonSalvar.Enabled = false;

                    // Exiba um aviso ao usuário (por exemplo, em uma Label ou MessageBox)
                    labelAviso.Text = "Horário não disponível. Por favor, selecione outra sala, data ou hora.";
                }
                else
                {
                    // Habilite o botão "Salvar"
                    buttonSalvar.Enabled = true;

                    // Limpe o aviso
                    labelAviso.Text = "";
                }
            }
        }

    }
}
