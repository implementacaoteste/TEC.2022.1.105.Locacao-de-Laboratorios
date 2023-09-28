namespace UILGerenReservasLab
{
    partial class FormBuscarPermissao
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
            this.buttonBuscarPermissao = new System.Windows.Forms.Button();
            this.buttonAlterarPermissao = new System.Windows.Forms.Button();
            this.buttonAdicionarPermissao = new System.Windows.Forms.Button();
            this.buttonExcluirPermissao = new System.Windows.Forms.Button();
            this.buttonAdicionarPermissaoGrupo = new System.Windows.Forms.Button();
            this.buttonExcluirPermissaoGrupo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton_BuscarTodasPermissoes = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarPorNome = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarPorId = new System.Windows.Forms.RadioButton();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscarPermissao
            // 
            this.buttonBuscarPermissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarPermissao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonBuscarPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarPermissao.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBuscarPermissao.Location = new System.Drawing.Point(458, 77);
            this.buttonBuscarPermissao.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarPermissao.Name = "buttonBuscarPermissao";
            this.buttonBuscarPermissao.Size = new System.Drawing.Size(94, 31);
            this.buttonBuscarPermissao.TabIndex = 3;
            this.buttonBuscarPermissao.Text = "&Buscar";
            this.buttonBuscarPermissao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBuscarPermissao.UseVisualStyleBackColor = false;
            this.buttonBuscarPermissao.Click += new System.EventHandler(this.buttonBuscarPermissao_Click);
            // 
            // buttonAlterarPermissao
            // 
            this.buttonAlterarPermissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterarPermissao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonAlterarPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarPermissao.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAlterarPermissao.Location = new System.Drawing.Point(556, 77);
            this.buttonAlterarPermissao.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterarPermissao.Name = "buttonAlterarPermissao";
            this.buttonAlterarPermissao.Size = new System.Drawing.Size(94, 31);
            this.buttonAlterarPermissao.TabIndex = 4;
            this.buttonAlterarPermissao.Text = "&Alterar";
            this.buttonAlterarPermissao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAlterarPermissao.UseVisualStyleBackColor = false;
            this.buttonAlterarPermissao.Click += new System.EventHandler(this.buttonAlterarPermissao_Click);
            // 
            // buttonAdicionarPermissao
            // 
            this.buttonAdicionarPermissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionarPermissao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonAdicionarPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarPermissao.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdicionarPermissao.Location = new System.Drawing.Point(654, 78);
            this.buttonAdicionarPermissao.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarPermissao.Name = "buttonAdicionarPermissao";
            this.buttonAdicionarPermissao.Size = new System.Drawing.Size(94, 31);
            this.buttonAdicionarPermissao.TabIndex = 5;
            this.buttonAdicionarPermissao.Text = "&Inserir";
            this.buttonAdicionarPermissao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdicionarPermissao.UseVisualStyleBackColor = false;
            this.buttonAdicionarPermissao.Click += new System.EventHandler(this.buttonAdicionarPermissao_Click);
            // 
            // buttonExcluirPermissao
            // 
            this.buttonExcluirPermissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirPermissao.BackColor = System.Drawing.Color.Firebrick;
            this.buttonExcluirPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirPermissao.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExcluirPermissao.Location = new System.Drawing.Point(752, 78);
            this.buttonExcluirPermissao.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluirPermissao.Name = "buttonExcluirPermissao";
            this.buttonExcluirPermissao.Size = new System.Drawing.Size(94, 31);
            this.buttonExcluirPermissao.TabIndex = 6;
            this.buttonExcluirPermissao.Text = "&Excluir";
            this.buttonExcluirPermissao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExcluirPermissao.UseVisualStyleBackColor = false;
            this.buttonExcluirPermissao.Click += new System.EventHandler(this.buttonExcluirPermissao_Click);
            // 
            // buttonAdicionarPermissaoGrupo
            // 
            this.buttonAdicionarPermissaoGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionarPermissaoGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonAdicionarPermissaoGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarPermissaoGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarPermissaoGrupo.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdicionarPermissaoGrupo.Location = new System.Drawing.Point(1070, 76);
            this.buttonAdicionarPermissaoGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarPermissaoGrupo.Name = "buttonAdicionarPermissaoGrupo";
            this.buttonAdicionarPermissaoGrupo.Size = new System.Drawing.Size(94, 31);
            this.buttonAdicionarPermissaoGrupo.TabIndex = 7;
            this.buttonAdicionarPermissaoGrupo.Text = "A&dicionar";
            this.buttonAdicionarPermissaoGrupo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdicionarPermissaoGrupo.UseVisualStyleBackColor = false;
            this.buttonAdicionarPermissaoGrupo.Click += new System.EventHandler(this.buttonAdicionarPermissaoGrupo_Click);
            // 
            // buttonExcluirPermissaoGrupo
            // 
            this.buttonExcluirPermissaoGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirPermissaoGrupo.BackColor = System.Drawing.Color.Firebrick;
            this.buttonExcluirPermissaoGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirPermissaoGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirPermissaoGrupo.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExcluirPermissaoGrupo.Location = new System.Drawing.Point(1168, 76);
            this.buttonExcluirPermissaoGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluirPermissaoGrupo.Name = "buttonExcluirPermissaoGrupo";
            this.buttonExcluirPermissaoGrupo.Size = new System.Drawing.Size(94, 31);
            this.buttonExcluirPermissaoGrupo.TabIndex = 8;
            this.buttonExcluirPermissaoGrupo.Text = "E&xcluir";
            this.buttonExcluirPermissaoGrupo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExcluirPermissaoGrupo.UseVisualStyleBackColor = false;
            this.buttonExcluirPermissaoGrupo.Click += new System.EventHandler(this.buttonExcluirPermissaoGrupo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 24);
            this.textBox1.TabIndex = 9;
            // 
            // radioButton_BuscarTodasPermissoes
            // 
            this.radioButton_BuscarTodasPermissoes.AutoSize = true;
            this.radioButton_BuscarTodasPermissoes.Checked = true;
            this.radioButton_BuscarTodasPermissoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_BuscarTodasPermissoes.Location = new System.Drawing.Point(33, 49);
            this.radioButton_BuscarTodasPermissoes.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_BuscarTodasPermissoes.Name = "radioButton_BuscarTodasPermissoes";
            this.radioButton_BuscarTodasPermissoes.Size = new System.Drawing.Size(118, 22);
            this.radioButton_BuscarTodasPermissoes.TabIndex = 10;
            this.radioButton_BuscarTodasPermissoes.TabStop = true;
            this.radioButton_BuscarTodasPermissoes.Text = "Buscar todos";
            this.radioButton_BuscarTodasPermissoes.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPorNome
            // 
            this.radioButton_BuscarPorNome.AutoSize = true;
            this.radioButton_BuscarPorNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_BuscarPorNome.Location = new System.Drawing.Point(155, 49);
            this.radioButton_BuscarPorNome.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_BuscarPorNome.Name = "radioButton_BuscarPorNome";
            this.radioButton_BuscarPorNome.Size = new System.Drawing.Size(125, 22);
            this.radioButton_BuscarPorNome.TabIndex = 11;
            this.radioButton_BuscarPorNome.TabStop = true;
            this.radioButton_BuscarPorNome.Text = "Buscar/ Nome";
            this.radioButton_BuscarPorNome.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPorId
            // 
            this.radioButton_BuscarPorId.AutoSize = true;
            this.radioButton_BuscarPorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_BuscarPorId.Location = new System.Drawing.Point(286, 49);
            this.radioButton_BuscarPorId.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_BuscarPorId.Name = "radioButton_BuscarPorId";
            this.radioButton_BuscarPorId.Size = new System.Drawing.Size(102, 22);
            this.radioButton_BuscarPorId.TabIndex = 12;
            this.radioButton_BuscarPorId.TabStop = true;
            this.radioButton_BuscarPorId.Text = "Buscar / ID";
            this.radioButton_BuscarPorId.UseVisualStyleBackColor = true;
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // grupoUsuarioDataGridView
            // 
            this.grupoUsuarioDataGridView.AllowUserToAddRows = false;
            this.grupoUsuarioDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuarioDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuarioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoUsuarioDataGridView.AutoGenerateColumns = false;
            this.grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.grupoUsuarioDataGridView.DataSource = this.grupoUsuarioBindingSource;
            this.grupoUsuarioDataGridView.Location = new System.Drawing.Point(850, 121);
            this.grupoUsuarioDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            this.grupoUsuarioDataGridView.ReadOnly = true;
            this.grupoUsuarioDataGridView.RowHeadersVisible = false;
            this.grupoUsuarioDataGridView.RowHeadersWidth = 51;
            this.grupoUsuarioDataGridView.RowTemplate.Height = 24;
            this.grupoUsuarioDataGridView.Size = new System.Drawing.Size(412, 462);
            this.grupoUsuarioDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Grupos";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // permissoesBindingSource
            // 
            this.permissoesBindingSource.DataMember = "Permissoes";
            this.permissoesBindingSource.DataSource = this.grupoUsuarioBindingSource;
            // 
            // permissoesDataGridView
            // 
            this.permissoesDataGridView.AllowUserToAddRows = false;
            this.permissoesDataGridView.AllowUserToDeleteRows = false;
            this.permissoesDataGridView.AllowUserToOrderColumns = true;
            this.permissoesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.permissoesDataGridView.AutoGenerateColumns = false;
            this.permissoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.Id});
            this.permissoesDataGridView.DataSource = this.permissoesBindingSource;
            this.permissoesDataGridView.Location = new System.Drawing.Point(35, 121);
            this.permissoesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.permissoesDataGridView.Name = "permissoesDataGridView";
            this.permissoesDataGridView.ReadOnly = true;
            this.permissoesDataGridView.RowHeadersVisible = false;
            this.permissoesDataGridView.RowHeadersWidth = 51;
            this.permissoesDataGridView.RowTemplate.Height = 24;
            this.permissoesDataGridView.Size = new System.Drawing.Size(811, 462);
            this.permissoesDataGridView.TabIndex = 13;
            this.permissoesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.permissoesDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFechar.BackColor = System.Drawing.Color.Red;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFechar.Location = new System.Drawing.Point(1193, 13);
            this.buttonFechar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(94, 29);
            this.buttonFechar.TabIndex = 29;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormBuscarPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1300, 614);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.permissoesDataGridView);
            this.Controls.Add(this.grupoUsuarioDataGridView);
            this.Controls.Add(this.radioButton_BuscarPorId);
            this.Controls.Add(this.radioButton_BuscarPorNome);
            this.Controls.Add(this.radioButton_BuscarTodasPermissoes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonExcluirPermissaoGrupo);
            this.Controls.Add(this.buttonAdicionarPermissaoGrupo);
            this.Controls.Add(this.buttonExcluirPermissao);
            this.Controls.Add(this.buttonAdicionarPermissao);
            this.Controls.Add(this.buttonAlterarPermissao);
            this.Controls.Add(this.buttonBuscarPermissao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBuscarPermissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Permissões";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBuscarPermissao;
        private System.Windows.Forms.Button buttonAlterarPermissao;
        private System.Windows.Forms.Button buttonAdicionarPermissao;
        private System.Windows.Forms.Button buttonExcluirPermissao;
        private System.Windows.Forms.Button buttonAdicionarPermissaoGrupo;
        private System.Windows.Forms.Button buttonExcluirPermissaoGrupo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton_BuscarTodasPermissoes;
        private System.Windows.Forms.RadioButton radioButton_BuscarPorNome;
        private System.Windows.Forms.RadioButton radioButton_BuscarPorId;
        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource permissoesBindingSource;
        private System.Windows.Forms.DataGridView permissoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Button buttonFechar;
    }
}