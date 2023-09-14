﻿using Models;

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
            this.alunoTextBox = new System.Windows.Forms.TextBox();
            this.motivoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBuscarAluno = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.coordenacaotextBox = new System.Windows.Forms.TextBox();
            this.comboBoxProfessor = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            dataHoraSaidaLabel = new System.Windows.Forms.Label();
            idAlunoLabel = new System.Windows.Forms.Label();
            idCoordenacaoLabel = new System.Windows.Forms.Label();
            idProfessorLabel = new System.Windows.Forms.Label();
            motivoLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.saidasAntecipadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHoraSaidaLabel
            // 
            dataHoraSaidaLabel.AutoSize = true;
            dataHoraSaidaLabel.Location = new System.Drawing.Point(859, 174);
            dataHoraSaidaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataHoraSaidaLabel.Name = "dataHoraSaidaLabel";
            dataHoraSaidaLabel.Size = new System.Drawing.Size(173, 16);
            dataHoraSaidaLabel.TabIndex = 1;
            dataHoraSaidaLabel.Text = "Data e Hora da Autorização";
            // 
            // idAlunoLabel
            // 
            idAlunoLabel.AutoSize = true;
            idAlunoLabel.Location = new System.Drawing.Point(12, 98);
            idAlunoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idAlunoLabel.Name = "idAlunoLabel";
            idAlunoLabel.Size = new System.Drawing.Size(41, 16);
            idAlunoLabel.TabIndex = 3;
            idAlunoLabel.Text = "Aluno";
            // 
            // idCoordenacaoLabel
            // 
            idCoordenacaoLabel.AutoSize = true;
            idCoordenacaoLabel.Location = new System.Drawing.Point(429, 170);
            idCoordenacaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idCoordenacaoLabel.Name = "idCoordenacaoLabel";
            idCoordenacaoLabel.Size = new System.Drawing.Size(90, 16);
            idCoordenacaoLabel.TabIndex = 5;
            idCoordenacaoLabel.Text = "Coordenacao";
            // 
            // idProfessorLabel
            // 
            idProfessorLabel.AutoSize = true;
            idProfessorLabel.Location = new System.Drawing.Point(429, 101);
            idProfessorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idProfessorLabel.Name = "idProfessorLabel";
            idProfessorLabel.Size = new System.Drawing.Size(65, 16);
            idProfessorLabel.TabIndex = 7;
            idProfessorLabel.Text = "Professor";
            // 
            // motivoLabel
            // 
            motivoLabel.AutoSize = true;
            motivoLabel.Location = new System.Drawing.Point(14, 238);
            motivoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            motivoLabel.Name = "motivoLabel";
            motivoLabel.Size = new System.Drawing.Size(50, 16);
            motivoLabel.TabIndex = 9;
            motivoLabel.Text = "Motivo:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(11, 166);
            statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(47, 16);
            statusLabel.TabIndex = 11;
            statusLabel.Text = "Status:";
            // 
            // dataHoraSaidaDateTimePicker
            // 
            this.dataHoraSaidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.saidasAntecipadasBindingSource, "DataHoraSaida", true));
            this.dataHoraSaidaDateTimePicker.Location = new System.Drawing.Point(859, 190);
            this.dataHoraSaidaDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dataHoraSaidaDateTimePicker.Name = "dataHoraSaidaDateTimePicker";
            this.dataHoraSaidaDateTimePicker.Size = new System.Drawing.Size(348, 22);
            this.dataHoraSaidaDateTimePicker.TabIndex = 2;
            // 
            // saidasAntecipadasBindingSource
            // 
            this.saidasAntecipadasBindingSource.DataSource = typeof(Models.SaidasAntecipadas);
            // 
            // alunoTextBox
            // 
            this.alunoTextBox.Location = new System.Drawing.Point(11, 119);
            this.alunoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.alunoTextBox.Name = "alunoTextBox";
            this.alunoTextBox.Size = new System.Drawing.Size(405, 22);
            this.alunoTextBox.TabIndex = 4;
            // 
            // motivoTextBox
            // 
            this.motivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saidasAntecipadasBindingSource, "Motivo", true));
            this.motivoTextBox.Location = new System.Drawing.Point(11, 256);
            this.motivoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.motivoTextBox.Name = "motivoTextBox";
            this.motivoTextBox.Size = new System.Drawing.Size(1196, 22);
            this.motivoTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1300, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cadastro de Saídas Antecipadas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSalvar.Location = new System.Drawing.Point(796, 486);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(146, 52);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelar.Location = new System.Drawing.Point(980, 486);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(146, 52);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonBuscarAluno
            // 
            this.buttonBuscarAluno.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBuscarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarAluno.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarAluno.Location = new System.Drawing.Point(322, 84);
            this.buttonBuscarAluno.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscarAluno.Name = "buttonBuscarAluno";
            this.buttonBuscarAluno.Size = new System.Drawing.Size(94, 29);
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
            this.comboBoxStatus.Location = new System.Drawing.Point(11, 186);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(283, 24);
            this.comboBoxStatus.TabIndex = 18;
            // 
            // coordenacaotextBox
            // 
            this.coordenacaotextBox.Location = new System.Drawing.Point(432, 190);
            this.coordenacaotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.coordenacaotextBox.Name = "coordenacaotextBox";
            this.coordenacaotextBox.Size = new System.Drawing.Size(405, 22);
            this.coordenacaotextBox.TabIndex = 19;
            // 
            // comboBoxProfessor
            // 
            this.comboBoxProfessor.FormattingEnabled = true;
            this.comboBoxProfessor.Location = new System.Drawing.Point(432, 119);
            this.comboBoxProfessor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProfessor.Name = "comboBoxProfessor";
            this.comboBoxProfessor.Size = new System.Drawing.Size(405, 24);
            this.comboBoxProfessor.TabIndex = 20;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.saidasAntecipadasBindingSource;
            // 
            // FormCadastroSaidasAntecipadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1300, 614);
            this.Controls.Add(this.comboBoxProfessor);
            this.Controls.Add(this.coordenacaotextBox);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonBuscarAluno);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(statusLabel);
            this.Controls.Add(motivoLabel);
            this.Controls.Add(this.motivoTextBox);
            this.Controls.Add(idProfessorLabel);
            this.Controls.Add(idCoordenacaoLabel);
            this.Controls.Add(idAlunoLabel);
            this.Controls.Add(this.alunoTextBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource saidasAntecipadasBindingSource;
        private System.Windows.Forms.DateTimePicker dataHoraSaidaDateTimePicker;
        private System.Windows.Forms.TextBox alunoTextBox;
        private System.Windows.Forms.TextBox motivoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBuscarAluno;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox coordenacaotextBox;
        private System.Windows.Forms.ComboBox comboBoxProfessor;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}