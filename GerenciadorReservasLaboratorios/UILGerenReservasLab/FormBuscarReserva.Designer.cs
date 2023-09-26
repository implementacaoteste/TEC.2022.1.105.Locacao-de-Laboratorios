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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeSolicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.reservaDataGridView.ColumnHeadersHeight = 35;
            this.reservaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NomeResponsavel,
            this.NomeSolicitante,
            this.NomeSala,
            this.NomeCurso,
            this.NomeDisciplina,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.reservaDataGridView.DataSource = this.reservaBindingSource;
            this.reservaDataGridView.Location = new System.Drawing.Point(59, 142);
            this.reservaDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.reservaDataGridView.MultiSelect = false;
            this.reservaDataGridView.Name = "reservaDataGridView";
            this.reservaDataGridView.ReadOnly = true;
            this.reservaDataGridView.RowHeadersVisible = false;
            this.reservaDataGridView.RowHeadersWidth = 51;
            this.reservaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.reservaDataGridView.RowTemplate.Height = 24;
            this.reservaDataGridView.Size = new System.Drawing.Size(898, 409);
            this.reservaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // NomeResponsavel
            // 
            this.NomeResponsavel.DataPropertyName = "NomeResponsavel";
            this.NomeResponsavel.HeaderText = "Responsável";
            this.NomeResponsavel.MinimumWidth = 6;
            this.NomeResponsavel.Name = "NomeResponsavel";
            this.NomeResponsavel.ReadOnly = true;
            this.NomeResponsavel.Width = 125;
            // 
            // NomeSolicitante
            // 
            this.NomeSolicitante.DataPropertyName = "NomeSolicitante";
            this.NomeSolicitante.HeaderText = "Solicitante";
            this.NomeSolicitante.MinimumWidth = 6;
            this.NomeSolicitante.Name = "NomeSolicitante";
            this.NomeSolicitante.ReadOnly = true;
            this.NomeSolicitante.Width = 125;
            // 
            // NomeSala
            // 
            this.NomeSala.DataPropertyName = "NomeSala";
            this.NomeSala.HeaderText = "Sala";
            this.NomeSala.MinimumWidth = 6;
            this.NomeSala.Name = "NomeSala";
            this.NomeSala.ReadOnly = true;
            this.NomeSala.Width = 125;
            // 
            // NomeCurso
            // 
            this.NomeCurso.DataPropertyName = "NomeCurso";
            this.NomeCurso.HeaderText = "Curso";
            this.NomeCurso.MinimumWidth = 6;
            this.NomeCurso.Name = "NomeCurso";
            this.NomeCurso.ReadOnly = true;
            this.NomeCurso.Width = 125;
            // 
            // NomeDisciplina
            // 
            this.NomeDisciplina.DataPropertyName = "NomeDisciplina";
            this.NomeDisciplina.HeaderText = "Disciplina";
            this.NomeDisciplina.MinimumWidth = 6;
            this.NomeDisciplina.Name = "NomeDisciplina";
            this.NomeDisciplina.ReadOnly = true;
            this.NomeDisciplina.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Turno";
            this.dataGridViewTextBoxColumn13.HeaderText = "Turno";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ReservaData";
            this.dataGridViewTextBoxColumn7.HeaderText = "Data da Reserva";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 170;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ReservaHora";
            this.dataGridViewTextBoxColumn8.HeaderText = "Hora da Reserva";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 170;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn11.HeaderText = "Status";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Observacoes";
            this.dataGridViewTextBoxColumn12.HeaderText = "Observacoes";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DataRetirada";
            this.dataGridViewTextBoxColumn9.HeaderText = "Retirada da chave";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 180;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DataDevolucao";
            this.dataGridViewTextBoxColumn10.HeaderText = "Devolucao da chave";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 180;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // textBoxBuscarReserva
            // 
            this.textBoxBuscarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscarReserva.Location = new System.Drawing.Point(210, 111);
            this.textBoxBuscarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscarReserva.Name = "textBoxBuscarReserva";
            this.textBoxBuscarReserva.Size = new System.Drawing.Size(745, 22);
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
            this.comboBoxBuscarReservaPor.Location = new System.Drawing.Point(61, 111);
            this.comboBoxBuscarReservaPor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBuscarReservaPor.Name = "comboBoxBuscarReservaPor";
            this.comboBoxBuscarReservaPor.Size = new System.Drawing.Size(143, 24);
            this.comboBoxBuscarReservaPor.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar Por";
            // 
            // buttonSelecionarAluno
            // 
            this.buttonSelecionarAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionarAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonSelecionarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarAluno.ForeColor = System.Drawing.Color.White;
            this.buttonSelecionarAluno.Location = new System.Drawing.Point(961, 500);
            this.buttonSelecionarAluno.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionarAluno.Name = "buttonSelecionarAluno";
            this.buttonSelecionarAluno.Size = new System.Drawing.Size(221, 52);
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
            this.buttonInserirReserva.Location = new System.Drawing.Point(961, 261);
            this.buttonInserirReserva.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInserirReserva.Name = "buttonInserirReserva";
            this.buttonInserirReserva.Size = new System.Drawing.Size(221, 52);
            this.buttonInserirReserva.TabIndex = 34;
            this.buttonInserirReserva.Text = "&Inserir";
            this.buttonInserirReserva.UseVisualStyleBackColor = false;
            this.buttonInserirReserva.Click += new System.EventHandler(this.buttonInserirReserva_Click);
            // 
            // buttonExcluirReserva
            // 
            this.buttonExcluirReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirReserva.BackColor = System.Drawing.Color.Tomato;
            this.buttonExcluirReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirReserva.ForeColor = System.Drawing.Color.White;
            this.buttonExcluirReserva.Location = new System.Drawing.Point(961, 406);
            this.buttonExcluirReserva.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluirReserva.Name = "buttonExcluirReserva";
            this.buttonExcluirReserva.Size = new System.Drawing.Size(221, 52);
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
            this.buttonAlterarReserva.Location = new System.Drawing.Point(961, 188);
            this.buttonAlterarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterarReserva.Name = "buttonAlterarReserva";
            this.buttonAlterarReserva.Size = new System.Drawing.Size(221, 52);
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
            this.buttonBuscar.Location = new System.Drawing.Point(961, 112);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(221, 52);
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
            this.buttonFechar.Location = new System.Drawing.Point(1193, 13);
            this.buttonFechar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(94, 29);
            this.buttonFechar.TabIndex = 38;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormBuscarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1300, 614);
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
            this.Text = "Pesquisa de Reservas";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeResponsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeSolicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}