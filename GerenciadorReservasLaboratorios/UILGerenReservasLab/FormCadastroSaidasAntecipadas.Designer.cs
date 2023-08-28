namespace UILGerenReservasLab
{
    partial class FormCadastroSaidasAntecipadas
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
            System.Windows.Forms.Label dataHoraSaidaLabel;
            System.Windows.Forms.Label idAlunoLabel;
            System.Windows.Forms.Label idCoordenacaoLabel;
            System.Windows.Forms.Label idProfessorLabel;
            System.Windows.Forms.Label motivoLabel;
            System.Windows.Forms.Label statusLabel;
            this.dataHoraSaidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saidasAntecipadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AlunoTextBox = new System.Windows.Forms.TextBox();
            this.idCoordenacaoTextBox = new System.Windows.Forms.TextBox();
            this.idProfessorTextBox = new System.Windows.Forms.TextBox();
            this.motivoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBuscarAluno = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            dataHoraSaidaLabel = new System.Windows.Forms.Label();
            idAlunoLabel = new System.Windows.Forms.Label();
            idCoordenacaoLabel = new System.Windows.Forms.Label();
            idProfessorLabel = new System.Windows.Forms.Label();
            motivoLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.saidasAntecipadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHoraSaidaLabel
            // 
            dataHoraSaidaLabel.AutoSize = true;
            dataHoraSaidaLabel.Location = new System.Drawing.Point(9, 197);
            dataHoraSaidaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataHoraSaidaLabel.Name = "dataHoraSaidaLabel";
            dataHoraSaidaLabel.Size = new System.Drawing.Size(139, 13);
            dataHoraSaidaLabel.TabIndex = 1;
            dataHoraSaidaLabel.Text = "Data e Hora da Autorização";
            // 
            // idAlunoLabel
            // 
            idAlunoLabel.AutoSize = true;
            idAlunoLabel.Location = new System.Drawing.Point(10, 78);
            idAlunoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idAlunoLabel.Name = "idAlunoLabel";
            idAlunoLabel.Size = new System.Drawing.Size(34, 13);
            idAlunoLabel.TabIndex = 3;
            idAlunoLabel.Text = "Aluno";
            // 
            // idCoordenacaoLabel
            // 
            idCoordenacaoLabel.AutoSize = true;
            idCoordenacaoLabel.Location = new System.Drawing.Point(406, 135);
            idCoordenacaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idCoordenacaoLabel.Name = "idCoordenacaoLabel";
            idCoordenacaoLabel.Size = new System.Drawing.Size(71, 13);
            idCoordenacaoLabel.TabIndex = 5;
            idCoordenacaoLabel.Text = "Coordenacao";
            // 
            // idProfessorLabel
            // 
            idProfessorLabel.AutoSize = true;
            idProfessorLabel.Location = new System.Drawing.Point(406, 82);
            idProfessorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idProfessorLabel.Name = "idProfessorLabel";
            idProfessorLabel.Size = new System.Drawing.Size(51, 13);
            idProfessorLabel.TabIndex = 7;
            idProfessorLabel.Text = "Professor";
            // 
            // motivoLabel
            // 
            motivoLabel.AutoSize = true;
            motivoLabel.Location = new System.Drawing.Point(10, 245);
            motivoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            motivoLabel.Name = "motivoLabel";
            motivoLabel.Size = new System.Drawing.Size(42, 13);
            motivoLabel.TabIndex = 9;
            motivoLabel.Text = "Motivo:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(9, 133);
            statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 11;
            statusLabel.Text = "Status:";
            // 
            // dataHoraSaidaDateTimePicker
            // 
            this.dataHoraSaidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.saidasAntecipadasBindingSource, "DataHoraSaida", true));
            this.dataHoraSaidaDateTimePicker.Location = new System.Drawing.Point(9, 210);
            this.dataHoraSaidaDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dataHoraSaidaDateTimePicker.Name = "dataHoraSaidaDateTimePicker";
            this.dataHoraSaidaDateTimePicker.Size = new System.Drawing.Size(279, 20);
            this.dataHoraSaidaDateTimePicker.TabIndex = 2;
            // 
            // saidasAntecipadasBindingSource
            // 
            this.saidasAntecipadasBindingSource.DataSource = typeof(Models.SaidasAntecipadas);
            // 
            // AlunoTextBox
            // 
            this.AlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saidasAntecipadasBindingSource, "IdAluno", true));
            this.AlunoTextBox.Location = new System.Drawing.Point(9, 95);
            this.AlunoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AlunoTextBox.Name = "AlunoTextBox";
            this.AlunoTextBox.Size = new System.Drawing.Size(392, 20);
            this.AlunoTextBox.TabIndex = 4;
            // 
            // idCoordenacaoTextBox
            // 
            this.idCoordenacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saidasAntecipadasBindingSource, "IdCoordenacao", true));
            this.idCoordenacaoTextBox.Location = new System.Drawing.Point(405, 151);
            this.idCoordenacaoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idCoordenacaoTextBox.Name = "idCoordenacaoTextBox";
            this.idCoordenacaoTextBox.Size = new System.Drawing.Size(496, 20);
            this.idCoordenacaoTextBox.TabIndex = 6;
            // 
            // idProfessorTextBox
            // 
            this.idProfessorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saidasAntecipadasBindingSource, "IdProfessor", true));
            this.idProfessorTextBox.Location = new System.Drawing.Point(405, 95);
            this.idProfessorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idProfessorTextBox.Name = "idProfessorTextBox";
            this.idProfessorTextBox.Size = new System.Drawing.Size(500, 20);
            this.idProfessorTextBox.TabIndex = 8;
            // 
            // motivoTextBox
            // 
            this.motivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saidasAntecipadasBindingSource, "Motivo", true));
            this.motivoTextBox.Location = new System.Drawing.Point(7, 260);
            this.motivoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.motivoTextBox.Name = "motivoTextBox";
            this.motivoTextBox.Size = new System.Drawing.Size(894, 20);
            this.motivoTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1040, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cadastro de Saídas Antecipadas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSalvar.Location = new System.Drawing.Point(637, 389);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(117, 42);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelar.Location = new System.Drawing.Point(784, 389);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(117, 42);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonBuscarAluno
            // 
            this.buttonBuscarAluno.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBuscarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarAluno.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarAluno.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarAluno.Location = new System.Drawing.Point(326, 67);
            this.buttonBuscarAluno.Name = "buttonBuscarAluno";
            this.buttonBuscarAluno.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarAluno.TabIndex = 16;
            this.buttonBuscarAluno.Text = "&Buscar";
            this.buttonBuscarAluno.UseVisualStyleBackColor = false;
            this.buttonBuscarAluno.Click += new System.EventHandler(this.buttonBuscarAluno_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Em Análise",
            "Autorizada",
            "Negada"});
            this.comboBoxStatus.Location = new System.Drawing.Point(12, 150);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(227, 21);
            this.comboBoxStatus.TabIndex = 18;
            // 
            // FormCadastroSaidasAntecipadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1040, 491);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonBuscarAluno);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(statusLabel);
            this.Controls.Add(motivoLabel);
            this.Controls.Add(this.motivoTextBox);
            this.Controls.Add(idProfessorLabel);
            this.Controls.Add(this.idProfessorTextBox);
            this.Controls.Add(idCoordenacaoLabel);
            this.Controls.Add(this.idCoordenacaoTextBox);
            this.Controls.Add(idAlunoLabel);
            this.Controls.Add(this.AlunoTextBox);
            this.Controls.Add(dataHoraSaidaLabel);
            this.Controls.Add(this.dataHoraSaidaDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCadastroSaidasAntecipadas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Saidas Antecipadas";
            this.Load += new System.EventHandler(this.FormCadastroSaidasAntecipadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saidasAntecipadasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource saidasAntecipadasBindingSource;
        private System.Windows.Forms.DateTimePicker dataHoraSaidaDateTimePicker;
        private System.Windows.Forms.TextBox AlunoTextBox;
        private System.Windows.Forms.TextBox idCoordenacaoTextBox;
        private System.Windows.Forms.TextBox idProfessorTextBox;
        private System.Windows.Forms.TextBox motivoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBuscarAluno;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}