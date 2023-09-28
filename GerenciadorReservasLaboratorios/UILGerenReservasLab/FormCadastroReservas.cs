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
        private int Id;
        Usuario usuarioLogado;

        public FormCadastroReservas(int _id= 0)
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

        private void CarregarComboBoxSolicitante()
        {
            // Carregue os usuários do banco de dados.
            List<Usuario> usuarios = new UsuarioBLL().BuscarTodos();

            // Defina a fonte de dados para o ComboBox de solicitante.
            comboBoxSolicitante.DisplayMember = "Nome";
            comboBoxSolicitante.ValueMember = "Id";
            comboBoxSolicitante.DataSource = usuarios;
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
        private void FormCadastroReservas_Load(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                reservaBindingSource.AddNew();
            }
            usuarioLogado = new UsuarioBLL().ObterUsuarioLogado();

            // Defina o nome do usuário logado no campo idUsuarioTextBox.
            idUsuarioTextBox.Text = usuarioLogado.Nome;

            // Carregue os dados para preencher os ComboBoxes.
            CarregarComboBoxSolicitante();
            CarregarComboBoxSala();
            CarregarComboBoxCurso();
            CarregarComboBoxDisciplina();

            // Desabilite o groupBoxLiberarChave por padrão.
            groupBoxLiberarChave.Enabled = false;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                reservaBindingSource.EndEdit();
                Reserva _reserva = (Reserva)reservaBindingSource.Current;

                if (Id == 0)
                {
                    _reserva.IdResponsavel = usuarioLogado.Id;
                    _reserva.IdSolicitante = ((Reserva)comboBoxSolicitante.SelectedValue).Id;
                    _reserva.IdSala = ((Reserva)comboBoxSala.SelectedValue).Id;
                    _reserva.IdCurso = ((Reserva)comboBoxCurso.SelectedValue).Id;
                    _reserva.IdDisciplina = ((Reserva)comboBoxDisciplina.SelectedValue).Id;
                    _reserva.Status = ((Reserva)comboBoxStatus.SelectedValue).Status;
                    _reserva.Turno = ((Reserva)comboBoxTurno.SelectedValue).Turno;
                    _reserva.ReservaData = reservaDataDateTimePicker.Value;
                    _reserva.ReservaHora = reservaHoraDateTimePicker.Value;
                    new ReservaBLL().Inserir(_reserva);
                }
                else
                    new ReservaBLL().Alterar(_reserva);
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
    }
}
