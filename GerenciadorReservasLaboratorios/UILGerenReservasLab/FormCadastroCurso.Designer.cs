namespace UILGerenReservasLab
{
    partial class FormCadastroCurso
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
            System.Windows.Forms.Label lblNomeCurso;
            System.Windows.Forms.Label turnoLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancelarCurso = new System.Windows.Forms.Button();
            this.buttonSalvarCurso = new System.Windows.Forms.Button();
            this.turnoTextBox = new System.Windows.Forms.TextBox();
            lblNomeCurso = new System.Windows.Forms.Label();
            turnoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCurso
            // 
            lblNomeCurso.AutoSize = true;
            lblNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNomeCurso.Location = new System.Drawing.Point(66, 125);
            lblNomeCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNomeCurso.Name = "lblNomeCurso";
            lblNomeCurso.Size = new System.Drawing.Size(115, 18);
            lblNomeCurso.TabIndex = 10;
            lblNomeCurso.Text = "Nome do Curso";
            // 
            // turnoLabel
            // 
            turnoLabel.AutoSize = true;
            turnoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            turnoLabel.Location = new System.Drawing.Point(65, 205);
            turnoLabel.Name = "turnoLabel";
            turnoLabel.Size = new System.Drawing.Size(47, 18);
            turnoLabel.TabIndex = 13;
            turnoLabel.Text = "Turno";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(961, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cadastro de Curso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(69, 145);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(448, 24);
            this.nomeTextBox.TabIndex = 11;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(Models.Curso);
            // 
            // buttonCancelarCurso
            // 
            this.buttonCancelarCurso.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCancelarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancelarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarCurso.Location = new System.Drawing.Point(789, 337);
            this.buttonCancelarCurso.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelarCurso.Name = "buttonCancelarCurso";
            this.buttonCancelarCurso.Size = new System.Drawing.Size(116, 40);
            this.buttonCancelarCurso.TabIndex = 13;
            this.buttonCancelarCurso.Text = "&Cancelar";
            this.buttonCancelarCurso.UseVisualStyleBackColor = false;
            this.buttonCancelarCurso.Click += new System.EventHandler(this.buttonCancelarCurso_Click);
            // 
            // buttonSalvarCurso
            // 
            this.buttonSalvarCurso.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSalvarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSalvarCurso.Location = new System.Drawing.Point(625, 337);
            this.buttonSalvarCurso.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvarCurso.Name = "buttonSalvarCurso";
            this.buttonSalvarCurso.Size = new System.Drawing.Size(109, 40);
            this.buttonSalvarCurso.TabIndex = 12;
            this.buttonSalvarCurso.Text = "&Salvar";
            this.buttonSalvarCurso.UseVisualStyleBackColor = false;
            this.buttonSalvarCurso.Click += new System.EventHandler(this.buttonSalvarCurso_Click);
            // 
            // turnoTextBox
            // 
            this.turnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Turno", true));
            this.turnoTextBox.Location = new System.Drawing.Point(69, 226);
            this.turnoTextBox.Name = "turnoTextBox";
            this.turnoTextBox.Size = new System.Drawing.Size(448, 22);
            this.turnoTextBox.TabIndex = 14;
            // 
            // FormCadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(961, 416);
            this.Controls.Add(turnoLabel);
            this.Controls.Add(this.turnoTextBox);
            this.Controls.Add(this.buttonCancelarCurso);
            this.Controls.Add(this.buttonSalvarCurso);
            this.Controls.Add(lblNomeCurso);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCadastroCurso";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button buttonSalvarCurso;
        private System.Windows.Forms.Button buttonCancelarCurso;
        private System.Windows.Forms.TextBox turnoTextBox;
    }
}