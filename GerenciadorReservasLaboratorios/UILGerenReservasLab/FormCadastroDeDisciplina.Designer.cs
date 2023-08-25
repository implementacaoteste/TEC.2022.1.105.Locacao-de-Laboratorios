namespace UILGerenReservasLab
{
    partial class FormCadastroDeDisciplina
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label idCursoLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarDisciplina = new System.Windows.Forms.Button();
            this.btnSalvarDisciplina = new System.Windows.Forms.Button();
            this.disciplinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.idCursoTextBox = new System.Windows.Forms.TextBox();
            this.buttonBuscarIdCurso = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            idCursoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(132, 150);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(47, 16);
            nomeLabel.TabIndex = 9;
            nomeLabel.Text = "Nome:";
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new System.Drawing.Point(120, 220);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(59, 16);
            idCursoLabel.TabIndex = 10;
            idCursoLabel.Text = "Id Curso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cadastro de Disciplina";
            // 
            // btnCancelarDisciplina
            // 
            this.btnCancelarDisciplina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDisciplina.Image = global::UILGerenReservasLab.Properties.Resources.cancelar;
            this.btnCancelarDisciplina.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarDisciplina.Location = new System.Drawing.Point(632, 387);
            this.btnCancelarDisciplina.Name = "btnCancelarDisciplina";
            this.btnCancelarDisciplina.Size = new System.Drawing.Size(123, 42);
            this.btnCancelarDisciplina.TabIndex = 8;
            this.btnCancelarDisciplina.Text = "&Cancelar";
            this.btnCancelarDisciplina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarDisciplina.UseVisualStyleBackColor = false;
            this.btnCancelarDisciplina.Click += new System.EventHandler(this.btnCancelarDisciplina_Click);
            // 
            // btnSalvarDisciplina
            // 
            this.btnSalvarDisciplina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarDisciplina.Image = global::UILGerenReservasLab.Properties.Resources.salve_;
            this.btnSalvarDisciplina.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarDisciplina.Location = new System.Drawing.Point(487, 387);
            this.btnSalvarDisciplina.Name = "btnSalvarDisciplina";
            this.btnSalvarDisciplina.Size = new System.Drawing.Size(114, 42);
            this.btnSalvarDisciplina.TabIndex = 9;
            this.btnSalvarDisciplina.Text = "&Salvar";
            this.btnSalvarDisciplina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarDisciplina.UseVisualStyleBackColor = false;
            this.btnSalvarDisciplina.Click += new System.EventHandler(this.btnSalvarDisciplina_Click);
            // 
            // disciplinaBindingSource
            // 
            this.disciplinaBindingSource.DataSource = typeof(Models.Disciplina);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinaBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(185, 147);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(570, 22);
            this.nomeTextBox.TabIndex = 10;
            // 
            // idCursoTextBox
            // 
            this.idCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinaBindingSource, "IdCurso", true));
            this.idCursoTextBox.Location = new System.Drawing.Point(185, 217);
            this.idCursoTextBox.Name = "idCursoTextBox";
            this.idCursoTextBox.Size = new System.Drawing.Size(97, 22);
            this.idCursoTextBox.TabIndex = 11;
            // 
            // buttonBuscarIdCurso
            // 
            this.buttonBuscarIdCurso.Location = new System.Drawing.Point(306, 220);
            this.buttonBuscarIdCurso.Name = "buttonBuscarIdCurso";
            this.buttonBuscarIdCurso.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarIdCurso.TabIndex = 12;
            this.buttonBuscarIdCurso.Text = "Buscar";
            this.buttonBuscarIdCurso.UseVisualStyleBackColor = true;
            this.buttonBuscarIdCurso.Click += new System.EventHandler(this.buttonBuscarIdCurso_Click);
            // 
            // FormCadastroDeDisciplina
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBuscarIdCurso);
            this.Controls.Add(idCursoLabel);
            this.Controls.Add(this.idCursoTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.btnCancelarDisciplina);
            this.Controls.Add(this.btnSalvarDisciplina);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroDeDisciplina";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarDisciplina;
        private System.Windows.Forms.Button btnSalvarDisciplina;
        private System.Windows.Forms.BindingSource disciplinaBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox idCursoTextBox;
        private System.Windows.Forms.Button buttonBuscarIdCurso;
    }
}