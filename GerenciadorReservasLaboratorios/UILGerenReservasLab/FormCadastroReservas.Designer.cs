namespace UILGerenReservasLab
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxIdSala = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.comboBoxIdCurso = new System.Windows.Forms.ComboBox();
            this.comboBoxIdDisciplina = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new System.Drawing.Point(62, 231);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(45, 16);
            idCursoLabel.TabIndex = 1;
            idCursoLabel.Text = "Curso:";
            // 
            // idDisciplinaLabel
            // 
            idDisciplinaLabel.AutoSize = true;
            idDisciplinaLabel.Location = new System.Drawing.Point(61, 283);
            idDisciplinaLabel.Name = "idDisciplinaLabel";
            idDisciplinaLabel.Size = new System.Drawing.Size(69, 16);
            idDisciplinaLabel.TabIndex = 3;
            idDisciplinaLabel.Text = "Disciplina:";
            // 
            // idSalaLabel
            // 
            idSalaLabel.AutoSize = true;
            idSalaLabel.Location = new System.Drawing.Point(62, 171);
            idSalaLabel.Name = "idSalaLabel";
            idSalaLabel.Size = new System.Drawing.Size(38, 16);
            idSalaLabel.TabIndex = 5;
            idSalaLabel.Text = "Sala:";
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(61, 52);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(176, 16);
            idUsuarioLabel.TabIndex = 6;
            idUsuarioLabel.Text = "Responsável pela Reserva:";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Location = new System.Drawing.Point(64, 341);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(92, 16);
            observacoesLabel.TabIndex = 8;
            observacoesLabel.Text = "Observacoes:";
            // 
            // dataDevolucaoLabel
            // 
            dataDevolucaoLabel.AutoSize = true;
            dataDevolucaoLabel.Location = new System.Drawing.Point(651, 41);
            dataDevolucaoLabel.Name = "dataDevolucaoLabel";
            dataDevolucaoLabel.Size = new System.Drawing.Size(108, 16);
            dataDevolucaoLabel.TabIndex = 12;
            dataDevolucaoLabel.Text = "Data Devolucao:";
            // 
            // dataRetiradaLabel
            // 
            dataRetiradaLabel.AutoSize = true;
            dataRetiradaLabel.Location = new System.Drawing.Point(11, 37);
            dataRetiradaLabel.Name = "dataRetiradaLabel";
            dataRetiradaLabel.Size = new System.Drawing.Size(94, 16);
            dataRetiradaLabel.TabIndex = 14;
            dataRetiradaLabel.Text = "Data Retirada:";
            // 
            // reservaDataLabel
            // 
            reservaDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            reservaDataLabel.AutoSize = true;
            reservaDataLabel.Location = new System.Drawing.Point(858, 238);
            reservaDataLabel.Name = "reservaDataLabel";
            reservaDataLabel.Size = new System.Drawing.Size(113, 16);
            reservaDataLabel.TabIndex = 16;
            reservaDataLabel.Text = "Data da Reserva:";
            // 
            // reservaHoraLabel
            // 
            reservaHoraLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            reservaHoraLabel.AutoSize = true;
            reservaHoraLabel.Location = new System.Drawing.Point(861, 291);
            reservaHoraLabel.Name = "reservaHoraLabel";
            reservaHoraLabel.Size = new System.Drawing.Size(114, 16);
            reservaHoraLabel.TabIndex = 18;
            reservaHoraLabel.Text = "Hora da Reserva:";
            // 
            // solicitanteLabel
            // 
            solicitanteLabel.AutoSize = true;
            solicitanteLabel.Location = new System.Drawing.Point(62, 117);
            solicitanteLabel.Name = "solicitanteLabel";
            solicitanteLabel.Size = new System.Drawing.Size(72, 16);
            solicitanteLabel.TabIndex = 20;
            solicitanteLabel.Text = "Solicitante:";
            // 
            // statusLabel
            // 
            statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(918, 84);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(47, 16);
            statusLabel.TabIndex = 22;
            statusLabel.Text = "Status:";
            // 
            // turnoLabel
            // 
            turnoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            turnoLabel.AutoSize = true;
            turnoLabel.Location = new System.Drawing.Point(920, 140);
            turnoLabel.Name = "turnoLabel";
            turnoLabel.Size = new System.Drawing.Size(45, 16);
            turnoLabel.TabIndex = 24;
            turnoLabel.Text = "Turno:";
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox.Location = new System.Drawing.Point(65, 78);
            this.idUsuarioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(455, 22);
            this.idUsuarioTextBox.TabIndex = 7;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Observacoes", true));
            this.observacoesTextBox.Location = new System.Drawing.Point(65, 359);
            this.observacoesTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(921, 22);
            this.observacoesTextBox.TabIndex = 9;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(112, 522);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(313, 522);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dataDevolucaoDateTimePicker
            // 
            this.dataDevolucaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "DataDevolucao", true));
            this.dataDevolucaoDateTimePicker.Location = new System.Drawing.Point(765, 37);
            this.dataDevolucaoDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataDevolucaoDateTimePicker.Name = "dataDevolucaoDateTimePicker";
            this.dataDevolucaoDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dataDevolucaoDateTimePicker.TabIndex = 13;
            // 
            // dataRetiradaDateTimePicker
            // 
            this.dataRetiradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "DataRetirada", true));
            this.dataRetiradaDateTimePicker.Location = new System.Drawing.Point(109, 33);
            this.dataRetiradaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRetiradaDateTimePicker.Name = "dataRetiradaDateTimePicker";
            this.dataRetiradaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dataRetiradaDateTimePicker.TabIndex = 15;
            // 
            // reservaDataDateTimePicker
            // 
            this.reservaDataDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reservaDataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "ReservaData", true));
            this.reservaDataDateTimePicker.Location = new System.Drawing.Point(982, 234);
            this.reservaDataDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservaDataDateTimePicker.Name = "reservaDataDateTimePicker";
            this.reservaDataDateTimePicker.Size = new System.Drawing.Size(288, 22);
            this.reservaDataDateTimePicker.TabIndex = 17;
            // 
            // reservaHoraDateTimePicker
            // 
            this.reservaHoraDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reservaHoraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "ReservaHora", true));
            this.reservaHoraDateTimePicker.Location = new System.Drawing.Point(982, 288);
            this.reservaHoraDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservaHoraDateTimePicker.Name = "reservaHoraDateTimePicker";
            this.reservaHoraDateTimePicker.Size = new System.Drawing.Size(291, 22);
            this.reservaHoraDateTimePicker.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1365, 49);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cadastro de reservas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataRetiradaDateTimePicker);
            this.groupBox1.Controls.Add(this.dataDevolucaoDateTimePicker);
            this.groupBox1.Controls.Add(dataDevolucaoLabel);
            this.groupBox1.Controls.Add(dataRetiradaLabel);
            this.groupBox1.Location = new System.Drawing.Point(51, 395);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(984, 121);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liberação de Chaves";
            // 
            // comboBoxIdSala
            // 
            this.comboBoxIdSala.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdSala", true));
            this.comboBoxIdSala.FormattingEnabled = true;
            this.comboBoxIdSala.Location = new System.Drawing.Point(65, 191);
            this.comboBoxIdSala.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIdSala.Name = "comboBoxIdSala";
            this.comboBoxIdSala.Size = new System.Drawing.Size(455, 24);
            this.comboBoxIdSala.TabIndex = 30;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Status", true));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(971, 76);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 24);
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
            this.comboBoxTurno.Location = new System.Drawing.Point(971, 137);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTurno.TabIndex = 31;
            // 
            // comboBoxIdCurso
            // 
            this.comboBoxIdCurso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdCurso", true));
            this.comboBoxIdCurso.FormattingEnabled = true;
            this.comboBoxIdCurso.Location = new System.Drawing.Point(64, 251);
            this.comboBoxIdCurso.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIdCurso.Name = "comboBoxIdCurso";
            this.comboBoxIdCurso.Size = new System.Drawing.Size(455, 24);
            this.comboBoxIdCurso.TabIndex = 30;
            // 
            // comboBoxIdDisciplina
            // 
            this.comboBoxIdDisciplina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdDisciplina", true));
            this.comboBoxIdDisciplina.FormattingEnabled = true;
            this.comboBoxIdDisciplina.Location = new System.Drawing.Point(64, 303);
            this.comboBoxIdDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIdDisciplina.Name = "comboBoxIdDisciplina";
            this.comboBoxIdDisciplina.Size = new System.Drawing.Size(455, 24);
            this.comboBoxIdDisciplina.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdSala", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 137);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(455, 24);
            this.comboBox1.TabIndex = 32;
            // 
            // FormCadastroReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 569);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxTurno);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxIdDisciplina);
            this.Controls.Add(this.comboBoxIdCurso);
            this.Controls.Add(this.comboBoxIdSala);
            this.Controls.Add(this.groupBox1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastroReservas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Sistema de Gerenciamento de Salas";
            this.Load += new System.EventHandler(this.FormCadastroReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxIdSala;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.ComboBox comboBoxIdCurso;
        private System.Windows.Forms.ComboBox comboBoxIdDisciplina;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}