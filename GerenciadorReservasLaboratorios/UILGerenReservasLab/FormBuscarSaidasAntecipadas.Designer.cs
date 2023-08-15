namespace UILGerenReservasLab
{
    partial class FormBuscarSaidasAntecipadas
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
            this.label2 = new System.Windows.Forms.Label();
            this.saidasAntecipadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saidasAntecipadasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelBusar = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.saidasAntecipadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidasAntecipadasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(988, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "Consulta de Saídas Antecipadas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saidasAntecipadasBindingSource
            // 
            this.saidasAntecipadasBindingSource.DataSource = typeof(Models.SaidasAntecipadas);
            // 
            // saidasAntecipadasDataGridView
            // 
            this.saidasAntecipadasDataGridView.AutoGenerateColumns = false;
            this.saidasAntecipadasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.saidasAntecipadasDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.saidasAntecipadasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saidasAntecipadasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.saidasAntecipadasDataGridView.DataSource = this.saidasAntecipadasBindingSource;
            this.saidasAntecipadasDataGridView.Location = new System.Drawing.Point(8, 135);
            this.saidasAntecipadasDataGridView.Name = "saidasAntecipadasDataGridView";
            this.saidasAntecipadasDataGridView.RowHeadersWidth = 51;
            this.saidasAntecipadasDataGridView.RowTemplate.Height = 24;
            this.saidasAntecipadasDataGridView.Size = new System.Drawing.Size(980, 311);
            this.saidasAntecipadasDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdAluno";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdAluno";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdProfessor";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdProfessor";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdCoordenacao";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdCoordenacao";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Motivo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Motivo";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DataHoraSaida";
            this.dataGridViewTextBoxColumn7.HeaderText = "DataHoraSaida";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 22);
            this.textBox1.TabIndex = 16;
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Id",
            "Id do Aluno",
            "Id do Professor",
            "Id da Coordenação",
            "Status",
            "Buscar Todos"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(12, 100);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBuscarPor.TabIndex = 17;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluir.Location = new System.Drawing.Point(905, 102);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(74, 27);
            this.buttonExcluir.TabIndex = 18;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInserir.Location = new System.Drawing.Point(825, 100);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(74, 27);
            this.buttonInserir.TabIndex = 19;
            this.buttonInserir.Text = "&Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterar.Location = new System.Drawing.Point(745, 100);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(74, 27);
            this.buttonAlterar.TabIndex = 20;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.Location = new System.Drawing.Point(665, 100);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(74, 27);
            this.buttonBuscar.TabIndex = 21;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // labelBusar
            // 
            this.labelBusar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBusar.AutoSize = true;
            this.labelBusar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusar.Location = new System.Drawing.Point(8, 77);
            this.labelBusar.Name = "labelBusar";
            this.labelBusar.Size = new System.Drawing.Size(92, 20);
            this.labelBusar.TabIndex = 22;
            this.labelBusar.Text = "Buscar por";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(904, 467);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 23;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionar.Location = new System.Drawing.Point(816, 467);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(83, 23);
            this.buttonSelecionar.TabIndex = 24;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            // 
            // FormBuscarSaidasAntecipadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 502);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.labelBusar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.saidasAntecipadasDataGridView);
            this.Controls.Add(this.label2);
            this.Name = "FormBuscarSaidasAntecipadas";
            this.ShowIcon = false;
            this.Text = "Gestão de Saidas Antecipadas";
            ((System.ComponentModel.ISupportInitialize)(this.saidasAntecipadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidasAntecipadasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource saidasAntecipadasBindingSource;
        private System.Windows.Forms.DataGridView saidasAntecipadasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxBuscarPor;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelBusar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSelecionar;
    }
}