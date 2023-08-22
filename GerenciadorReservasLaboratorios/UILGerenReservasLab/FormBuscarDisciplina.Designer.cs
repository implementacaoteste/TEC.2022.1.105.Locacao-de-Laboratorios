namespace UILGerenReservasLab
{
    partial class FormBuscarDisciplina
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
            this.disciplinaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Buscarpor = new System.Windows.Forms.Label();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxBuscarpor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // disciplinaDataGridView
            // 
            this.disciplinaDataGridView.AutoGenerateColumns = false;
            this.disciplinaDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.disciplinaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplinaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.disciplinaDataGridView.DataSource = this.disciplinaBindingSource;
            this.disciplinaDataGridView.Location = new System.Drawing.Point(15, 175);
            this.disciplinaDataGridView.Name = "disciplinaDataGridView";
            this.disciplinaDataGridView.RowHeadersWidth = 51;
            this.disciplinaDataGridView.RowTemplate.Height = 24;
            this.disciplinaDataGridView.Size = new System.Drawing.Size(788, 220);
            this.disciplinaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 245;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 245;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdCurso";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdCurso";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 245;
            // 
            // disciplinaBindingSource
            // 
            this.disciplinaBindingSource.DataSource = typeof(Models.Disciplina);
            // 
            // Buscarpor
            // 
            this.Buscarpor.AutoSize = true;
            this.Buscarpor.Location = new System.Drawing.Point(12, 94);
            this.Buscarpor.Name = "Buscarpor";
            this.Buscarpor.Size = new System.Drawing.Size(76, 16);
            this.Buscarpor.TabIndex = 6;
            this.Buscarpor.Text = "Buscar Por:";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluir.Location = new System.Drawing.Point(671, 105);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 32);
            this.buttonExcluir.TabIndex = 11;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionar.Location = new System.Drawing.Point(590, 105);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 32);
            this.buttonAdicionar.TabIndex = 10;
            this.buttonAdicionar.Text = "&Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterar.Location = new System.Drawing.Point(509, 105);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 32);
            this.buttonAlterar.TabIndex = 9;
            this.buttonAlterar.Text = "Al&terar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.Location = new System.Drawing.Point(428, 105);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 32);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Location = new System.Drawing.Point(129, 113);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(293, 22);
            this.textBoxBuscar.TabIndex = 7;
            // 
            // comboBoxBuscarpor
            // 
            this.comboBoxBuscarpor.FormattingEnabled = true;
            this.comboBoxBuscarpor.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "Todos"});
            this.comboBoxBuscarpor.Location = new System.Drawing.Point(2, 113);
            this.comboBoxBuscarpor.Name = "comboBoxBuscarpor";
            this.comboBoxBuscarpor.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBuscarpor.TabIndex = 14;
            // 
            // FormBuscarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.comboBoxBuscarpor);
            this.Controls.Add(this.Buscarpor);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.disciplinaDataGridView);
            this.Name = "FormBuscarDisciplina";
            this.ShowIcon = false;
            this.Text = "FormBuscarPorDisciplina";
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource disciplinaBindingSource;
        private System.Windows.Forms.DataGridView disciplinaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label Buscarpor;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.ComboBox comboBoxBuscarpor;
    }
}