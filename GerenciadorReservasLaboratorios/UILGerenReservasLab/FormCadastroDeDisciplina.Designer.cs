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
            this.buttonFechar = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            idCursoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(62, 140);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 9;
            nomeLabel.Text = "Nome:";
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new System.Drawing.Point(52, 197);
            idCursoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(49, 13);
            idCursoLabel.TabIndex = 10;
            idCursoLabel.Text = "Id Curso:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 63);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cadastro de Disciplina";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelarDisciplina
            // 
            this.btnCancelarDisciplina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDisciplina.Image = global::UILGerenReservasLab.Properties.Resources.cancelar;
            this.btnCancelarDisciplina.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarDisciplina.Location = new System.Drawing.Point(474, 314);
            this.btnCancelarDisciplina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarDisciplina.Name = "btnCancelarDisciplina";
            this.btnCancelarDisciplina.Size = new System.Drawing.Size(92, 34);
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
            this.btnSalvarDisciplina.Location = new System.Drawing.Point(365, 314);
            this.btnSalvarDisciplina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvarDisciplina.Name = "btnSalvarDisciplina";
            this.btnSalvarDisciplina.Size = new System.Drawing.Size(86, 34);
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
            this.nomeTextBox.Location = new System.Drawing.Point(101, 137);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(428, 20);
            this.nomeTextBox.TabIndex = 10;
            // 
            // idCursoTextBox
            // 
            this.idCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinaBindingSource, "IdCurso", true));
            this.idCursoTextBox.Location = new System.Drawing.Point(101, 194);
            this.idCursoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idCursoTextBox.Name = "idCursoTextBox";
            this.idCursoTextBox.Size = new System.Drawing.Size(74, 20);
            this.idCursoTextBox.TabIndex = 11;
            // 
            // buttonBuscarIdCurso
            // 
            this.buttonBuscarIdCurso.Location = new System.Drawing.Point(192, 197);
            this.buttonBuscarIdCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarIdCurso.Name = "buttonBuscarIdCurso";
            this.buttonBuscarIdCurso.Size = new System.Drawing.Size(56, 19);
            this.buttonBuscarIdCurso.TabIndex = 12;
            this.buttonBuscarIdCurso.Text = "Buscar";
            this.buttonBuscarIdCurso.UseVisualStyleBackColor = true;
            this.buttonBuscarIdCurso.Click += new System.EventHandler(this.buttonBuscarIdCurso_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFechar.BackColor = System.Drawing.Color.Red;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.ForeColor = System.Drawing.Color.White;
            this.buttonFechar.Location = new System.Drawing.Point(328, 66);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 29;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormCadastroDeDisciplina
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(750, 528);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonBuscarIdCurso);
            this.Controls.Add(idCursoLabel);
            this.Controls.Add(this.idCursoTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.btnCancelarDisciplina);
            this.Controls.Add(this.btnSalvarDisciplina);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroDeDisciplina";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormCadastroDisciplina_Load);
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
        private System.Windows.Forms.Button buttonFechar;
    }
}