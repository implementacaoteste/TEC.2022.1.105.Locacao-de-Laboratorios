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
            this.capacidadeLabel = new System.Windows.Forms.Label();
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.textBoxNomeSala = new System.Windows.Forms.TextBox();
            this.salaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelarSala = new System.Windows.Forms.Button();
            this.buttonSalvarSala = new System.Windows.Forms.Button();
            this.textBoxPredio = new System.Windows.Forms.TextBox();
            this.buttonBuscarPredio = new System.Windows.Forms.Button();
            this.capacidadeTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            lblNomeSala = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeSala
            // 
            lblNomeSala.AutoSize = true;
            lblNomeSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNomeSala.Location = new System.Drawing.Point(73, 68);
            lblNomeSala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNomeSala.Name = "lblNomeSala";
            lblNomeSala.Size = new System.Drawing.Size(86, 15);
            lblNomeSala.TabIndex = 1;
            lblNomeSala.Text = "Nome do Sala";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(73, 158);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Predio";
            // 
            // capacidadeLabel
            // 
            this.capacidadeLabel.AutoSize = true;
            this.capacidadeLabel.Location = new System.Drawing.Point(405, 247);
            this.capacidadeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.capacidadeLabel.Name = "capacidadeLabel";
            this.capacidadeLabel.Size = new System.Drawing.Size(64, 13);
            this.capacidadeLabel.TabIndex = 17;
            this.capacidadeLabel.Text = "Capacidade";
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.AutoSize = true;
            this.descricaoLabel.Location = new System.Drawing.Point(79, 247);
            this.descricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(55, 13);
            this.descricaoLabel.TabIndex = 18;
            this.descricaoLabel.Text = "Descricao";
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Location = new System.Drawing.Point(300, 247);
            this.estadoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(40, 13);
            this.estadoLabel.TabIndex = 19;
            this.estadoLabel.Text = "Estado";
            this.estadoLabel.Click += new System.EventHandler(this.estadoLabel_Click);
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Location = new System.Drawing.Point(374, 161);
            this.tipoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(28, 13);
            this.tipoLabel.TabIndex = 20;
            this.tipoLabel.Text = "Tipo";
            this.tipoLabel.Click += new System.EventHandler(this.tipoLabel_Click);
            // 
            // textBoxNomeSala
            // 
            this.textBoxNomeSala.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaBindingSource, "Nome", true));
            this.textBoxNomeSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeSala.Location = new System.Drawing.Point(76, 87);
            this.textBoxNomeSala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNomeSala.Name = "textBoxNomeSala";
            this.textBoxNomeSala.Size = new System.Drawing.Size(422, 23);
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
            this.label1.Location = new System.Drawing.Point(172, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastro de Salas";
            // 
            // buttonCancelarSala
            // 
            this.buttonCancelarSala.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCancelarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarSala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancelarSala.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarSala.Location = new System.Drawing.Point(566, 304);
            this.buttonCancelarSala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelarSala.Name = "buttonCancelarSala";
            this.buttonCancelarSala.Size = new System.Drawing.Size(92, 34);
            this.buttonCancelarSala.TabIndex = 3;
            this.buttonCancelarSala.Text = "&Cancelar";
            this.buttonCancelarSala.UseVisualStyleBackColor = false;
            this.buttonCancelarSala.Click += new System.EventHandler(this.buttonCancelarSala_Click);
            // 
            // buttonSalvarSala
            // 
            this.buttonSalvarSala.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSalvarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarSala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSalvarSala.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvarSala.Location = new System.Drawing.Point(437, 304);
            this.buttonSalvarSala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalvarSala.Name = "buttonSalvarSala";
            this.buttonSalvarSala.Size = new System.Drawing.Size(90, 34);
            this.buttonSalvarSala.TabIndex = 3;
            this.buttonSalvarSala.Text = "&Salvar";
            this.buttonSalvarSala.UseVisualStyleBackColor = false;
            this.buttonSalvarSala.Click += new System.EventHandler(this.buttonSalvarSala_Click);
            // 
            // textBoxPredio
            // 
            this.textBoxPredio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaBindingSource, "IdPredio", true));
            this.textBoxPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPredio.Location = new System.Drawing.Point(76, 176);
            this.textBoxPredio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPredio.Name = "textBoxPredio";
            this.textBoxPredio.Size = new System.Drawing.Size(220, 23);
            this.textBoxPredio.TabIndex = 2;
            // 
            // buttonBuscarPredio
            // 
            this.buttonBuscarPredio.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBuscarPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarPredio.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarPredio.Location = new System.Drawing.Point(300, 174);
            this.buttonBuscarPredio.Name = "buttonBuscarPredio";
            this.buttonBuscarPredio.Size = new System.Drawing.Size(70, 24);
            this.buttonBuscarPredio.TabIndex = 17;
            this.buttonBuscarPredio.Text = "&Buscar";
            this.buttonBuscarPredio.UseVisualStyleBackColor = false;
            this.buttonBuscarPredio.Click += new System.EventHandler(this.buttonBuscarPredio_Click);
            // 
            // capacidadeTextBox
            // 
            this.capacidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaBindingSource, "Capacidade", true));
            this.capacidadeTextBox.Location = new System.Drawing.Point(407, 262);
            this.capacidadeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.capacidadeTextBox.Name = "capacidadeTextBox";
            this.capacidadeTextBox.Size = new System.Drawing.Size(91, 20);
            this.capacidadeTextBox.TabIndex = 18;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(75, 262);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(222, 20);
            this.descricaoTextBox.TabIndex = 19;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(300, 262);
            this.estadoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(104, 20);
            this.estadoTextBox.TabIndex = 20;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(376, 176);
            this.tipoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(122, 20);
            this.tipoTextBox.TabIndex = 21;
            // 
            // FormCadastroSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(766, 380);
            this.Controls.Add(this.tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(this.estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.capacidadeLabel);
            this.Controls.Add(this.capacidadeTextBox);
            this.Controls.Add(this.buttonBuscarPredio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelarSala);
            this.Controls.Add(this.buttonSalvarSala);
            this.Controls.Add(label2);
            this.Controls.Add(lblNomeSala);
            this.Controls.Add(this.textBoxPredio);
            this.Controls.Add(this.textBoxNomeSala);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCadastroSala";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Salas";
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
        private System.Windows.Forms.TextBox capacidadeTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.Label capacidadeLabel;
        private System.Windows.Forms.Label descricaoLabel;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.Label tipoLabel;
    }
}