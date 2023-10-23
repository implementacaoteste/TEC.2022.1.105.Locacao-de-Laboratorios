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
    public partial class FormCadastroReservas : Form
    {
        public int Id;
        private readonly UsuarioBLL usuarioBLL = new UsuarioBLL();
        Usuario usuarioLogado;

        // Variável de instância para armazenar a hora selecionada
        private TimeSpan horaSelecionada1;
        private TimeSpan horaSelecionada2;

        private bool isProfessor = true;
        private bool isCoordenacao = true;
        private bool isAdmin = true;
        private string estadoReserva = "Pendente";


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

                    // Obtenha as horas do banco de dados
                    TimeSpan horaInicial = reserva.HoraInicial;
                    TimeSpan horaFinal = reserva.HoraFinal;

                    // Crie um objeto DateTime com a data padrão (01/01/1900) e as horas do banco de dados
                    DateTime horaInicialDateTime = new DateTime(1800, 1, 1, horaInicial.Hours, horaInicial.Minutes, horaInicial.Seconds);
                    DateTime horaFinalDateTime = new DateTime(1800, 1, 1, horaFinal.Hours, horaFinal.Minutes, horaFinal.Seconds);

                    // Defina o Value dos DateTimePickers para exibir as horas
                    reservaHoraInicialDateTimePicker.Value = horaInicialDateTime;
                    reservaHoraFinalDateTimePicker.Value = horaFinalDateTime;

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

            // Desabilite o groupBoxLiberarChave por padrão.
            groupBoxLiberarChave.Enabled = false;
            dataRetiradaDateTimePicker.Enabled = false;
            dataDevolucaoDateTimePicker.Enabled = false;


            if (Id == 0)
            {
                // Carregue os dados para preencher os ComboBoxes.
                CarregarComboBoxSolicitante();
                CarregarComboBoxSala();
                CarregarComboBoxCurso();
                CarregarComboBoxDisciplina();
                CarregarComboBoxResponsavel();


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
                CarregarComboBoxResponsavel();

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
            labelMenu.Text = "Cadastro de Reservas";
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

        private void CarregarComboBoxResponsavel()
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
            if (Id > 0)
            {
                // Encontre o usuário correspondente à reserva existente no banco de dados.
                int _responsavel = ((Reserva)reservaBindingSource.Current).IdResponsavel;

                // Crie uma lista com o único usuário correspondente à reserva existente.
                List<Usuario> responsavelList = new List<Usuario>();
                responsavelList.Add(new UsuarioBLL().BuscarPorId(_responsavel));

                // Defina o valor selecionado no comboBoxResponsavel para o Id de usuário correspondente.
                comboBoxResponsavel.ValueMember = "Id";
                comboBoxResponsavel.DisplayMember = "Nome";
                comboBoxResponsavel.DataSource = responsavelList;

                // Selecione o usuário como valor padrão no combobox.
                comboBoxResponsavel.SelectedItem = responsavelList.FirstOrDefault();
            }

        }
        private void CarregarComboBoxSolicitante()
        {
            // Carregue todos os usuários do banco de dados.
            List<Usuario> usuarios = new UsuarioBLL().BuscarTodos();

            comboBoxSolicitante.DisplayMember = "Nome";
            comboBoxSolicitante.ValueMember = "Id";
            comboBoxSolicitante.DataSource = usuarios;

            if (Id > 0) // Verifica se é uma edição de reserva existente
            {
                // Defina o valor selecionado no comboBoxSolicitante para o usuário correspondente à reserva existente.
                comboBoxSolicitante.SelectedValue = ((Reserva)reservaBindingSource.Current).IdSolicitante;
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

            if (Id > 0)
            {
                // Se for uma edição, defina o valor selecionado com base no ID da sala associada à reserva existente.
                comboBoxSala.SelectedValue = ((Reserva)reservaBindingSource.Current).IdSala;
            }
        }

        private void CarregarComboBoxCurso()
        {
            // Carregue os cursos do banco de dados.
            List<Curso> cursos = new CursoBLL().BuscarTodos();

            // Defina a fonte de dados para o ComboBox de curso.
            comboBoxCurso.DisplayMember = "Nome";
            comboBoxCurso.ValueMember = "Id";
            comboBoxCurso.DataSource = cursos;

            if (Id > 0)
            {
                // Se for uma edição, defina o valor selecionado com base no ID do curso associado à reserva existente.
 
                comboBoxCurso.SelectedValue = ((Reserva)reservaBindingSource.Current).IdCurso;
            }
        }

        private void CarregarComboBoxDisciplina()
        {
            // Carregue as disciplinas do banco de dados.
            List<Disciplina> disciplinas = new DisciplinaBLL().BuscarTodos();

            // Defina a fonte de dados para o ComboBox de disciplina.
            comboBoxDisciplina.DisplayMember = "Nome";
            comboBoxDisciplina.ValueMember = "Id";
            comboBoxDisciplina.DataSource = disciplinas;

            if (Id > 0)
            {
                // Se for uma edição, defina o valor selecionado com base no ID da disciplina associada à reserva existente.

                comboBoxDisciplina.SelectedValue = ((Reserva)reservaBindingSource.Current).IdDisciplina;
            }
        }

        private void reservaHoraInicialDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            VerificarConflitosDeReserva();
        }

        private void reservaHoraFinalDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            VerificarConflitosDeReserva();
        }

        //private void VerificarConflitosDeReserva()
        //{
        //    // Obtenha a sala selecionada
        //    Sala salaSelecionada = (Sala)comboBoxSala.SelectedItem;

        //    if (salaSelecionada != null)
        //    {
        //        int idSala = salaSelecionada.Id;
        //        DateTime dataSelecionada = reservaDataInicialDateTimePicker.Value.Date;
        //        TimeSpan horaInicial = reservaHoraInicialDateTimePicker.Value.TimeOfDay;
        //        TimeSpan horaFinal = reservaHoraFinalDateTimePicker.Value.TimeOfDay;

        //        // Verifique se já existe uma reserva conflitante usando o método ExisteReservasDuplicadas
        //        bool reservaConflitante = new ReservaBLL().VerConflitosDeReserva(idSala, dataSelecionada, horaInicial, horaFinal);

        //        // Atualize o estado do botão "Salvar" e exiba um aviso
        //        if (reservaConflitante)
        //        {
        //            // Desabilite o botão "Salvar"
        //            buttonSalvarReserva.Enabled = false;

        //            // Exibe um aviso ao usuário na tela.
        //            MessageBox.Show("Horário não disponível. Por favor, \nselecione outra sala, data ou hora.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //        }
        //        else
        //        {
        //            // Habilite o botão "Salvar"
        //            buttonSalvarReserva.Enabled = true;
        //        }
        //    }
        //}
        private void VerificarConflitosDeReserva()
        {
            // Obtenha a sala selecionada
            Sala salaSelecionada = (Sala)comboBoxSala.SelectedItem;

            if (salaSelecionada != null)
            {
                int idSala = salaSelecionada.Id;
                DateTime dataSelecionada = reservaDataInicialDateTimePicker.Value.Date;
                TimeSpan horaInicial = reservaHoraInicialDateTimePicker.Value.TimeOfDay;
                TimeSpan horaFinal = reservaHoraFinalDateTimePicker.Value.TimeOfDay;

                // Chame o método VerConflitosDeReserva da ReservaBLL
                new ReservaBLL().VerConflitosDeReserva(idSala, dataSelecionada, horaInicial, horaFinal);
            }
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

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string novoEstado = comboBoxStatus.SelectedItem.ToString();

            if (novoEstado == "Aprovada" || novoEstado == "Remarcada")
            {
                // Habilitar o botão "Liberar" quando a reserva estiver Aprovada ou Remarcada.
                buttonRetirada.Enabled = true;
                dataRetiradaDateTimePicker.Enabled = false; // Desabilitar o campo de entrega
                dataDevolucaoDateTimePicker.Enabled = false; // Desabilitar o campo de devolução
            }
            else if (novoEstado == "Em andamento")
            {
                // Habilitar o botão "Devolver" quando a reserva estiver Em andamento.
                buttonDevolucao.Enabled = true;
                dataDevolucaoDateTimePicker.Enabled = true; // Habilitar o campo de entrega
            }
            else if (novoEstado == "Concluída")
            {
                // A reserva está concluída, desabilite os campos de entrega e devolução.
                dataRetiradaDateTimePicker.Enabled = false;
                dataDevolucaoDateTimePicker.Enabled = false;
            }
            else
            {
                // Para outros estados, desabilite ambos os botões e os campos de entrega e devolução.
                buttonRetirada.Enabled = false;
                buttonDevolucao.Enabled = false;
                dataRetiradaDateTimePicker.Enabled = false;
                dataDevolucaoDateTimePicker.Enabled = false;
            }

            // Atualize o estado da reserva.
            estadoReserva = novoEstado;
        }

        private void buttonRetirada_Click(object sender, EventArgs e)
        {
            if (estadoReserva == "Aprovada" || estadoReserva == "Remarcada")
            {
                estadoReserva = "Em Andamento";
                dataRetiradaDateTimePicker.Enabled = true;
                dataRetiradaDateTimePicker.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("A reserva deve estar Aprovada ou Remarcada para a chave ser liberada.");
            }
        }

        private void buttonDevolucao_Click(object sender, EventArgs e)
        {
            if (estadoReserva == "Em Andamento")
            {
                estadoReserva = "Concluída";
                dataDevolucaoDateTimePicker.Enabled = true;
                dataDevolucaoDateTimePicker.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("A reserva deve estar Em Andamento para a chave ser devolvida.");
            }
        }
        private void buttonCancelarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSalvarReserva_Click_1(object sender, EventArgs e)
        {
            try
            {
                reservaBindingSource.EndEdit();
                Reserva _reserva = (Reserva)reservaBindingSource.Current;

                if (Id == 0)
                {
                    usuarioBLL.ValidarPermissao(13);
                    horaSelecionada1 = reservaHoraInicialDateTimePicker.Value.TimeOfDay;
                    horaSelecionada2 = reservaHoraFinalDateTimePicker.Value.TimeOfDay;

                    _reserva = new Reserva();
                    // Verifique se o usuário logado é um professor
                    if (!isProfessor)
                    {
                        _reserva.IdResponsavel = usuarioLogado.Id; // Preencher com o ID do usuário logado
                    }
                    _reserva.IdSolicitante = (int)comboBoxSolicitante.SelectedValue;
                    _reserva.IdSala = (int)comboBoxSala.SelectedValue;
                    _reserva.IdCurso = (int)comboBoxCurso.SelectedValue;
                    _reserva.IdDisciplina = (int)comboBoxDisciplina.SelectedValue;
                    _reserva.StatusReserva = comboBoxStatus.SelectedItem.ToString();
                    _reserva.Turno = comboBoxTurno.SelectedItem.ToString();
                    _reserva.Observacoes = observacoesTextBox.Text;
                    _reserva.ReservaDataInicial = reservaDataInicialDateTimePicker.Value;
                    _reserva.ReservaDataFinal = reservaHoraFinalDateTimePicker.Value;
                    _reserva.HoraInicial = horaSelecionada1;
                    _reserva.HoraFinal = horaSelecionada2;

                    // Defina as datas padrão desejadas aqui.
                    _reserva.DataRetirada = DateTime.Now; // Por exemplo, definir a data mínima.
                    _reserva.DataDevolucao = DateTime.Now; // Por exemplo, definir a data mínima.

                    new ReservaBLL().Inserir(_reserva);
                    MessageBox.Show($"Reserva criada com sucesso por {usuarioLogado.NomeUsuario}!");
                }
                else
                {
                    usuarioBLL.ValidarPermissao(14);

                    new ReservaBLL().Alterar(_reserva);
                    MessageBox.Show($"Reserva alterada com sucesso por {usuarioLogado.NomeUsuario}!");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
