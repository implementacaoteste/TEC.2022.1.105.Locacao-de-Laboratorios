﻿using BLL;
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

        public FormCadastroSaidasAntecipadas(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }
        // Variável para rastrear se é uma nova solicitação ou edição.
        private bool isNewRequest = true;

        private void FormCadastroSaidasAntecipadas_Load(object sender, EventArgs e)
        {
            // Configurar ComboBox para selecionar o valor no índice 0 por padrão.
            comboBoxStatus.SelectedIndex = 0;
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
                    // Realize a validação de permissão antes de inserir a saída antecipada.
                    usuarioBLL.ValidarPermissao(1); // Substitua 1 pelo ID da permissão que você deseja validar.

                    SaidasAntecipadas saidaAntecipada = new SaidasAntecipadas();
                    // Preencha os campos do objeto SaidasAntecipadas.

                    _saidasAntecipadas.IdAluno = idAlunoSelecionado;
                    _saidasAntecipadas.IdProfessor = usuarioLogado.Id;
                    _saidasAntecipadas.Motivo = motivoTextBox.Text;

                    // Preencher Status com base na variável de controle isNewRequest.
                    _saidasAntecipadas.Status = isNewRequest ? comboBoxStatus.Text : "em análise";

                    _saidasAntecipadas.DataHoraSaida = DateTime.Now;
                    new SaidasAntecipadasBLL().Inserir(_saidasAntecipadas);
                }
                else
                {
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
