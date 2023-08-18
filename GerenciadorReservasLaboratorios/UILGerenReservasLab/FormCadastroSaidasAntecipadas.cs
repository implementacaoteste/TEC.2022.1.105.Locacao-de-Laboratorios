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

        public FormCadastroSaidasAntecipadas(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }
        private void FormCadastroSaidasAntecipadas_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Realize a validação de permissão antes de inserir a saída antecipada.
                usuarioBLL.ValidarPermissao(1); // Substitua 1 pelo ID da permissão que você deseja validar.

                SaidasAntecipadas saidaAntecipada = new SaidasAntecipadas();
                // Preencha os campos do objeto SaidasAntecipadas.

                saidaAntecipada.IdProfessor = usuarioBLL.ObterIdUsuarioLogado();
                saidaAntecipada.Motivo = motivoTextBox.Text;
                saidaAntecipada.Status = "em análise";
                saidaAntecipada.DataHoraSaida = DateTime.Now;

                new SaidasAntecipadasBLL().Inserir(saidaAntecipada);

                MessageBox.Show("Solicitação de saída antecipada registrada com sucesso!");
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
    }
}
