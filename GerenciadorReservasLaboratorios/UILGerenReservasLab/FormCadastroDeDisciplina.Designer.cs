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
            System.Windows.Forms.Label NomeDisciplina;
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarDisciplina = new System.Windows.Forms.Button();
            this.btnSalvarDisciplina = new System.Windows.Forms.Button();
            this.disciplinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNomeDisciplina = new System.Windows.Forms.TextBox();
            NomeDisciplina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // NomeDisciplina
            // 
            NomeDisciplina.AutoSize = true;
            NomeDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NomeDisciplina.Location = new System.Drawing.Point(18, 153);
            NomeDisciplina.Name = "NomeDisciplina";
            NomeDisciplina.Size = new System.Drawing.Size(177, 20);
            NomeDisciplina.TabIndex = 10;
            NomeDisciplina.Text = "Nome Da Disciplina";
            // 
            // txtNomeDisciplina
            // 
            this.txtNomeDisciplina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinaBindingSource, "Nome", true));
            this.txtNomeDisciplina.Location = new System.Drawing.Point(21, 185);
            this.txtNomeDisciplina.Name = "txtNomeDisciplina";
            this.txtNomeDisciplina.Size = new System.Drawing.Size(479, 22);
            this.txtNomeDisciplina.TabIndex = 11;
            // 
            // FormCadastroDeDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(NomeDisciplina);
            this.Controls.Add(this.txtNomeDisciplina);
            this.Controls.Add(this.btnCancelarDisciplina);
            this.Controls.Add(this.btnSalvarDisciplina);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroDeDisciplina";
            this.Text = "FormCadastroDeDisciplina";
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarDisciplina;
        private System.Windows.Forms.Button btnSalvarDisciplina;
        private System.Windows.Forms.BindingSource disciplinaBindingSource;
        private System.Windows.Forms.TextBox txtNomeDisciplina;
    }
}