namespace UILGerenReservasLab
{
    partial class FormBuscarReserva
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
            this.reservaDataGridView = new System.Windows.Forms.DataGridView();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBuscarReserva = new System.Windows.Forms.TextBox();
            this.comboBoxBuscarReservaPor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelecionarAluno = new System.Windows.Forms.Button();
            this.buttonInserirReserva = new System.Windows.Forms.Button();
            this.buttonExcluirReserva = new System.Windows.Forms.Button();
            this.buttonAlterarReserva = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeSolicitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDisciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservaDataInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservaDataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRetirada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reservaDataGridView
            // 
            this.reservaDataGridView.AllowUserToAddRows = false;
            this.reservaDataGridView.AllowUserToDeleteRows = false;
            this.reservaDataGridView.AllowUserToOrderColumns = true;
            this.reservaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservaDataGridView.AutoGenerateColumns = false;
            this.reservaDataGridView.ColumnHeadersHeight = 30;
            this.reservaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.reservaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.StatusReserva,
            this.nomeSolicitanteDataGridViewTextBoxColumn,
            this.nomeResponsavelDataGridViewTextBoxColumn,
            this.nomeSalaDataGridViewTextBoxColumn,
            this.nomeCursoDataGridViewTextBoxColumn,
            this.nomeDisciplinaDataGridViewTextBoxColumn,
            this.Turno,
            this.ReservaDataInicial,
            this.ReservaDataFinal,
            this.HoraInicial,
            this.HoraFinal,
            this.DataRetirada,
            this.DataDevolucao,
            this.Observacoes});
            this.reservaDataGridView.DataSource = this.reservaBindingSource;
            this.reservaDataGridView.Location = new System.Drawing.Point(47, 114);
            this.reservaDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.reservaDataGridView.MultiSelect = false;
            this.reservaDataGridView.Name = "reservaDataGridView";
            this.reservaDataGridView.ReadOnly = true;
            this.reservaDataGridView.RowHeadersVisible = false;
            this.reservaDataGridView.RowHeadersWidth = 51;
            this.reservaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.reservaDataGridView.RowTemplate.Height = 24;
            this.reservaDataGridView.Size = new System.Drawing.Size(718, 327);
            this.reservaDataGridView.TabIndex = 1;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // textBoxBuscarReserva
            // 
            this.textBoxBuscarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscarReserva.Location = new System.Drawing.Point(168, 89);
            this.textBoxBuscarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscarReserva.Name = "textBoxBuscarReserva";
            this.textBoxBuscarReserva.Size = new System.Drawing.Size(597, 20);
            this.textBoxBuscarReserva.TabIndex = 13;
            // 
            // comboBoxBuscarReservaPor
            // 
            this.comboBoxBuscarReservaPor.FormattingEnabled = true;
            this.comboBoxBuscarReservaPor.Items.AddRange(new object[] {
            "Id",
            "Solicitante",
            "Responsável",
            "Sala",
            "Disciplina",
            "Curso",
            "Turno",
            "Data",
            "Status",
            "Todos"});
            this.comboBoxBuscarReservaPor.Location = new System.Drawing.Point(47, 89);
            this.comboBoxBuscarReservaPor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBuscarReservaPor.Name = "comboBoxBuscarReservaPor";
            this.comboBoxBuscarReservaPor.Size = new System.Drawing.Size(115, 21);
            this.comboBoxBuscarReservaPor.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar por";
            // 
            // buttonSelecionarAluno
            // 
            this.buttonSelecionarAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionarAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonSelecionarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarAluno.ForeColor = System.Drawing.Color.White;
            this.buttonSelecionarAluno.Location = new System.Drawing.Point(769, 400);
            this.buttonSelecionarAluno.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionarAluno.Name = "buttonSelecionarAluno";
            this.buttonSelecionarAluno.Size = new System.Drawing.Size(177, 42);
            this.buttonSelecionarAluno.TabIndex = 33;
            this.buttonSelecionarAluno.Text = "&Selecionar";
            this.buttonSelecionarAluno.UseVisualStyleBackColor = false;
            this.buttonSelecionarAluno.Click += new System.EventHandler(this.buttonSelecionarAluno_Click);
            // 
            // buttonInserirReserva
            // 
            this.buttonInserirReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInserirReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonInserirReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserirReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserirReserva.ForeColor = System.Drawing.Color.White;
            this.buttonInserirReserva.Location = new System.Drawing.Point(769, 209);
            this.buttonInserirReserva.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInserirReserva.Name = "buttonInserirReserva";
            this.buttonInserirReserva.Size = new System.Drawing.Size(177, 42);
            this.buttonInserirReserva.TabIndex = 34;
            this.buttonInserirReserva.Text = "&Inserir";
            this.buttonInserirReserva.UseVisualStyleBackColor = false;
            this.buttonInserirReserva.Click += new System.EventHandler(this.buttonInserirReserva_Click);
            // 
            // buttonExcluirReserva
            // 
            this.buttonExcluirReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirReserva.BackColor = System.Drawing.Color.Red;
            this.buttonExcluirReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirReserva.ForeColor = System.Drawing.Color.White;
            this.buttonExcluirReserva.Location = new System.Drawing.Point(769, 325);
            this.buttonExcluirReserva.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluirReserva.Name = "buttonExcluirReserva";
            this.buttonExcluirReserva.Size = new System.Drawing.Size(177, 42);
            this.buttonExcluirReserva.TabIndex = 35;
            this.buttonExcluirReserva.Text = "&Excluir";
            this.buttonExcluirReserva.UseVisualStyleBackColor = false;
            this.buttonExcluirReserva.Click += new System.EventHandler(this.buttonExcluirReserva_Click);
            // 
            // buttonAlterarReserva
            // 
            this.buttonAlterarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonAlterarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarReserva.ForeColor = System.Drawing.Color.White;
            this.buttonAlterarReserva.Location = new System.Drawing.Point(769, 150);
            this.buttonAlterarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterarReserva.Name = "buttonAlterarReserva";
            this.buttonAlterarReserva.Size = new System.Drawing.Size(177, 42);
            this.buttonAlterarReserva.TabIndex = 36;
            this.buttonAlterarReserva.Text = "&Alterar";
            this.buttonAlterarReserva.UseVisualStyleBackColor = false;
            this.buttonAlterarReserva.Click += new System.EventHandler(this.buttonAlterarReserva_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBuscar.Location = new System.Drawing.Point(769, 90);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(177, 42);
            this.buttonBuscar.TabIndex = 37;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFechar.BackColor = System.Drawing.Color.Red;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.ForeColor = System.Drawing.Color.White;
            this.buttonFechar.Location = new System.Drawing.Point(954, 10);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 38;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Solicitante";
            this.dataGridViewTextBoxColumn1.HeaderText = "Solicitante";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Responsavel";
            this.dataGridViewTextBoxColumn2.HeaderText = "Responsavel";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sala";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sala";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Curso";
            this.dataGridViewTextBoxColumn4.HeaderText = "Curso";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Disciplina";
            this.dataGridViewTextBoxColumn5.HeaderText = "Disciplina";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // StatusReserva
            // 
            this.StatusReserva.DataPropertyName = "StatusReserva";
            this.StatusReserva.HeaderText = "Status";
            this.StatusReserva.Name = "StatusReserva";
            this.StatusReserva.ReadOnly = true;
            // 
            // nomeSolicitanteDataGridViewTextBoxColumn
            // 
            this.nomeSolicitanteDataGridViewTextBoxColumn.DataPropertyName = "NomeSolicitante";
            this.nomeSolicitanteDataGridViewTextBoxColumn.HeaderText = "Solicitante";
            this.nomeSolicitanteDataGridViewTextBoxColumn.Name = "nomeSolicitanteDataGridViewTextBoxColumn";
            this.nomeSolicitanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeResponsavelDataGridViewTextBoxColumn
            // 
            this.nomeResponsavelDataGridViewTextBoxColumn.DataPropertyName = "NomeResponsavel";
            this.nomeResponsavelDataGridViewTextBoxColumn.HeaderText = "Liberada por";
            this.nomeResponsavelDataGridViewTextBoxColumn.Name = "nomeResponsavelDataGridViewTextBoxColumn";
            this.nomeResponsavelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeSalaDataGridViewTextBoxColumn
            // 
            this.nomeSalaDataGridViewTextBoxColumn.DataPropertyName = "NomeSala";
            this.nomeSalaDataGridViewTextBoxColumn.HeaderText = "Sala";
            this.nomeSalaDataGridViewTextBoxColumn.Name = "nomeSalaDataGridViewTextBoxColumn";
            this.nomeSalaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeCursoDataGridViewTextBoxColumn
            // 
            this.nomeCursoDataGridViewTextBoxColumn.DataPropertyName = "NomeCurso";
            this.nomeCursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.nomeCursoDataGridViewTextBoxColumn.Name = "nomeCursoDataGridViewTextBoxColumn";
            this.nomeCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDisciplinaDataGridViewTextBoxColumn
            // 
            this.nomeDisciplinaDataGridViewTextBoxColumn.DataPropertyName = "NomeDisciplina";
            this.nomeDisciplinaDataGridViewTextBoxColumn.HeaderText = "Disciplina";
            this.nomeDisciplinaDataGridViewTextBoxColumn.Name = "nomeDisciplinaDataGridViewTextBoxColumn";
            this.nomeDisciplinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Turno
            // 
            this.Turno.DataPropertyName = "Turno";
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.ReadOnly = true;
            // 
            // ReservaDataInicial
            // 
            this.ReservaDataInicial.DataPropertyName = "ReservaDataInicial";
            this.ReservaDataInicial.HeaderText = "Data início";
            this.ReservaDataInicial.Name = "ReservaDataInicial";
            this.ReservaDataInicial.ReadOnly = true;
            // 
            // ReservaDataFinal
            // 
            this.ReservaDataFinal.DataPropertyName = "ReservaDataFinal";
            this.ReservaDataFinal.HeaderText = "Data final";
            this.ReservaDataFinal.Name = "ReservaDataFinal";
            this.ReservaDataFinal.ReadOnly = true;
            // 
            // HoraInicial
            // 
            this.HoraInicial.DataPropertyName = "HoraInicial";
            this.HoraInicial.HeaderText = "Hora início";
            this.HoraInicial.Name = "HoraInicial";
            this.HoraInicial.ReadOnly = true;
            // 
            // HoraFinal
            // 
            this.HoraFinal.DataPropertyName = "HoraFinal";
            this.HoraFinal.HeaderText = "Hora final";
            this.HoraFinal.Name = "HoraFinal";
            this.HoraFinal.ReadOnly = true;
            // 
            // DataRetirada
            // 
            this.DataRetirada.DataPropertyName = "DataRetirada";
            this.DataRetirada.HeaderText = "Retirada da chave";
            this.DataRetirada.Name = "DataRetirada";
            this.DataRetirada.ReadOnly = true;
            this.DataRetirada.Width = 150;
            // 
            // DataDevolucao
            // 
            this.DataDevolucao.DataPropertyName = "DataDevolucao";
            this.DataDevolucao.HeaderText = "Devolução da chave";
            this.DataDevolucao.Name = "DataDevolucao";
            this.DataDevolucao.ReadOnly = true;
            this.DataDevolucao.Width = 150;
            // 
            // Observacoes
            // 
            this.Observacoes.DataPropertyName = "Observacoes";
            this.Observacoes.HeaderText = "Observacoes";
            this.Observacoes.Name = "Observacoes";
            this.Observacoes.ReadOnly = true;
            // 
            // FormBuscarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1040, 491);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonSelecionarAluno);
            this.Controls.Add(this.buttonInserirReserva);
            this.Controls.Add(this.buttonExcluirReserva);
            this.Controls.Add(this.buttonAlterarReserva);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBoxBuscarReservaPor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBuscarReserva);
            this.Controls.Add(this.reservaDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBuscarReserva";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Pesquisa de Reservas";
            this.Load += new System.EventHandler(this.FormBuscarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.DataGridView reservaDataGridView;
        private System.Windows.Forms.TextBox textBoxBuscarReserva;
        private System.Windows.Forms.ComboBox comboBoxBuscarReservaPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelecionarAluno;
        private System.Windows.Forms.Button buttonInserirReserva;
        private System.Windows.Forms.Button buttonExcluirReserva;
        private System.Windows.Forms.Button buttonAlterarReserva;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeSolicitanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeSalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDisciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservaDataInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservaDataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacoes;
    }
}