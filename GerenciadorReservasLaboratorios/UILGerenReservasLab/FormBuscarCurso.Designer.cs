namespace UILGerenReservasLab
{
    partial class FormBuscarCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFechar = new System.Windows.Forms.Button();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSelecionarCurso = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.cursoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.ForeColor = System.Drawing.Color.White;
            this.buttonAlterar.Location = new System.Drawing.Point(968, 188);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(221, 52);
            this.buttonAlterar.TabIndex = 20;
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
            this.buttonBuscar.Location = new System.Drawing.Point(968, 112);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(221, 52);
            this.buttonBuscar.TabIndex = 21;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(Models.Curso);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFechar.BackColor = System.Drawing.Color.Red;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFechar.Location = new System.Drawing.Point(1200, 13);
            this.buttonFechar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(94, 29);
            this.buttonFechar.TabIndex = 27;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "Todos"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(59, 111);
            this.comboBoxBuscarPor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(143, 24);
            this.comboBoxBuscarPor.TabIndex = 30;
            this.comboBoxBuscarPor.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscarPor_SelectedIndexChanged);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Location = new System.Drawing.Point(210, 111);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(752, 22);
            this.textBoxBuscar.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Buscar por";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluir.BackColor = System.Drawing.Color.Red;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.ForeColor = System.Drawing.Color.White;
            this.buttonExcluir.Location = new System.Drawing.Point(968, 406);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(221, 52);
            this.buttonExcluir.TabIndex = 20;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonSelecionarCurso
            // 
            this.buttonSelecionarCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonSelecionarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarCurso.ForeColor = System.Drawing.Color.White;
            this.buttonSelecionarCurso.Location = new System.Drawing.Point(968, 500);
            this.buttonSelecionarCurso.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionarCurso.Name = "buttonSelecionarCurso";
            this.buttonSelecionarCurso.Size = new System.Drawing.Size(221, 52);
            this.buttonSelecionarCurso.TabIndex = 31;
            this.buttonSelecionarCurso.Text = "&Selecionar";
            this.buttonSelecionarCurso.UseVisualStyleBackColor = false;
            this.buttonSelecionarCurso.Click += new System.EventHandler(this.buttonSelecionarCurso_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserir.ForeColor = System.Drawing.Color.White;
            this.buttonInserir.Location = new System.Drawing.Point(968, 262);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(221, 52);
            this.buttonInserir.TabIndex = 35;
            this.buttonInserir.Text = "&Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // cursoDataGridView
            // 
            this.cursoDataGridView.AllowUserToAddRows = false;
            this.cursoDataGridView.AllowUserToDeleteRows = false;
            this.cursoDataGridView.AllowUserToOrderColumns = true;
            this.cursoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cursoDataGridView.AutoGenerateColumns = false;
            this.cursoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.cursoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cursoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cursoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cursoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cursoDataGridView.ColumnHeadersHeight = 29;
            this.cursoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cursoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.cursoDataGridView.DataSource = this.cursoBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cursoDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.cursoDataGridView.EnableHeadersVisualStyles = false;
            this.cursoDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cursoDataGridView.Location = new System.Drawing.Point(59, 143);
            this.cursoDataGridView.Name = "cursoDataGridView";
            this.cursoDataGridView.ReadOnly = true;
            this.cursoDataGridView.RowHeadersVisible = false;
            this.cursoDataGridView.RowHeadersWidth = 51;
            this.cursoDataGridView.RowTemplate.Height = 24;
            this.cursoDataGridView.Size = new System.Drawing.Size(898, 409);
            this.cursoDataGridView.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Turno";
            this.dataGridViewTextBoxColumn3.HeaderText = "Turno";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FormBuscarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1307, 614);
            this.Controls.Add(this.cursoDataGridView);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonSelecionarCurso);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(848, 448);
            this.Name = "FormBuscarCurso";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.ComboBox comboBoxBuscarPor;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonSelecionarCurso;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.DataGridView cursoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}