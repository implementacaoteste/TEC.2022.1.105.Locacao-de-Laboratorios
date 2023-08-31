namespace UILGerenReservasLab
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.salaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBuscarSala = new System.Windows.Forms.TextBox();
            this.buttonSelecionarPredio = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            lblBuscarPor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarPor
            // 
            lblBuscarPor.AutoSize = true;
            lblBuscarPor.Location = new System.Drawing.Point(56, 93);
            lblBuscarPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBuscarPor.Name = "lblBuscarPor";
            lblBuscarPor.Size = new System.Drawing.Size(76, 16);
            lblBuscarPor.TabIndex = 9;
            lblBuscarPor.Text = "Buscar Por:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(340, 160);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 24);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(431, 160);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(70, 24);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(522, 160);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(70, 24);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(612, 160);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(70, 24);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1300, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar Por Sala ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(61, 111);
            this.comboBoxBuscarPor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(143, 24);
            this.comboBoxBuscarPor.TabIndex = 5;
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
            this.salaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.salaDataGridView.DataSource = this.salaBindingSource;
            this.salaDataGridView.Location = new System.Drawing.Point(59, 143);
            this.salaDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.salaDataGridView.Name = "salaDataGridView";
            this.salaDataGridView.ReadOnly = true;
            this.salaDataGridView.RowHeadersVisible = false;
            this.salaDataGridView.RowHeadersWidth = 51;
            this.salaDataGridView.RowTemplate.Height = 24;
            this.salaDataGridView.Size = new System.Drawing.Size(898, 409);
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
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.FillWeight = 146.5241F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // salaBindingSource
            // 
            this.salaBindingSource.DataSource = typeof(Models.Sala);
            // 
            // txtBuscarSala
            // 
            this.txtBuscarSala.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaBindingSource, "Nome", true));
            this.txtBuscarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarSala.Location = new System.Drawing.Point(210, 111);
            this.txtBuscarSala.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarSala.Name = "txtBuscarSala";
            this.txtBuscarSala.Size = new System.Drawing.Size(745, 24);
            this.txtBuscarSala.TabIndex = 10;
            // 
            // buttonSelecionarPredio
            // 
            this.buttonSelecionarPredio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionarPredio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonSelecionarPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarPredio.ForeColor = System.Drawing.Color.White;
            this.buttonSelecionarPredio.Location = new System.Drawing.Point(961, 499);
            this.buttonSelecionarPredio.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionarPredio.Name = "buttonSelecionarPredio";
            this.buttonSelecionarPredio.Size = new System.Drawing.Size(221, 52);
            this.buttonSelecionarPredio.TabIndex = 41;
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
            this.buttonInserir.Location = new System.Drawing.Point(961, 261);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(221, 52);
            this.buttonInserir.TabIndex = 37;
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
            this.buttonExcluir.Location = new System.Drawing.Point(961, 405);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(221, 52);
            this.buttonExcluir.TabIndex = 38;
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
            this.buttonAlterar.Location = new System.Drawing.Point(961, 187);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(221, 52);
            this.buttonAlterar.TabIndex = 39;
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
            this.buttonBuscar.Location = new System.Drawing.Point(961, 111);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(221, 52);
            this.buttonBuscar.TabIndex = 40;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
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
            this.buttonFechar.TabIndex = 42;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            // 
            // FormBuscarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1300, 614);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonSelecionarPredio);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(lblBuscarPor);
            this.Controls.Add(this.txtBuscarSala);
            this.Controls.Add(this.salaDataGridView);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBuscarSala";
            this.Text = "FormBuscarSala";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBuscarPor;
        private System.Windows.Forms.BindingSource salaBindingSource;
        private System.Windows.Forms.DataGridView salaDataGridView;
        private System.Windows.Forms.TextBox txtBuscarSala;
        private System.Windows.Forms.Button buttonSelecionarPredio;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}