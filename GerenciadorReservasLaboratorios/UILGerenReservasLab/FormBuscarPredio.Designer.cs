namespace UILGerenReservasLab
{
    partial class FormBuscarPredio
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
            this.txtBuscarPredio = new System.Windows.Forms.TextBox();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.predioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonSelecionarPredio = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            lblBuscarPor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.predioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarPor
            // 
            lblBuscarPor.AutoSize = true;
            lblBuscarPor.Location = new System.Drawing.Point(56, 93);
            lblBuscarPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBuscarPor.Name = "lblBuscarPor";
            lblBuscarPor.Size = new System.Drawing.Size(76, 16);
            lblBuscarPor.TabIndex = 17;
            lblBuscarPor.Text = "Buscar Por:";
            // 
            // txtBuscarPredio
            // 
            this.txtBuscarPredio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPredio.Location = new System.Drawing.Point(210, 111);
            this.txtBuscarPredio.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarPredio.Name = "txtBuscarPredio";
            this.txtBuscarPredio.Size = new System.Drawing.Size(745, 24);
            this.txtBuscarPredio.TabIndex = 18;
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(61, 111);
            this.comboBoxBuscarPor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(143, 24);
            this.comboBoxBuscarPor.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1300, 52);
            this.label1.TabIndex = 15;
            this.label1.Text = "Formulário de Pesquisa de Predios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // predioDataGridView
            // 
            this.predioDataGridView.AllowUserToAddRows = false;
            this.predioDataGridView.AllowUserToDeleteRows = false;
            this.predioDataGridView.AllowUserToOrderColumns = true;
            this.predioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.predioDataGridView.AutoGenerateColumns = false;
            this.predioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.predioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.predioDataGridView.DataSource = this.predioBindingSource;
            this.predioDataGridView.Location = new System.Drawing.Point(59, 143);
            this.predioDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.predioDataGridView.Name = "predioDataGridView";
            this.predioDataGridView.ReadOnly = true;
            this.predioDataGridView.RowHeadersVisible = false;
            this.predioDataGridView.RowHeadersWidth = 51;
            this.predioDataGridView.Size = new System.Drawing.Size(898, 409);
            this.predioDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // predioBindingSource
            // 
            this.predioBindingSource.DataSource = typeof(Models.Predio);
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.Red;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFechar.Location = new System.Drawing.Point(586, 74);
            this.buttonFechar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(94, 29);
            this.buttonFechar.TabIndex = 20;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonSelecionarPredio
            // 
            this.buttonSelecionarPredio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionarPredio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonSelecionarPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarPredio.ForeColor = System.Drawing.Color.White;
            this.buttonSelecionarPredio.Location = new System.Drawing.Point(961, 500);
            this.buttonSelecionarPredio.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionarPredio.Name = "buttonSelecionarPredio";
            this.buttonSelecionarPredio.Size = new System.Drawing.Size(221, 52);
            this.buttonSelecionarPredio.TabIndex = 36;
            this.buttonSelecionarPredio.Text = "&Selecionar";
            this.buttonSelecionarPredio.UseVisualStyleBackColor = false;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserir.ForeColor = System.Drawing.Color.White;
            this.buttonInserir.Location = new System.Drawing.Point(961, 262);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(221, 52);
            this.buttonInserir.TabIndex = 32;
            this.buttonInserir.Text = "&Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluir.BackColor = System.Drawing.Color.Tomato;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.ForeColor = System.Drawing.Color.White;
            this.buttonExcluir.Location = new System.Drawing.Point(961, 406);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(221, 52);
            this.buttonExcluir.TabIndex = 33;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.ForeColor = System.Drawing.Color.White;
            this.buttonAlterar.Location = new System.Drawing.Point(961, 188);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(221, 52);
            this.buttonAlterar.TabIndex = 34;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBuscar.Location = new System.Drawing.Point(961, 112);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(221, 52);
            this.buttonBuscar.TabIndex = 35;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // FormBuscarPredio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1300, 614);
            this.Controls.Add(this.buttonSelecionarPredio);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.predioDataGridView);
            this.Controls.Add(lblBuscarPor);
            this.Controls.Add(this.txtBuscarPredio);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBuscarPredio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscarPredio";
            ((System.ComponentModel.ISupportInitialize)(this.predioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarPredio;
        private System.Windows.Forms.ComboBox comboBoxBuscarPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource predioBindingSource;
        private System.Windows.Forms.DataGridView predioDataGridView;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonSelecionarPredio;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}