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
            this.idAlunoTextBox = new System.Windows.Forms.TextBox();
            this.idCoordenacaoTextBox = new System.Windows.Forms.TextBox();
            this.idProfessorTextBox = new System.Windows.Forms.TextBox();
            this.motivoTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.saidasAntecipadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            dataHoraSaidaLabel.Location = new System.Drawing.Point(165, 217);
            dataHoraSaidaLabel.Name = "dataHoraSaidaLabel";
            dataHoraSaidaLabel.Size = new System.Drawing.Size(136, 16);
            dataHoraSaidaLabel.TabIndex = 1;
            dataHoraSaidaLabel.Text = "Data e Hora da saida";
            // 
            // idAlunoLabel
            // 
            idAlunoLabel.AutoSize = true;
            idAlunoLabel.Location = new System.Drawing.Point(13, 96);
            idAlunoLabel.Name = "idAlunoLabel";
            idAlunoLabel.Size = new System.Drawing.Size(57, 16);
            idAlunoLabel.TabIndex = 3;
            idAlunoLabel.Text = "Aluno ID";
            // 
            // idCoordenacaoLabel
            // 
            idCoordenacaoLabel.AutoSize = true;
            idCoordenacaoLabel.Location = new System.Drawing.Point(13, 162);
            idCoordenacaoLabel.Name = "idCoordenacaoLabel";
            idCoordenacaoLabel.Size = new System.Drawing.Size(106, 16);
            idCoordenacaoLabel.TabIndex = 5;
            idCoordenacaoLabel.Text = "Coordenacao ID";
            // 
            // idProfessorLabel
            // 
            idProfessorLabel.AutoSize = true;
            idProfessorLabel.Location = new System.Drawing.Point(13, 217);
            idProfessorLabel.Name = "idProfessorLabel";
            idProfessorLabel.Size = new System.Drawing.Size(81, 16);
            idProfessorLabel.TabIndex = 7;
            idProfessorLabel.Text = "Professor ID";
            // 
            // motivoLabel
            // 
            motivoLabel.AutoSize = true;
            motivoLabel.Location = new System.Drawing.Point(163, 98);
            motivoLabel.Name = "motivoLabel";
            motivoLabel.Size = new System.Drawing.Size(50, 16);
            motivoLabel.TabIndex = 9;
            motivoLabel.Text = "Motivo:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(165, 162);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(47, 16);
            statusLabel.TabIndex = 11;
            statusLabel.Text = "Status:";
            // 
            // dataHoraSaidaDateTimePicker
            // 
            this.dataHoraSaidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.saidasAntecipadasBindingSource, "DataHoraSaida", true));
            this.dataHoraSaidaDateTimePicker.Location = new System.Drawing.Point(165, 233);
            this.dataHoraSaidaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataHoraSaidaDateTimePicker.Name = "dataHoraSaidaDateTimePicker";
            this.dataHoraSaidaDateTimePicker.Size = new System.Drawing.Size(371, 22);
            this.dataHoraSaidaDateTimePicker.TabIndex = 2;
            // 
            // idAlunoTextBox
            // 
            this.idAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saidasAntecipadasBindingSource, "IdAluno", true));
            this.idAlunoTextBox.Location = new System.Drawing.Point(12, 117);
            this.idAlunoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idAlunoTextBox.Name = "idAlunoTextBox";
            this.idAlunoTextBox.Size = new System.Drawing.Size(107, 22);
            this.idAlunoTextBox.TabIndex = 4;
            this.idAlunoTextBox.TextChanged += new System.EventHandler(this.idAlunoTextBox_TextChanged);
            // 
            // idCoordenacaoTextBox
            // 
            this.idCoordenacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saidasAntecipadasBindingSource, "IdCoordenacao", true));
            this.idCoordenacaoTextBox.Location = new System.Drawing.Point(12, 182);
            this.idCoordenacaoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idCoordenacaoTextBox.Name = "idCoordenacaoTextBox";
            this.idCoordenacaoTextBox.Size = new System.Drawing.Size(107, 22);
            this.idCoordenacaoTextBox.TabIndex = 6;
            // 
            // idProfessorTextBox
            // 
            this.idProfessorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saidasAntecipadasBindingSource, "IdProfessor", true));
            this.idProfessorTextBox.Location = new System.Drawing.Point(12, 233);
            this.idProfessorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idProfessorTextBox.Name = "idProfessorTextBox";
            this.idProfessorTextBox.Size = new System.Drawing.Size(107, 22);
            this.idProfessorTextBox.TabIndex = 8;
            this.idProfessorTextBox.TextChanged += new System.EventHandler(this.idProfessorTextBox_TextChanged);
            // 
            // motivoTextBox
            // 
            this.motivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saidasAntecipadasBindingSource, "Motivo", true));
            this.motivoTextBox.Location = new System.Drawing.Point(165, 117);
            this.motivoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.motivoTextBox.Name = "motivoTextBox";
            this.motivoTextBox.Size = new System.Drawing.Size(623, 22);
            this.motivoTextBox.TabIndex = 10;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saidasAntecipadasBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(165, 182);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(225, 26);
            this.statusTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cadastro de Saídas Antecipadas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(604, 372);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(713, 372);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // saidasAntecipadasBindingSource
            // 
            this.saidasAntecipadasBindingSource.DataSource = typeof(Models.SaidasAntecipadas);
            // 
            // FormCadastroSaidasAntecipadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(motivoLabel);
            this.Controls.Add(this.motivoTextBox);
            this.Controls.Add(idProfessorLabel);
            this.Controls.Add(this.idProfessorTextBox);
            this.Controls.Add(idCoordenacaoLabel);
            this.Controls.Add(this.idCoordenacaoTextBox);
            this.Controls.Add(idAlunoLabel);
            this.Controls.Add(this.idAlunoTextBox);
            this.Controls.Add(dataHoraSaidaLabel);
            this.Controls.Add(this.dataHoraSaidaDateTimePicker);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastroSaidasAntecipadas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Gestão de Saidas Antecipadas";
            this.Load += new System.EventHandler(this.FormCadastroSaidasAntecipadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saidasAntecipadasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource saidasAntecipadasBindingSource;
        private System.Windows.Forms.DateTimePicker dataHoraSaidaDateTimePicker;
        private System.Windows.Forms.TextBox idAlunoTextBox;
        private System.Windows.Forms.TextBox idCoordenacaoTextBox;
        private System.Windows.Forms.TextBox idProfessorTextBox;
        private System.Windows.Forms.TextBox motivoTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}