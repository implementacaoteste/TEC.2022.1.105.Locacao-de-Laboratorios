﻿namespace UILGerenReservasLab
{
    partial class FormCadastroReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idCursoLabel;
            System.Windows.Forms.Label idDisciplinaLabel;
            System.Windows.Forms.Label idSalaLabel;
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label observacoesLabel;
            System.Windows.Forms.Label dataDevolucaoLabel;
            System.Windows.Forms.Label dataRetiradaLabel;
            System.Windows.Forms.Label reservaDataLabel;
            System.Windows.Forms.Label reservaHoraLabel;
            System.Windows.Forms.Label solicitanteLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label turnoLabel;
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dataDevolucaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataRetiradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservaDataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservaHoraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxLiberarChave = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxSala = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.comboBoxSolicitante = new System.Windows.Forms.ComboBox();
            idCursoLabel = new System.Windows.Forms.Label();
            idDisciplinaLabel = new System.Windows.Forms.Label();
            idSalaLabel = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            dataDevolucaoLabel = new System.Windows.Forms.Label();
            dataRetiradaLabel = new System.Windows.Forms.Label();
            reservaDataLabel = new System.Windows.Forms.Label();
            reservaHoraLabel = new System.Windows.Forms.Label();
            solicitanteLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            turnoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            this.groupBoxLiberarChave.SuspendLayout();
            this.SuspendLayout();
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new System.Drawing.Point(46, 188);
            idCursoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(37, 13);
            idCursoLabel.TabIndex = 1;
            idCursoLabel.Text = "Curso:";
            // 
            // idDisciplinaLabel
            // 
            idDisciplinaLabel.AutoSize = true;
            idDisciplinaLabel.Location = new System.Drawing.Point(46, 230);
            idDisciplinaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idDisciplinaLabel.Name = "idDisciplinaLabel";
            idDisciplinaLabel.Size = new System.Drawing.Size(55, 13);
            idDisciplinaLabel.TabIndex = 3;
            idDisciplinaLabel.Text = "Disciplina:";
            // 
            // idSalaLabel
            // 
            idSalaLabel.AutoSize = true;
            idSalaLabel.Location = new System.Drawing.Point(46, 139);
            idSalaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idSalaLabel.Name = "idSalaLabel";
            idSalaLabel.Size = new System.Drawing.Size(31, 13);
            idSalaLabel.TabIndex = 5;
            idSalaLabel.Text = "Sala:";
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(46, 42);
            idUsuarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(80, 13);
            idUsuarioLabel.TabIndex = 6;
            idUsuarioLabel.Text = "Cadastrado Por";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Location = new System.Drawing.Point(48, 277);
            observacoesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(73, 13);
            observacoesLabel.TabIndex = 8;
            observacoesLabel.Text = "Observacoes:";
            // 
            // dataDevolucaoLabel
            // 
            dataDevolucaoLabel.AutoSize = true;
            dataDevolucaoLabel.Location = new System.Drawing.Point(18, 83);
            dataDevolucaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataDevolucaoLabel.Name = "dataDevolucaoLabel";
            dataDevolucaoLabel.Size = new System.Drawing.Size(88, 13);
            dataDevolucaoLabel.TabIndex = 12;
            dataDevolucaoLabel.Text = "Data Devolucao:";
            // 
            // dataRetiradaLabel
            // 
            dataRetiradaLabel.AutoSize = true;
            dataRetiradaLabel.Location = new System.Drawing.Point(30, 30);
            dataRetiradaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataRetiradaLabel.Name = "dataRetiradaLabel";
            dataRetiradaLabel.Size = new System.Drawing.Size(76, 13);
            dataRetiradaLabel.TabIndex = 14;
            dataRetiradaLabel.Text = "Data Retirada:";
            // 
            // reservaDataLabel
            // 
            reservaDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            reservaDataLabel.AutoSize = true;
            reservaDataLabel.Location = new System.Drawing.Point(279, 191);
            reservaDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            reservaDataLabel.Name = "reservaDataLabel";
            reservaDataLabel.Size = new System.Drawing.Size(85, 13);
            reservaDataLabel.TabIndex = 16;
            reservaDataLabel.Text = "Data Reservada";
            // 
            // reservaHoraLabel
            // 
            reservaHoraLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            reservaHoraLabel.AutoSize = true;
            reservaHoraLabel.Location = new System.Drawing.Point(279, 233);
            reservaHoraLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            reservaHoraLabel.Name = "reservaHoraLabel";
            reservaHoraLabel.Size = new System.Drawing.Size(96, 13);
            reservaHoraLabel.TabIndex = 18;
            reservaHoraLabel.Text = "Horário Reservado";
            // 
            // solicitanteLabel
            // 
            solicitanteLabel.AutoSize = true;
            solicitanteLabel.Location = new System.Drawing.Point(46, 95);
            solicitanteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            solicitanteLabel.Name = "solicitanteLabel";
            solicitanteLabel.Size = new System.Drawing.Size(59, 13);
            solicitanteLabel.TabIndex = 20;
            solicitanteLabel.Text = "Solicitante:";
            // 
            // statusLabel
            // 
            statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(279, 96);
            statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 22;
            statusLabel.Text = "Status:";
            // 
            // turnoLabel
            // 
            turnoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            turnoLabel.AutoSize = true;
            turnoLabel.Location = new System.Drawing.Point(280, 140);
            turnoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            turnoLabel.Name = "turnoLabel";
            turnoLabel.Size = new System.Drawing.Size(38, 13);
            turnoLabel.TabIndex = 24;
            turnoLabel.Text = "Turno:";
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox.Location = new System.Drawing.Point(49, 63);
            this.idUsuarioTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(183, 20);
            this.idUsuarioTextBox.TabIndex = 7;
            this.idUsuarioTextBox.Text = "usuario";
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Observacoes", true));
            this.observacoesTextBox.Location = new System.Drawing.Point(49, 292);
            this.observacoesTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(350, 114);
            this.observacoesTextBox.TabIndex = 9;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(84, 424);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(56, 19);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(235, 424);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(56, 19);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dataDevolucaoDateTimePicker
            // 
            this.dataDevolucaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "DataDevolucao", true));
            this.dataDevolucaoDateTimePicker.Location = new System.Drawing.Point(104, 80);
            this.dataDevolucaoDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataDevolucaoDateTimePicker.Name = "dataDevolucaoDateTimePicker";
            this.dataDevolucaoDateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.dataDevolucaoDateTimePicker.TabIndex = 13;
            // 
            // dataRetiradaDateTimePicker
            // 
            this.dataRetiradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "DataRetirada", true));
            this.dataRetiradaDateTimePicker.Location = new System.Drawing.Point(104, 27);
            this.dataRetiradaDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataRetiradaDateTimePicker.Name = "dataRetiradaDateTimePicker";
            this.dataRetiradaDateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.dataRetiradaDateTimePicker.TabIndex = 15;
            // 
            // reservaDataDateTimePicker
            // 
            this.reservaDataDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reservaDataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "ReservaData", true));
            this.reservaDataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reservaDataDateTimePicker.Location = new System.Drawing.Point(281, 206);
            this.reservaDataDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reservaDataDateTimePicker.Name = "reservaDataDateTimePicker";
            this.reservaDataDateTimePicker.Size = new System.Drawing.Size(91, 20);
            this.reservaDataDateTimePicker.TabIndex = 17;
            // 
            // reservaHoraDateTimePicker
            // 
            this.reservaHoraDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reservaHoraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "ReservaHora", true));
            this.reservaHoraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.reservaHoraDateTimePicker.Location = new System.Drawing.Point(281, 248);
            this.reservaHoraDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reservaHoraDateTimePicker.Name = "reservaHoraDateTimePicker";
            this.reservaHoraDateTimePicker.Size = new System.Drawing.Size(91, 20);
            this.reservaHoraDateTimePicker.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1024, 40);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cadastro de reservas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxLiberarChave
            // 
            this.groupBoxLiberarChave.Controls.Add(this.button2);
            this.groupBoxLiberarChave.Controls.Add(this.button1);
            this.groupBoxLiberarChave.Controls.Add(this.dataRetiradaDateTimePicker);
            this.groupBoxLiberarChave.Controls.Add(this.dataDevolucaoDateTimePicker);
            this.groupBoxLiberarChave.Controls.Add(dataDevolucaoLabel);
            this.groupBoxLiberarChave.Controls.Add(dataRetiradaLabel);
            this.groupBoxLiberarChave.Location = new System.Drawing.Point(561, 42);
            this.groupBoxLiberarChave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLiberarChave.Name = "groupBoxLiberarChave";
            this.groupBoxLiberarChave.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLiberarChave.Size = new System.Drawing.Size(443, 118);
            this.groupBoxLiberarChave.TabIndex = 28;
            this.groupBoxLiberarChave.TabStop = false;
            this.groupBoxLiberarChave.Text = "Liberação de Chaves";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 77);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 19);
            this.button2.TabIndex = 16;
            this.button2.Text = "Devolução";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 19);
            this.button1.TabIndex = 16;
            this.button1.Text = "Retirada";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxSala
            // 
            this.comboBoxSala.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdSala", true));
            this.comboBoxSala.FormattingEnabled = true;
            this.comboBoxSala.Location = new System.Drawing.Point(49, 155);
            this.comboBoxSala.Name = "comboBoxSala";
            this.comboBoxSala.Size = new System.Drawing.Size(183, 21);
            this.comboBoxSala.TabIndex = 30;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Status", true));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Pendente",
            "Aprovada",
            "Rejeitada",
            "Remarcada",
            "Cancelada",
            "Cancelada pelo usuário",
            "Em andamento",
            "Concluída"});
            this.comboBoxStatus.Location = new System.Drawing.Point(281, 111);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(151, 21);
            this.comboBoxStatus.TabIndex = 31;
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTurno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Turno", true));
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Notuno"});
            this.comboBoxTurno.Location = new System.Drawing.Point(281, 155);
            this.comboBoxTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(151, 21);
            this.comboBoxTurno.TabIndex = 31;
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdCurso", true));
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(48, 204);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(184, 21);
            this.comboBoxCurso.TabIndex = 30;
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdDisciplina", true));
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(48, 246);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(184, 21);
            this.comboBoxDisciplina.TabIndex = 30;
            // 
            // comboBoxSolicitante
            // 
            this.comboBoxSolicitante.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdUsuario", true));
            this.comboBoxSolicitante.FormattingEnabled = true;
            this.comboBoxSolicitante.Location = new System.Drawing.Point(49, 111);
            this.comboBoxSolicitante.Name = "comboBoxSolicitante";
            this.comboBoxSolicitante.Size = new System.Drawing.Size(183, 21);
            this.comboBoxSolicitante.TabIndex = 32;
            // 
            // FormCadastroReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 462);
            this.Controls.Add(this.comboBoxSolicitante);
            this.Controls.Add(this.comboBoxTurno);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxDisciplina);
            this.Controls.Add(this.comboBoxCurso);
            this.Controls.Add(this.comboBoxSala);
            this.Controls.Add(this.groupBoxLiberarChave);
            this.Controls.Add(this.label1);
            this.Controls.Add(turnoLabel);
            this.Controls.Add(statusLabel);
            this.Controls.Add(solicitanteLabel);
            this.Controls.Add(reservaHoraLabel);
            this.Controls.Add(this.reservaHoraDateTimePicker);
            this.Controls.Add(reservaDataLabel);
            this.Controls.Add(this.reservaDataDateTimePicker);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(observacoesLabel);
            this.Controls.Add(this.observacoesTextBox);
            this.Controls.Add(idUsuarioLabel);
            this.Controls.Add(this.idUsuarioTextBox);
            this.Controls.Add(idSalaLabel);
            this.Controls.Add(idDisciplinaLabel);
            this.Controls.Add(idCursoLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCadastroReservas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Sistema de Gerenciamento de Salas";
            this.Load += new System.EventHandler(this.FormCadastroReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            this.groupBoxLiberarChave.ResumeLayout(false);
            this.groupBoxLiberarChave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DateTimePicker dataDevolucaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataRetiradaDateTimePicker;
        private System.Windows.Forms.DateTimePicker reservaDataDateTimePicker;
        private System.Windows.Forms.DateTimePicker reservaHoraDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxLiberarChave;
        private System.Windows.Forms.ComboBox comboBoxSala;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.ComboBox comboBoxSolicitante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}