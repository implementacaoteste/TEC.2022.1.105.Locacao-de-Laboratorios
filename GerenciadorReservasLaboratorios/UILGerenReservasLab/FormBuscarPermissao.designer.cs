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
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscarPermissao
            // 
            this.buttonBuscarPermissao.Location = new System.Drawing.Point(241, 66);
            this.buttonBuscarPermissao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarPermissao.Name = "buttonBuscarPermissao";
            this.buttonBuscarPermissao.Size = new System.Drawing.Size(56, 19);
            this.buttonBuscarPermissao.TabIndex = 3;
            this.buttonBuscarPermissao.Text = "Buscar";
            this.buttonBuscarPermissao.UseVisualStyleBackColor = true;
            this.buttonBuscarPermissao.Click += new System.EventHandler(this.buttonBuscarPermissao_Click);
            // 
            // buttonAlterarPermissao
            // 
            this.buttonAlterarPermissao.Location = new System.Drawing.Point(302, 67);
            this.buttonAlterarPermissao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAlterarPermissao.Name = "buttonAlterarPermissao";
            this.buttonAlterarPermissao.Size = new System.Drawing.Size(56, 19);
            this.buttonAlterarPermissao.TabIndex = 4;
            this.buttonAlterarPermissao.Text = "Alterar";
            this.buttonAlterarPermissao.UseVisualStyleBackColor = true;
            this.buttonAlterarPermissao.Click += new System.EventHandler(this.buttonAlterarPermissao_Click);
            // 
            // buttonAdicionarPermissao
            // 
            this.buttonAdicionarPermissao.Location = new System.Drawing.Point(362, 67);
            this.buttonAdicionarPermissao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdicionarPermissao.Name = "buttonAdicionarPermissao";
            this.buttonAdicionarPermissao.Size = new System.Drawing.Size(56, 19);
            this.buttonAdicionarPermissao.TabIndex = 5;
            this.buttonAdicionarPermissao.Text = "Adicionar";
            this.buttonAdicionarPermissao.UseVisualStyleBackColor = true;
            this.buttonAdicionarPermissao.Click += new System.EventHandler(this.buttonAdicionarPermissao_Click);
            // 
            // buttonExcluirPermissao
            // 
            this.buttonExcluirPermissao.Location = new System.Drawing.Point(423, 67);
            this.buttonExcluirPermissao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExcluirPermissao.Name = "buttonExcluirPermissao";
            this.buttonExcluirPermissao.Size = new System.Drawing.Size(56, 19);
            this.buttonExcluirPermissao.TabIndex = 6;
            this.buttonExcluirPermissao.Text = "Excluir";
            this.buttonExcluirPermissao.UseVisualStyleBackColor = true;
            this.buttonExcluirPermissao.Click += new System.EventHandler(this.buttonExcluirPermissao_Click);
            // 
            // buttonAdicionarPermissaoGrupo
            // 
            this.buttonAdicionarPermissaoGrupo.Location = new System.Drawing.Point(730, 73);
            this.buttonAdicionarPermissaoGrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdicionarPermissaoGrupo.Name = "buttonAdicionarPermissaoGrupo";
            this.buttonAdicionarPermissaoGrupo.Size = new System.Drawing.Size(63, 19);
            this.buttonAdicionarPermissaoGrupo.TabIndex = 7;
            this.buttonAdicionarPermissaoGrupo.Text = "Adicionar";
            this.buttonAdicionarPermissaoGrupo.UseVisualStyleBackColor = true;
            this.buttonAdicionarPermissaoGrupo.Click += new System.EventHandler(this.buttonAdicionarPermissaoGrupo_Click);
            // 
            // buttonExcluirPermissaoGrupo
            // 
            this.buttonExcluirPermissaoGrupo.Location = new System.Drawing.Point(803, 73);
            this.buttonExcluirPermissaoGrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExcluirPermissaoGrupo.Name = "buttonExcluirPermissaoGrupo";
            this.buttonExcluirPermissaoGrupo.Size = new System.Drawing.Size(56, 19);
            this.buttonExcluirPermissaoGrupo.TabIndex = 8;
            this.buttonExcluirPermissaoGrupo.Text = "Excluir";
            this.buttonExcluirPermissaoGrupo.UseVisualStyleBackColor = true;
            this.buttonExcluirPermissaoGrupo.Click += new System.EventHandler(this.buttonExcluirPermissaoGrupo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 67);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 9;
            // 
            // radioButton_BuscarTodasPermissoes
            // 
            this.radioButton_BuscarTodasPermissoes.AutoSize = true;
            this.radioButton_BuscarTodasPermissoes.Checked = true;
            this.radioButton_BuscarTodasPermissoes.Location = new System.Drawing.Point(9, 46);
            this.radioButton_BuscarTodasPermissoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_BuscarTodasPermissoes.Name = "radioButton_BuscarTodasPermissoes";
            this.radioButton_BuscarTodasPermissoes.Size = new System.Drawing.Size(87, 17);
            this.radioButton_BuscarTodasPermissoes.TabIndex = 10;
            this.radioButton_BuscarTodasPermissoes.TabStop = true;
            this.radioButton_BuscarTodasPermissoes.Text = "Buscar todos";
            this.radioButton_BuscarTodasPermissoes.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPorNome
            // 
            this.radioButton_BuscarPorNome.AutoSize = true;
            this.radioButton_BuscarPorNome.Location = new System.Drawing.Point(91, 46);
            this.radioButton_BuscarPorNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_BuscarPorNome.Name = "radioButton_BuscarPorNome";
            this.radioButton_BuscarPorNome.Size = new System.Drawing.Size(94, 17);
            this.radioButton_BuscarPorNome.TabIndex = 11;
            this.radioButton_BuscarPorNome.TabStop = true;
            this.radioButton_BuscarPorNome.Text = "Buscar/ Nome";
            this.radioButton_BuscarPorNome.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPorId
            // 
            this.radioButton_BuscarPorId.AutoSize = true;
            this.radioButton_BuscarPorId.Location = new System.Drawing.Point(181, 46);
            this.radioButton_BuscarPorId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_BuscarPorId.Name = "radioButton_BuscarPorId";
            this.radioButton_BuscarPorId.Size = new System.Drawing.Size(80, 17);
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
            this.grupoUsuarioDataGridView.AutoGenerateColumns = false;
            this.grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.grupoUsuarioDataGridView.DataSource = this.grupoUsuarioBindingSource;
            this.grupoUsuarioDataGridView.Location = new System.Drawing.Point(484, 97);
            this.grupoUsuarioDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            this.grupoUsuarioDataGridView.ReadOnly = true;
            this.grupoUsuarioDataGridView.RowHeadersVisible = false;
            this.grupoUsuarioDataGridView.RowHeadersWidth = 51;
            this.grupoUsuarioDataGridView.RowTemplate.Height = 24;
            this.grupoUsuarioDataGridView.Size = new System.Drawing.Size(376, 271);
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
            this.permissoesDataGridView.AutoGenerateColumns = false;
            this.permissoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.permissoesDataGridView.DataSource = this.permissoesBindingSource;
            this.permissoesDataGridView.Location = new System.Drawing.Point(9, 97);
            this.permissoesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.permissoesDataGridView.Name = "permissoesDataGridView";
            this.permissoesDataGridView.ReadOnly = true;
            this.permissoesDataGridView.RowHeadersVisible = false;
            this.permissoesDataGridView.RowHeadersWidth = 51;
            this.permissoesDataGridView.RowTemplate.Height = 24;
            this.permissoesDataGridView.Size = new System.Drawing.Size(470, 271);
            this.permissoesDataGridView.TabIndex = 13;
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
            // FormBuscarPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(868, 492);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBuscarPermissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Permissão";
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
    }
}