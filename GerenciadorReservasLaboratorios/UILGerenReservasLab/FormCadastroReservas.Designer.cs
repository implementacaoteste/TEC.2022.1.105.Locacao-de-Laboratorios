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
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCursoTextBox = new System.Windows.Forms.TextBox();
            this.idDisciplinaTextBox = new System.Windows.Forms.TextBox();
            this.idSalaTextBox = new System.Windows.Forms.TextBox();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            idCursoLabel = new System.Windows.Forms.Label();
            idDisciplinaLabel = new System.Windows.Forms.Label();
            idSalaLabel = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new System.Drawing.Point(47, 56);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(59, 16);
            idCursoLabel.TabIndex = 1;
            idCursoLabel.Text = "Id Curso:";
            // 
            // idCursoTextBox
            // 
            this.idCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdCurso", true));
            this.idCursoTextBox.Location = new System.Drawing.Point(112, 53);
            this.idCursoTextBox.Name = "idCursoTextBox";
            this.idCursoTextBox.Size = new System.Drawing.Size(100, 22);
            this.idCursoTextBox.TabIndex = 2;
            // 
            // idDisciplinaLabel
            // 
            idDisciplinaLabel.AutoSize = true;
            idDisciplinaLabel.Location = new System.Drawing.Point(23, 104);
            idDisciplinaLabel.Name = "idDisciplinaLabel";
            idDisciplinaLabel.Size = new System.Drawing.Size(83, 16);
            idDisciplinaLabel.TabIndex = 3;
            idDisciplinaLabel.Text = "Id Disciplina:";
            // 
            // idDisciplinaTextBox
            // 
            this.idDisciplinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdDisciplina", true));
            this.idDisciplinaTextBox.Location = new System.Drawing.Point(112, 101);
            this.idDisciplinaTextBox.Name = "idDisciplinaTextBox";
            this.idDisciplinaTextBox.Size = new System.Drawing.Size(100, 22);
            this.idDisciplinaTextBox.TabIndex = 4;
            // 
            // idSalaLabel
            // 
            idSalaLabel.AutoSize = true;
            idSalaLabel.Location = new System.Drawing.Point(54, 158);
            idSalaLabel.Name = "idSalaLabel";
            idSalaLabel.Size = new System.Drawing.Size(52, 16);
            idSalaLabel.TabIndex = 5;
            idSalaLabel.Text = "Id Sala:";
            // 
            // idSalaTextBox
            // 
            this.idSalaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdSala", true));
            this.idSalaTextBox.Location = new System.Drawing.Point(112, 155);
            this.idSalaTextBox.Name = "idSalaTextBox";
            this.idSalaTextBox.Size = new System.Drawing.Size(100, 22);
            this.idSalaTextBox.TabIndex = 6;
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(307, 65);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(71, 16);
            idUsuarioLabel.TabIndex = 6;
            idUsuarioLabel.Text = "Id Usuario:";
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox.Location = new System.Drawing.Point(384, 62);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(100, 22);
            this.idUsuarioTextBox.TabIndex = 7;
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Location = new System.Drawing.Point(130, 275);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(92, 16);
            observacoesLabel.TabIndex = 8;
            observacoesLabel.Text = "Observacoes:";
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Observacoes", true));
            this.observacoesTextBox.Location = new System.Drawing.Point(228, 272);
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(698, 22);
            this.observacoesTextBox.TabIndex = 9;
            // 
            // FormCadastroReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 569);
            this.Controls.Add(observacoesLabel);
            this.Controls.Add(this.observacoesTextBox);
            this.Controls.Add(idUsuarioLabel);
            this.Controls.Add(this.idUsuarioTextBox);
            this.Controls.Add(idSalaLabel);
            this.Controls.Add(this.idSalaTextBox);
            this.Controls.Add(idDisciplinaLabel);
            this.Controls.Add(this.idDisciplinaTextBox);
            this.Controls.Add(idCursoLabel);
            this.Controls.Add(this.idCursoTextBox);
            this.Name = "FormCadastroReservas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.TextBox idCursoTextBox;
        private System.Windows.Forms.TextBox idDisciplinaTextBox;
        private System.Windows.Forms.TextBox idSalaTextBox;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.TextBox observacoesTextBox;
    }
}