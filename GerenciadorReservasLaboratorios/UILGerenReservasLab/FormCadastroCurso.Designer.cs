﻿namespace UILGerenReservasLab
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
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelarCurso = new System.Windows.Forms.Button();
            this.btnSalvarCurso = new System.Windows.Forms.Button();
            lblNomeCurso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCurso
            // 
            lblNomeCurso.AutoSize = true;
            lblNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNomeCurso.Location = new System.Drawing.Point(65, 139);
            lblNomeCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNomeCurso.Name = "lblNomeCurso";
            lblNomeCurso.Size = new System.Drawing.Size(139, 20);
            lblNomeCurso.TabIndex = 10;
            lblNomeCurso.Text = "Nome do Curso";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cadastro de Curso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(69, 174);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(448, 24);
            this.nomeTextBox.TabIndex = 11;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(Models.Curso);
            // 
            // btnCancelarCurso
            // 
            this.btnCancelarCurso.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCurso.Image = global::UILGerenReservasLab.Properties.Resources.cancelar;
            this.btnCancelarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCurso.Location = new System.Drawing.Point(448, 326);
            this.btnCancelarCurso.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarCurso.Name = "btnCancelarCurso";
            this.btnCancelarCurso.Size = new System.Drawing.Size(116, 40);
            this.btnCancelarCurso.TabIndex = 13;
            this.btnCancelarCurso.Text = "&Cancelar";
            this.btnCancelarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCurso.UseVisualStyleBackColor = false;
            this.btnCancelarCurso.Click += new System.EventHandler(this.btnCancelarCurso_Click);
            // 
            // btnSalvarCurso
            // 
            this.btnSalvarCurso.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalvarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCurso.Image = global::UILGerenReservasLab.Properties.Resources.salve_;
            this.btnSalvarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarCurso.Location = new System.Drawing.Point(305, 326);
            this.btnSalvarCurso.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarCurso.Name = "btnSalvarCurso";
            this.btnSalvarCurso.Size = new System.Drawing.Size(109, 40);
            this.btnSalvarCurso.TabIndex = 12;
            this.btnSalvarCurso.Text = "&Salvar";
            this.btnSalvarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCurso.UseVisualStyleBackColor = false;
            this.btnSalvarCurso.Click += new System.EventHandler(this.btnSalvarCurso_Click);
            // 
            // FormCadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(612, 416);
            this.Controls.Add(this.btnCancelarCurso);
            this.Controls.Add(this.btnSalvarCurso);
            this.Controls.Add(lblNomeCurso);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCadastroCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroCurso";
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button btnSalvarCurso;
        private System.Windows.Forms.Button btnCancelarCurso;
    }
}