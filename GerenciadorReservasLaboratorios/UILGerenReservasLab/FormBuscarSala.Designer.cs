﻿namespace UILGerenReservasLab
{
    partial class FormBuscarSala
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
            System.Windows.Forms.Label lblBuscarPor;
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.comboBoxBuscarSalaPor = new System.Windows.Forms.ComboBox();
            this.salaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSelecionarSala = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.txtBuscarSala = new System.Windows.Forms.TextBox();
            lblBuscarPor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarPor
            // 
            lblBuscarPor.AutoSize = true;
            lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBuscarPor.ForeColor = System.Drawing.Color.White;
            lblBuscarPor.Location = new System.Drawing.Point(45, 66);
            lblBuscarPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBuscarPor.Name = "lblBuscarPor";
            lblBuscarPor.Size = new System.Drawing.Size(66, 15);
            lblBuscarPor.TabIndex = 9;
            lblBuscarPor.Text = "Buscar por";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(272, 128);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 19);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(345, 128);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(56, 19);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(418, 128);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(56, 19);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(490, 128);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(56, 19);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // comboBoxBuscarSalaPor
            // 
            this.comboBoxBuscarSalaPor.FormattingEnabled = true;
            this.comboBoxBuscarSalaPor.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "Todos"});
            this.comboBoxBuscarSalaPor.Location = new System.Drawing.Point(47, 89);
            this.comboBoxBuscarSalaPor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBuscarSalaPor.Name = "comboBoxBuscarSalaPor";
            this.comboBoxBuscarSalaPor.Size = new System.Drawing.Size(115, 21);
            this.comboBoxBuscarSalaPor.TabIndex = 5;
            // 
            // salaDataGridView
            // 
            this.salaDataGridView.AllowUserToAddRows = false;
            this.salaDataGridView.AllowUserToDeleteRows = false;
            this.salaDataGridView.AllowUserToOrderColumns = true;
            this.salaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salaDataGridView.AutoGenerateColumns = false;
            this.salaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salaDataGridView.ColumnHeadersHeight = 30;
            this.salaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.salaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.NomePredio});
            this.salaDataGridView.DataSource = this.salaBindingSource;
            this.salaDataGridView.Location = new System.Drawing.Point(47, 114);
            this.salaDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.salaDataGridView.Name = "salaDataGridView";
            this.salaDataGridView.ReadOnly = true;
            this.salaDataGridView.RowHeadersVisible = false;
            this.salaDataGridView.RowHeadersWidth = 51;
            this.salaDataGridView.RowTemplate.Height = 24;
            this.salaDataGridView.Size = new System.Drawing.Size(718, 327);
            this.salaDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 53.47594F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.FillWeight = 146.5241F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // NomePredio
            // 
            this.NomePredio.DataPropertyName = "NomePredio";
            this.NomePredio.HeaderText = "Predio";
            this.NomePredio.MinimumWidth = 6;
            this.NomePredio.Name = "NomePredio";
            this.NomePredio.ReadOnly = true;
            // 
            // salaBindingSource
            // 
            this.salaBindingSource.DataSource = typeof(Models.Sala);
            // 
            // buttonSelecionarSala
            // 
            this.buttonSelecionarSala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionarSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonSelecionarSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarSala.ForeColor = System.Drawing.Color.White;
            this.buttonSelecionarSala.Location = new System.Drawing.Point(769, 399);
            this.buttonSelecionarSala.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionarSala.Name = "buttonSelecionarSala";
            this.buttonSelecionarSala.Size = new System.Drawing.Size(177, 42);
            this.buttonSelecionarSala.TabIndex = 41;
            this.buttonSelecionarSala.Text = "&Selecionar";
            this.buttonSelecionarSala.UseVisualStyleBackColor = false;
            this.buttonSelecionarSala.Click += new System.EventHandler(this.buttonSelecionarSala_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserir.ForeColor = System.Drawing.Color.White;
            this.buttonInserir.Location = new System.Drawing.Point(769, 209);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(177, 42);
            this.buttonInserir.TabIndex = 37;
            this.buttonInserir.Text = "&Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluir.BackColor = System.Drawing.Color.Red;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.ForeColor = System.Drawing.Color.White;
            this.buttonExcluir.Location = new System.Drawing.Point(769, 324);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(177, 42);
            this.buttonExcluir.TabIndex = 38;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.ForeColor = System.Drawing.Color.White;
            this.buttonAlterar.Location = new System.Drawing.Point(769, 150);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(177, 42);
            this.buttonAlterar.TabIndex = 39;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBuscar.Location = new System.Drawing.Point(769, 89);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(177, 42);
            this.buttonBuscar.TabIndex = 40;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFechar.BackColor = System.Drawing.Color.Red;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFechar.Location = new System.Drawing.Point(954, 10);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 42;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // txtBuscarSala
            // 
            this.txtBuscarSala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarSala.Location = new System.Drawing.Point(168, 89);
            this.txtBuscarSala.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarSala.Name = "txtBuscarSala";
            this.txtBuscarSala.Size = new System.Drawing.Size(597, 20);
            this.txtBuscarSala.TabIndex = 43;
            // 
            // FormBuscarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1040, 491);
            this.Controls.Add(this.txtBuscarSala);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonSelecionarSala);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(lblBuscarPor);
            this.Controls.Add(this.salaDataGridView);
            this.Controls.Add(this.comboBoxBuscarSalaPor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBuscarSala";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Pesquisa de Salas";
            this.Load += new System.EventHandler(this.FormBuscarSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox comboBoxBuscarSalaPor;
        private System.Windows.Forms.BindingSource salaBindingSource;
        private System.Windows.Forms.DataGridView salaDataGridView;
        private System.Windows.Forms.Button buttonSelecionarSala;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.TextBox txtBuscarSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePredio;
    }
}