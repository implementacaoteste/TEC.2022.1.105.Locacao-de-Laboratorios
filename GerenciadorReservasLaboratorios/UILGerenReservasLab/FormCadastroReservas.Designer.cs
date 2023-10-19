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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDevolucaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataRetiradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservaDataInicialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservaHoraInicialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxLiberarChave = new System.Windows.Forms.GroupBox();
            this.buttonDevolucao = new CustomControls.RJControls.RJButton();
            this.buttonRetirada = new CustomControls.RJControls.RJButton();
            this.comboBoxSala = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.comboBoxSolicitante = new System.Windows.Forms.ComboBox();
            this.comboBoxResponsavel = new System.Windows.Forms.ComboBox();
            this.reservaHoraFinalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservaDataFinalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonMinimizar = new System.Windows.Forms.PictureBox();
            this.buttonRestaurar = new System.Windows.Forms.PictureBox();
            this.buttonMaximizar = new System.Windows.Forms.PictureBox();
            this.buttonFechar = new System.Windows.Forms.PictureBox();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.buttonSalvarReserva = new CustomControls.RJControls.RJButton();
            this.buttonCancelarReserva = new CustomControls.RJControls.RJButton();
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            this.groupBoxLiberarChave.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.ForeColor = System.Drawing.Color.White;
            idCursoLabel.Location = new System.Drawing.Point(445, 52);
            idCursoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(34, 13);
            idCursoLabel.TabIndex = 1;
            idCursoLabel.Text = "Curso";
            // 
            // idDisciplinaLabel
            // 
            idDisciplinaLabel.AutoSize = true;
            idDisciplinaLabel.ForeColor = System.Drawing.Color.White;
            idDisciplinaLabel.Location = new System.Drawing.Point(445, 97);
            idDisciplinaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idDisciplinaLabel.Name = "idDisciplinaLabel";
            idDisciplinaLabel.Size = new System.Drawing.Size(52, 13);
            idDisciplinaLabel.TabIndex = 3;
            idDisciplinaLabel.Text = "Disciplina";
            // 
            // idSalaLabel
            // 
            idSalaLabel.AutoSize = true;
            idSalaLabel.ForeColor = System.Drawing.Color.White;
            idSalaLabel.Location = new System.Drawing.Point(80, 149);
            idSalaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idSalaLabel.Name = "idSalaLabel";
            idSalaLabel.Size = new System.Drawing.Size(28, 13);
            idSalaLabel.TabIndex = 5;
            idSalaLabel.Text = "Sala";
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.ForeColor = System.Drawing.Color.White;
            idUsuarioLabel.Location = new System.Drawing.Point(81, 52);
            idUsuarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(76, 13);
            idUsuarioLabel.TabIndex = 6;
            idUsuarioLabel.Text = "Autorizada Por";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.ForeColor = System.Drawing.Color.White;
            observacoesLabel.Location = new System.Drawing.Point(81, 195);
            observacoesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(73, 13);
            observacoesLabel.TabIndex = 8;
            observacoesLabel.Text = "Observacoes:";
            // 
            // dataDevolucaoLabel
            // 
            dataDevolucaoLabel.AutoSize = true;
            dataDevolucaoLabel.ForeColor = System.Drawing.Color.White;
            dataDevolucaoLabel.Location = new System.Drawing.Point(28, 98);
            dataDevolucaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataDevolucaoLabel.Name = "dataDevolucaoLabel";
            dataDevolucaoLabel.Size = new System.Drawing.Size(85, 13);
            dataDevolucaoLabel.TabIndex = 12;
            dataDevolucaoLabel.Text = "Data Devolucao";
            // 
            // dataRetiradaLabel
            // 
            dataRetiradaLabel.AutoSize = true;
            dataRetiradaLabel.ForeColor = System.Drawing.Color.White;
            dataRetiradaLabel.Location = new System.Drawing.Point(28, 24);
            dataRetiradaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataRetiradaLabel.Name = "dataRetiradaLabel";
            dataRetiradaLabel.Size = new System.Drawing.Size(73, 13);
            dataRetiradaLabel.TabIndex = 14;
            dataRetiradaLabel.Text = "Data Retirada";
            // 
            // reservaDataLabel
            // 
            reservaDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            reservaDataLabel.AutoSize = true;
            reservaDataLabel.ForeColor = System.Drawing.Color.White;
            reservaDataLabel.Location = new System.Drawing.Point(645, 195);
            reservaDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            reservaDataLabel.Name = "reservaDataLabel";
            reservaDataLabel.Size = new System.Drawing.Size(60, 13);
            reservaDataLabel.TabIndex = 16;
            reservaDataLabel.Text = "Data Inicial";
            // 
            // reservaHoraLabel
            // 
            reservaHoraLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            reservaHoraLabel.AutoSize = true;
            reservaHoraLabel.ForeColor = System.Drawing.Color.White;
            reservaHoraLabel.Location = new System.Drawing.Point(645, 255);
            reservaHoraLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            reservaHoraLabel.Name = "reservaHoraLabel";
            reservaHoraLabel.Size = new System.Drawing.Size(71, 13);
            reservaHoraLabel.TabIndex = 18;
            reservaHoraLabel.Text = "Horário Inicial";
            // 
            // solicitanteLabel
            // 
            solicitanteLabel.AutoSize = true;
            solicitanteLabel.ForeColor = System.Drawing.Color.White;
            solicitanteLabel.Location = new System.Drawing.Point(81, 105);
            solicitanteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            solicitanteLabel.Name = "solicitanteLabel";
            solicitanteLabel.Size = new System.Drawing.Size(56, 13);
            solicitanteLabel.TabIndex = 20;
            solicitanteLabel.Text = "Solicitante";
            // 
            // statusLabel
            // 
            statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            statusLabel.AutoSize = true;
            statusLabel.ForeColor = System.Drawing.Color.White;
            statusLabel.Location = new System.Drawing.Point(685, 150);
            statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(37, 13);
            statusLabel.TabIndex = 22;
            statusLabel.Text = "Status";
            // 
            // turnoLabel
            // 
            turnoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            turnoLabel.AutoSize = true;
            turnoLabel.ForeColor = System.Drawing.Color.White;
            turnoLabel.Location = new System.Drawing.Point(447, 150);
            turnoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            turnoLabel.Name = "turnoLabel";
            turnoLabel.Size = new System.Drawing.Size(35, 13);
            turnoLabel.TabIndex = 24;
            turnoLabel.Text = "Turno";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(824, 255);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 13);
            label1.TabIndex = 18;
            label1.Text = "Horário final";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(826, 195);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 13);
            label2.TabIndex = 16;
            label2.Text = "Data Final";
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Observacoes", true));
            this.observacoesTextBox.Location = new System.Drawing.Point(82, 210);
            this.observacoesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(471, 80);
            this.observacoesTextBox.TabIndex = 9;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // dataDevolucaoDateTimePicker
            // 
            this.dataDevolucaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "DataDevolucao", true));
            this.dataDevolucaoDateTimePicker.Location = new System.Drawing.Point(31, 113);
            this.dataDevolucaoDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dataDevolucaoDateTimePicker.Name = "dataDevolucaoDateTimePicker";
            this.dataDevolucaoDateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.dataDevolucaoDateTimePicker.TabIndex = 13;
            // 
            // dataRetiradaDateTimePicker
            // 
            this.dataRetiradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "DataRetirada", true));
            this.dataRetiradaDateTimePicker.Location = new System.Drawing.Point(31, 38);
            this.dataRetiradaDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dataRetiradaDateTimePicker.Name = "dataRetiradaDateTimePicker";
            this.dataRetiradaDateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.dataRetiradaDateTimePicker.TabIndex = 15;
            // 
            // reservaDataInicialDateTimePicker
            // 
            this.reservaDataInicialDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reservaDataInicialDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "ReservaDataInicial", true));
            this.reservaDataInicialDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reservaDataInicialDateTimePicker.Location = new System.Drawing.Point(647, 210);
            this.reservaDataInicialDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.reservaDataInicialDateTimePicker.Name = "reservaDataInicialDateTimePicker";
            this.reservaDataInicialDateTimePicker.Size = new System.Drawing.Size(91, 20);
            this.reservaDataInicialDateTimePicker.TabIndex = 17;
            // 
            // reservaHoraInicialDateTimePicker
            // 
            this.reservaHoraInicialDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reservaHoraInicialDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "HoraInicial", true));
            this.reservaHoraInicialDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.reservaHoraInicialDateTimePicker.Location = new System.Drawing.Point(645, 270);
            this.reservaHoraInicialDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.reservaHoraInicialDateTimePicker.Name = "reservaHoraInicialDateTimePicker";
            this.reservaHoraInicialDateTimePicker.ShowUpDown = true;
            this.reservaHoraInicialDateTimePicker.Size = new System.Drawing.Size(91, 20);
            this.reservaHoraInicialDateTimePicker.TabIndex = 19;
            this.reservaHoraInicialDateTimePicker.Value = new System.DateTime(2023, 9, 29, 7, 0, 0, 0);
            this.reservaHoraInicialDateTimePicker.ValueChanged += new System.EventHandler(this.reservaHoraInicialDateTimePicker_ValueChanged);
            // 
            // groupBoxLiberarChave
            // 
            this.groupBoxLiberarChave.Controls.Add(this.buttonDevolucao);
            this.groupBoxLiberarChave.Controls.Add(this.dataRetiradaDateTimePicker);
            this.groupBoxLiberarChave.Controls.Add(this.buttonRetirada);
            this.groupBoxLiberarChave.Controls.Add(this.dataDevolucaoDateTimePicker);
            this.groupBoxLiberarChave.Controls.Add(dataDevolucaoLabel);
            this.groupBoxLiberarChave.Controls.Add(dataRetiradaLabel);
            this.groupBoxLiberarChave.ForeColor = System.Drawing.Color.White;
            this.groupBoxLiberarChave.Location = new System.Drawing.Point(84, 305);
            this.groupBoxLiberarChave.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxLiberarChave.Name = "groupBoxLiberarChave";
            this.groupBoxLiberarChave.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxLiberarChave.Size = new System.Drawing.Size(469, 162);
            this.groupBoxLiberarChave.TabIndex = 28;
            this.groupBoxLiberarChave.TabStop = false;
            this.groupBoxLiberarChave.Text = "Liberação de Chaves";
            // 
            // buttonDevolucao
            // 
            this.buttonDevolucao.BackColor = System.Drawing.Color.Green;
            this.buttonDevolucao.BackgroundColor = System.Drawing.Color.Green;
            this.buttonDevolucao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDevolucao.BorderRadius = 15;
            this.buttonDevolucao.BorderSize = 0;
            this.buttonDevolucao.FlatAppearance.BorderSize = 0;
            this.buttonDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevolucao.ForeColor = System.Drawing.Color.White;
            this.buttonDevolucao.Location = new System.Drawing.Point(323, 98);
            this.buttonDevolucao.Name = "buttonDevolucao";
            this.buttonDevolucao.Size = new System.Drawing.Size(110, 40);
            this.buttonDevolucao.TabIndex = 40;
            this.buttonDevolucao.Text = "Devolução";
            this.buttonDevolucao.TextColor = System.Drawing.Color.White;
            this.buttonDevolucao.UseVisualStyleBackColor = false;
            this.buttonDevolucao.Click += new System.EventHandler(this.buttonDevolucao_Click);
            // 
            // buttonRetirada
            // 
            this.buttonRetirada.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonRetirada.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.buttonRetirada.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonRetirada.BorderRadius = 15;
            this.buttonRetirada.BorderSize = 0;
            this.buttonRetirada.FlatAppearance.BorderSize = 0;
            this.buttonRetirada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetirada.ForeColor = System.Drawing.Color.White;
            this.buttonRetirada.Location = new System.Drawing.Point(323, 30);
            this.buttonRetirada.Name = "buttonRetirada";
            this.buttonRetirada.Size = new System.Drawing.Size(110, 40);
            this.buttonRetirada.TabIndex = 39;
            this.buttonRetirada.Text = "Retirada";
            this.buttonRetirada.TextColor = System.Drawing.Color.White;
            this.buttonRetirada.UseVisualStyleBackColor = false;
            this.buttonRetirada.Click += new System.EventHandler(this.buttonRetirada_Click);
            // 
            // comboBoxSala
            // 
            this.comboBoxSala.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdSala", true));
            this.comboBoxSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSala.FormattingEnabled = true;
            this.comboBoxSala.Location = new System.Drawing.Point(83, 165);
            this.comboBoxSala.Name = "comboBoxSala";
            this.comboBoxSala.Size = new System.Drawing.Size(290, 21);
            this.comboBoxSala.TabIndex = 30;
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "StatusReserva", true));
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.comboBoxStatus.Location = new System.Drawing.Point(687, 165);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(232, 21);
            this.comboBoxStatus.TabIndex = 31;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTurno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Turno", true));
            this.comboBoxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Notuno"});
            this.comboBoxTurno.Location = new System.Drawing.Point(448, 165);
            this.comboBoxTurno.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(235, 21);
            this.comboBoxTurno.TabIndex = 31;
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdCurso", true));
            this.comboBoxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(447, 68);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(472, 21);
            this.comboBoxCurso.TabIndex = 30;
            // 
            // comboBoxSolicitante
            // 
            this.comboBoxSolicitante.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdSolicitante", true));
            this.comboBoxSolicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSolicitante.FormattingEnabled = true;
            this.comboBoxSolicitante.Location = new System.Drawing.Point(83, 121);
            this.comboBoxSolicitante.Name = "comboBoxSolicitante";
            this.comboBoxSolicitante.Size = new System.Drawing.Size(290, 21);
            this.comboBoxSolicitante.TabIndex = 32;
            // 
            // comboBoxResponsavel
            // 
            this.comboBoxResponsavel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdResponsavel", true));
            this.comboBoxResponsavel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResponsavel.FormattingEnabled = true;
            this.comboBoxResponsavel.Location = new System.Drawing.Point(82, 68);
            this.comboBoxResponsavel.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxResponsavel.Name = "comboBoxResponsavel";
            this.comboBoxResponsavel.Size = new System.Drawing.Size(291, 21);
            this.comboBoxResponsavel.TabIndex = 34;
            // 
            // reservaHoraFinalDateTimePicker
            // 
            this.reservaHoraFinalDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reservaHoraFinalDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "HoraFinal", true));
            this.reservaHoraFinalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.reservaHoraFinalDateTimePicker.Location = new System.Drawing.Point(827, 270);
            this.reservaHoraFinalDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.reservaHoraFinalDateTimePicker.Name = "reservaHoraFinalDateTimePicker";
            this.reservaHoraFinalDateTimePicker.ShowUpDown = true;
            this.reservaHoraFinalDateTimePicker.Size = new System.Drawing.Size(91, 20);
            this.reservaHoraFinalDateTimePicker.TabIndex = 19;
            this.reservaHoraFinalDateTimePicker.Value = new System.DateTime(2023, 9, 29, 7, 0, 0, 0);
            this.reservaHoraFinalDateTimePicker.ValueChanged += new System.EventHandler(this.reservaHoraFinalDateTimePicker_ValueChanged);
            // 
            // reservaDataFinalDateTimePicker
            // 
            this.reservaDataFinalDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reservaDataFinalDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "ReservaDataFinal", true));
            this.reservaDataFinalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reservaDataFinalDateTimePicker.Location = new System.Drawing.Point(828, 210);
            this.reservaDataFinalDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.reservaDataFinalDateTimePicker.Name = "reservaDataFinalDateTimePicker";
            this.reservaDataFinalDateTimePicker.Size = new System.Drawing.Size(91, 20);
            this.reservaDataFinalDateTimePicker.TabIndex = 17;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panelBarraTitulo.Controls.Add(this.labelMenu);
            this.panelBarraTitulo.Controls.Add(this.buttonMinimizar);
            this.panelBarraTitulo.Controls.Add(this.buttonRestaurar);
            this.panelBarraTitulo.Controls.Add(this.buttonMaximizar);
            this.panelBarraTitulo.Controls.Add(this.buttonFechar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1040, 40);
            this.panelBarraTitulo.TabIndex = 36;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMenu.Location = new System.Drawing.Point(3, 8);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(66, 25);
            this.labelMenu.TabIndex = 4;
            this.labelMenu.Text = "Menu";
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimizar.Enabled = false;
            this.buttonMinimizar.Image = global::UILGerenReservasLab.Properties.Resources.minimizar;
            this.buttonMinimizar.Location = new System.Drawing.Point(916, 6);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(35, 28);
            this.buttonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMinimizar.TabIndex = 3;
            this.buttonMinimizar.TabStop = false;
            this.buttonMinimizar.Visible = false;
            // 
            // buttonRestaurar
            // 
            this.buttonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestaurar.Enabled = false;
            this.buttonRestaurar.Image = global::UILGerenReservasLab.Properties.Resources.res;
            this.buttonRestaurar.Location = new System.Drawing.Point(957, 6);
            this.buttonRestaurar.Name = "buttonRestaurar";
            this.buttonRestaurar.Size = new System.Drawing.Size(35, 28);
            this.buttonRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonRestaurar.TabIndex = 2;
            this.buttonRestaurar.TabStop = false;
            this.buttonRestaurar.Visible = false;
            // 
            // buttonMaximizar
            // 
            this.buttonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaximizar.Enabled = false;
            this.buttonMaximizar.Image = global::UILGerenReservasLab.Properties.Resources.maxi;
            this.buttonMaximizar.Location = new System.Drawing.Point(957, 6);
            this.buttonMaximizar.Name = "buttonMaximizar";
            this.buttonMaximizar.Size = new System.Drawing.Size(35, 28);
            this.buttonMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMaximizar.TabIndex = 1;
            this.buttonMaximizar.TabStop = false;
            this.buttonMaximizar.Visible = false;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFechar.Image = global::UILGerenReservasLab.Properties.Resources.fechar;
            this.buttonFechar.Location = new System.Drawing.Point(998, 6);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(35, 28);
            this.buttonFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonFechar.TabIndex = 0;
            this.buttonFechar.TabStop = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdDisciplina", true));
            this.comboBoxDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(447, 121);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(472, 21);
            this.comboBoxDisciplina.TabIndex = 38;
            // 
            // buttonSalvarReserva
            // 
            this.buttonSalvarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonSalvarReserva.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonSalvarReserva.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSalvarReserva.BorderRadius = 15;
            this.buttonSalvarReserva.BorderSize = 0;
            this.buttonSalvarReserva.FlatAppearance.BorderSize = 0;
            this.buttonSalvarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarReserva.ForeColor = System.Drawing.Color.White;
            this.buttonSalvarReserva.Location = new System.Drawing.Point(591, 427);
            this.buttonSalvarReserva.Name = "buttonSalvarReserva";
            this.buttonSalvarReserva.Size = new System.Drawing.Size(150, 40);
            this.buttonSalvarReserva.TabIndex = 39;
            this.buttonSalvarReserva.Text = "&Salvar";
            this.buttonSalvarReserva.TextColor = System.Drawing.Color.White;
            this.buttonSalvarReserva.UseVisualStyleBackColor = false;
            this.buttonSalvarReserva.Click += new System.EventHandler(this.buttonSalvarReserva_Click_1);
            // 
            // buttonCancelarReserva
            // 
            this.buttonCancelarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonCancelarReserva.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonCancelarReserva.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCancelarReserva.BorderRadius = 15;
            this.buttonCancelarReserva.BorderSize = 0;
            this.buttonCancelarReserva.FlatAppearance.BorderSize = 0;
            this.buttonCancelarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarReserva.ForeColor = System.Drawing.Color.White;
            this.buttonCancelarReserva.Location = new System.Drawing.Point(769, 427);
            this.buttonCancelarReserva.Name = "buttonCancelarReserva";
            this.buttonCancelarReserva.Size = new System.Drawing.Size(150, 40);
            this.buttonCancelarReserva.TabIndex = 40;
            this.buttonCancelarReserva.Text = "&Cancelar";
            this.buttonCancelarReserva.TextColor = System.Drawing.Color.White;
            this.buttonCancelarReserva.UseVisualStyleBackColor = false;
            this.buttonCancelarReserva.Click += new System.EventHandler(this.buttonCancelarReserva_Click);
            // 
            // FormCadastroReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1040, 491);
            this.Controls.Add(this.buttonCancelarReserva);
            this.Controls.Add(this.buttonSalvarReserva);
            this.Controls.Add(this.comboBoxDisciplina);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.comboBoxResponsavel);
            this.Controls.Add(this.comboBoxSolicitante);
            this.Controls.Add(this.comboBoxTurno);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxCurso);
            this.Controls.Add(this.comboBoxSala);
            this.Controls.Add(this.groupBoxLiberarChave);
            this.Controls.Add(turnoLabel);
            this.Controls.Add(statusLabel);
            this.Controls.Add(solicitanteLabel);
            this.Controls.Add(label1);
            this.Controls.Add(reservaHoraLabel);
            this.Controls.Add(this.reservaHoraFinalDateTimePicker);
            this.Controls.Add(this.reservaHoraInicialDateTimePicker);
            this.Controls.Add(label2);
            this.Controls.Add(reservaDataLabel);
            this.Controls.Add(this.reservaDataFinalDateTimePicker);
            this.Controls.Add(this.reservaDataInicialDateTimePicker);
            this.Controls.Add(observacoesLabel);
            this.Controls.Add(this.observacoesTextBox);
            this.Controls.Add(idUsuarioLabel);
            this.Controls.Add(idSalaLabel);
            this.Controls.Add(idDisciplinaLabel);
            this.Controls.Add(idCursoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCadastroReservas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de Reservas";
            this.Load += new System.EventHandler(this.FormCadastroReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            this.groupBoxLiberarChave.ResumeLayout(false);
            this.groupBoxLiberarChave.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.DateTimePicker dataDevolucaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataRetiradaDateTimePicker;
        private System.Windows.Forms.DateTimePicker reservaDataInicialDateTimePicker;
        private System.Windows.Forms.DateTimePicker reservaHoraInicialDateTimePicker;
        private System.Windows.Forms.GroupBox groupBoxLiberarChave;
        private System.Windows.Forms.ComboBox comboBoxSala;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.ComboBox comboBoxSolicitante;
        private System.Windows.Forms.ComboBox comboBoxResponsavel;
        private System.Windows.Forms.DateTimePicker reservaHoraFinalDateTimePicker;
        private System.Windows.Forms.DateTimePicker reservaDataFinalDateTimePicker;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.PictureBox buttonMinimizar;
        private System.Windows.Forms.PictureBox buttonRestaurar;
        private System.Windows.Forms.PictureBox buttonMaximizar;
        private System.Windows.Forms.PictureBox buttonFechar;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private CustomControls.RJControls.RJButton buttonRetirada;
        private CustomControls.RJControls.RJButton buttonDevolucao;
        private CustomControls.RJControls.RJButton buttonSalvarReserva;
        private CustomControls.RJControls.RJButton buttonCancelarReserva;
    }
}