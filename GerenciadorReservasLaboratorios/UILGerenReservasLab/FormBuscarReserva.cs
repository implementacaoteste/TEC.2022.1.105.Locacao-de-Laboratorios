using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace UILGerenReservasLab
{
    public partial class FormBuscarReserva : Form
    {
        public FormBuscarReserva()
        {
            InitializeComponent();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Usuario usuarioEncontrado = new Usuario();
            try
            {
                switch (comboBoxBuscarReservaPor.SelectedIndex)
                {
                    case 0: // Buscar por Id
                        if (string.IsNullOrEmpty(textBoxBuscarReserva.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 01 } } };
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarReserva.Text));
                        break;
                    case 1: // Buscar por Solicitante
                        string nomeSolicitante = textBoxBuscarReserva.Text;

                        if (string.IsNullOrEmpty(nomeSolicitante))
                        {
                            throw new Exception("Informe o nome do Solicitante para fazer a busca.");
                        }

                        usuarioEncontrado = new UsuarioBLL().BuscarPorNomeUsuario(nomeSolicitante);

                        if (usuarioEncontrado != null)
                        {
                            int idUsuario = usuarioEncontrado.Id; // Aqui obtemos o ID do usuário

                            // Agora podemos usar o ID do usuário para buscar as reservas
                            reservaBindingSource.DataSource = new ReservaBLL().BuscarPorSolicitante(idUsuario);
                        }
                        else
                        {
                            // Trate o caso em que o nome do solicitante não foi encontrado.
                            MessageBox.Show("Nome do Solicitante não encontrado.");
                        }
                        break;
                    case 2: // Buscar por Responsável (Usuário)
                        string nomeResponsavel = textBoxBuscarReserva.Text;

                        if (string.IsNullOrEmpty(nomeResponsavel))
                        {
                            throw new Exception("Informe o nome do Responsável para fazer a busca.");
                        }

                        usuarioEncontrado = new UsuarioBLL().BuscarPorNomeUsuario(nomeResponsavel);

                        if (usuarioEncontrado != null)
                        {
                            int idUsuario = usuarioEncontrado.Id; // Aqui obtemos o ID do usuário

                            // Agora podemos usar o ID do usuário para buscar as reservas
                            reservaBindingSource.DataSource = new ReservaBLL().BuscarPorResponsavel(idUsuario);
                        }
                        else
                        {
                            // Trate o caso em que o nome do responsável não foi encontrado.
                            MessageBox.Show("Nome do Responsavel não encontrado.");
                        }
                        break;

                    case 3: // Buscar por Sala
                        if (string.IsNullOrEmpty(textBoxBuscarReserva.Text))
                            throw new Exception("Informe o nome da Sala para fazer a busca.");
                        reservaBindingSource.DataSource = new SalaBLL().BuscarPorNome(textBoxBuscarReserva.Text);
                        break;
                    case 4: // Buscar por Disciplina
                        if (string.IsNullOrEmpty(textBoxBuscarReserva.Text))
                            throw new Exception("Informe o nome da Disciplina para fazer a busca.");
                        reservaBindingSource.DataSource = new DisciplinaBLL().BuscarPorNome(textBoxBuscarReserva.Text);
                        break;
                    case 5: // Buscar por Curso
                        if (string.IsNullOrEmpty(textBoxBuscarReserva.Text))
                            throw new Exception("Informe o nome do Curso para fazer a busca.");
                        reservaBindingSource.DataSource = new CursoBLL().BuscarPorNome(textBoxBuscarReserva.Text);
                        break;
                    case 6: // Buscar por Turno
                        if (string.IsNullOrEmpty(textBoxBuscarReserva.Text))
                            throw new Exception("Informe o Turno para fazer a busca.");
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorTurno(textBoxBuscarReserva.Text);
                        break;
                    case 7: // Buscar por Data
                        if (string.IsNullOrEmpty(textBoxBuscarReserva.Text))
                            throw new Exception("Informe a Data para fazer a busca.");

                        // Tente converter a string em um objeto DateTime
                        if (DateTime.TryParse(textBoxBuscarReserva.Text, out DateTime dataBusca))
                        {
                            // Use o valor convertido para buscar reservas por data
                            reservaBindingSource.DataSource = new ReservaBLL().BuscarPorData(dataBusca);
                        }
                        else
                        {
                            // Trate o caso em que a conversão da data falhou
                            MessageBox.Show("Data informada é inválida. Use o formato correto (por exemplo, '25/09/2022').");
                        }
                        break;

                    case 8: // Buscar por Status
                        if (string.IsNullOrEmpty(textBoxBuscarReserva.Text))
                            throw new Exception("Informe o Status para fazer a busca.");
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorStatus(textBoxBuscarReserva.Text);
                        break;
                    case 9: // Buscar Todos
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarTodos();
                        break;
                    default:
                        MessageBox.Show("Escolha uma opção de busca");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (reservaBindingSource.Count == 0)
                    throw new Exception("Não existe reserva listado para ser alterado.");

                int id = ((Reserva)reservaBindingSource.Current).Id;

                using (FormCadastroReservas frm = new FormCadastroReservas(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExcluirReserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (reservaBindingSource.Count == 0)
                    throw new Exception("Não existe reserva  para ser excluído.");

                if (reservaBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe reserva para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Reserva)reservaBindingSource.Current).Id;
                new UsuarioBLL().Excluir(id);
                reservaBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonInserirReserva_Click(object sender, EventArgs e)
        {
            using (FormCadastroReservas frm = new FormCadastroReservas())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelecionarAluno_Click(object sender, EventArgs e)
        {

        }
    }
}
