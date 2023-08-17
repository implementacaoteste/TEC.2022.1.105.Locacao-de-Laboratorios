namespace UILGerenReservasLab
{
    partial class FormCadastroSala
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
            System.Windows.Forms.Label lblNomeSala;
            this.txtNomeSala = new System.Windows.Forms.TextBox();
            this.salaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarSala = new System.Windows.Forms.Button();
            this.btnSalvarSala = new System.Windows.Forms.Button();
            lblNomeSala = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeSala
            // 
            lblNomeSala.AutoSize = true;
            lblNomeSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNomeSala.Location = new System.Drawing.Point(97, 141);
            lblNomeSala.Name = "lblNomeSala";
            lblNomeSala.Size = new System.Drawing.Size(132, 20);
            lblNomeSala.TabIndex = 1;
            lblNomeSala.Text = "Nome do Sala:";
            // 
            // txtNomeSala
            // 
            this.txtNomeSala.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaBindingSource, "Nome", true));
            this.txtNomeSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSala.Location = new System.Drawing.Point(101, 182);
            this.txtNomeSala.Name = "txtNomeSala";
            this.txtNomeSala.Size = new System.Drawing.Size(562, 27);
            this.txtNomeSala.TabIndex = 2;
            // 
            // salaBindingSource
            // 
            this.salaBindingSource.DataSource = typeof(Models.Sala);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastro de Salas";
            // 
            // btnCancelarSala
            // 
            this.btnCancelarSala.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarSala.Image = global::UILGerenReservasLab.Properties.Resources.cancelar;
            this.btnCancelarSala.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarSala.Location = new System.Drawing.Point(612, 374);
            this.btnCancelarSala.Name = "btnCancelarSala";
            this.btnCancelarSala.Size = new System.Drawing.Size(123, 42);
            this.btnCancelarSala.TabIndex = 3;
            this.btnCancelarSala.Text = "&Cancelar";
            this.btnCancelarSala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarSala.UseVisualStyleBackColor = false;
            this.btnCancelarSala.Click += new System.EventHandler(this.btnCancelarSala_Click);
            // 
            // btnSalvarSala
            // 
            this.btnSalvarSala.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarSala.Image = global::UILGerenReservasLab.Properties.Resources.salve_;
            this.btnSalvarSala.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarSala.Location = new System.Drawing.Point(467, 374);
            this.btnSalvarSala.Name = "btnSalvarSala";
            this.btnSalvarSala.Size = new System.Drawing.Size(114, 42);
            this.btnSalvarSala.TabIndex = 3;
            this.btnSalvarSala.Text = "&Salvar";
            this.btnSalvarSala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarSala.UseVisualStyleBackColor = false;
            this.btnSalvarSala.Click += new System.EventHandler(this.btnSalvarSala_Click);
            // 
            // FormCadastroSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarSala);
            this.Controls.Add(this.btnSalvarSala);
            this.Controls.Add(lblNomeSala);
            this.Controls.Add(this.txtNomeSala);
            this.Name = "FormCadastroSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroSala";
            this.Load += new System.EventHandler(this.FormCadastroSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource salaBindingSource;
        private System.Windows.Forms.TextBox txtNomeSala;
        private System.Windows.Forms.Button btnSalvarSala;
        private System.Windows.Forms.Button btnCancelarSala;
        private System.Windows.Forms.Label label1;
    }
}