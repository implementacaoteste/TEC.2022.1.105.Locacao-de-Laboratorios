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
            System.Windows.Forms.Label label2;
            this.textBoxNomeSala = new System.Windows.Forms.TextBox();
            this.salaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelarSala = new System.Windows.Forms.Button();
            this.buttonSalvarSala = new System.Windows.Forms.Button();
            this.textBoxPredio = new System.Windows.Forms.TextBox();
            this.buttonBuscarPredio = new System.Windows.Forms.Button();
            lblNomeSala = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(97, 249);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Predio";
            // 
            // textBoxNomeSala
            // 
            this.textBoxNomeSala.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaBindingSource, "Nome", true));
            this.textBoxNomeSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeSala.Location = new System.Drawing.Point(101, 182);
            this.textBoxNomeSala.Name = "textBoxNomeSala";
            this.textBoxNomeSala.Size = new System.Drawing.Size(562, 27);
            this.textBoxNomeSala.TabIndex = 2;
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
            // buttonCancelarSala
            // 
            this.buttonCancelarSala.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancelarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarSala.Image = global::UILGerenReservasLab.Properties.Resources.cancelar;
            this.buttonCancelarSala.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarSala.Location = new System.Drawing.Point(612, 374);
            this.buttonCancelarSala.Name = "buttonCancelarSala";
            this.buttonCancelarSala.Size = new System.Drawing.Size(123, 42);
            this.buttonCancelarSala.TabIndex = 3;
            this.buttonCancelarSala.Text = "&Cancelar";
            this.buttonCancelarSala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelarSala.UseVisualStyleBackColor = false;
            this.buttonCancelarSala.Click += new System.EventHandler(this.buttonCancelarSala_Click);
            // 
            // buttonSalvarSala
            // 
            this.buttonSalvarSala.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSalvarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarSala.Image = global::UILGerenReservasLab.Properties.Resources.salve_;
            this.buttonSalvarSala.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvarSala.Location = new System.Drawing.Point(467, 374);
            this.buttonSalvarSala.Name = "buttonSalvarSala";
            this.buttonSalvarSala.Size = new System.Drawing.Size(114, 42);
            this.buttonSalvarSala.TabIndex = 3;
            this.buttonSalvarSala.Text = "&Salvar";
            this.buttonSalvarSala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvarSala.UseVisualStyleBackColor = false;
            this.buttonSalvarSala.Click += new System.EventHandler(this.buttonSalvarSala_Click);
            // 
            // textBoxPredio
            // 
            this.textBoxPredio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaBindingSource, "IdPredio", true));
            this.textBoxPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPredio.Location = new System.Drawing.Point(101, 282);
            this.textBoxPredio.Name = "textBoxPredio";
            this.textBoxPredio.Size = new System.Drawing.Size(128, 27);
            this.textBoxPredio.TabIndex = 2;
            // 
            // buttonBuscarPredio
            // 
            this.buttonBuscarPredio.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBuscarPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarPredio.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarPredio.Location = new System.Drawing.Point(236, 280);
            this.buttonBuscarPredio.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscarPredio.Name = "buttonBuscarPredio";
            this.buttonBuscarPredio.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscarPredio.TabIndex = 17;
            this.buttonBuscarPredio.Text = "&Buscar";
            this.buttonBuscarPredio.UseVisualStyleBackColor = false;
            this.buttonBuscarPredio.Click += new System.EventHandler(this.buttonBuscarPredio_Click);
            // 
            // FormCadastroSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 468);
            this.Controls.Add(this.buttonBuscarPredio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelarSala);
            this.Controls.Add(this.buttonSalvarSala);
            this.Controls.Add(label2);
            this.Controls.Add(lblNomeSala);
            this.Controls.Add(this.textBoxPredio);
            this.Controls.Add(this.textBoxNomeSala);
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
        private System.Windows.Forms.TextBox textBoxNomeSala;
        private System.Windows.Forms.Button buttonSalvarSala;
        private System.Windows.Forms.Button buttonCancelarSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPredio;
        private System.Windows.Forms.Button buttonBuscarPredio;
    }
}