namespace WindowsFormsApp
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
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.grupoUsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonBuscarPermissao = new System.Windows.Forms.Button();
            this.buttonAlterarPermissao = new System.Windows.Forms.Button();
            this.buttonAdicionarPermissao = new System.Windows.Forms.Button();
            this.buttonExcluirPermissao = new System.Windows.Forms.Button();
            this.buttonAdionarPermissaoGrupo = new System.Windows.Forms.Button();
            this.buttonExcluirPermissaoGrupo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton_BuscarTodasPermissoes = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarPorNome = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarPorId = new System.Windows.Forms.RadioButton();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // permissaoDataGridView
            // 
            this.permissaoDataGridView.AllowUserToAddRows = false;
            this.permissaoDataGridView.AllowUserToDeleteRows = false;
            this.permissaoDataGridView.AllowUserToOrderColumns = true;
            this.permissaoDataGridView.AutoGenerateColumns = false;
            this.permissaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.permissaoDataGridView.DataSource = this.permissaoBindingSource;
            this.permissaoDataGridView.Location = new System.Drawing.Point(12, 134);
            this.permissaoDataGridView.Name = "permissaoDataGridView";
            this.permissaoDataGridView.ReadOnly = true;
            this.permissaoDataGridView.RowHeadersVisible = false;
            this.permissaoDataGridView.RowHeadersWidth = 51;
            this.permissaoDataGridView.RowTemplate.Height = 24;
            this.permissaoDataGridView.Size = new System.Drawing.Size(581, 273);
            this.permissaoDataGridView.TabIndex = 1;
            // 
            // grupoUsuariosDataGridView
            // 
            this.grupoUsuariosDataGridView.AllowUserToAddRows = false;
            this.grupoUsuariosDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuariosDataGridView.AutoGenerateColumns = false;
            this.grupoUsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.grupoUsuariosDataGridView.DataSource = this.grupoUsuariosBindingSource;
            this.grupoUsuariosDataGridView.Location = new System.Drawing.Point(612, 134);
            this.grupoUsuariosDataGridView.Name = "grupoUsuariosDataGridView";
            this.grupoUsuariosDataGridView.ReadOnly = true;
            this.grupoUsuariosDataGridView.RowHeadersVisible = false;
            this.grupoUsuariosDataGridView.RowHeadersWidth = 51;
            this.grupoUsuariosDataGridView.RowTemplate.Height = 24;
            this.grupoUsuariosDataGridView.Size = new System.Drawing.Size(313, 273);
            this.grupoUsuariosDataGridView.TabIndex = 2;
            // 
            // buttonBuscarPermissao
            // 
            this.buttonBuscarPermissao.Location = new System.Drawing.Point(321, 81);
            this.buttonBuscarPermissao.Name = "buttonBuscarPermissao";
            this.buttonBuscarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarPermissao.TabIndex = 3;
            this.buttonBuscarPermissao.Text = "Buscar";
            this.buttonBuscarPermissao.UseVisualStyleBackColor = true;
            this.buttonBuscarPermissao.Click += new System.EventHandler(this.buttonBuscarPermissao_Click);
            // 
            // buttonAlterarPermissao
            // 
            this.buttonAlterarPermissao.Location = new System.Drawing.Point(402, 82);
            this.buttonAlterarPermissao.Name = "buttonAlterarPermissao";
            this.buttonAlterarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarPermissao.TabIndex = 4;
            this.buttonAlterarPermissao.Text = "Alterar";
            this.buttonAlterarPermissao.UseVisualStyleBackColor = true;
            this.buttonAlterarPermissao.Click += new System.EventHandler(this.buttonAlterarPermissao_Click);
            // 
            // buttonAdicionarPermissao
            // 
            this.buttonAdicionarPermissao.Location = new System.Drawing.Point(483, 82);
            this.buttonAdicionarPermissao.Name = "buttonAdicionarPermissao";
            this.buttonAdicionarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarPermissao.TabIndex = 5;
            this.buttonAdicionarPermissao.Text = "Adicionar";
            this.buttonAdicionarPermissao.UseVisualStyleBackColor = true;
            this.buttonAdicionarPermissao.Click += new System.EventHandler(this.buttonAdicionarPermissao_Click);
            // 
            // buttonExcluirPermissao
            // 
            this.buttonExcluirPermissao.Location = new System.Drawing.Point(564, 82);
            this.buttonExcluirPermissao.Name = "buttonExcluirPermissao";
            this.buttonExcluirPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirPermissao.TabIndex = 6;
            this.buttonExcluirPermissao.Text = "Excluir";
            this.buttonExcluirPermissao.UseVisualStyleBackColor = true;
            this.buttonExcluirPermissao.Click += new System.EventHandler(this.buttonExcluirPermissao_Click);
            // 
            // buttonAdionarPermissaoGrupo
            // 
            this.buttonAdionarPermissaoGrupo.Location = new System.Drawing.Point(752, 105);
            this.buttonAdionarPermissaoGrupo.Name = "buttonAdionarPermissaoGrupo";
            this.buttonAdionarPermissaoGrupo.Size = new System.Drawing.Size(84, 23);
            this.buttonAdionarPermissaoGrupo.TabIndex = 7;
            this.buttonAdionarPermissaoGrupo.Text = "Adicionar";
            this.buttonAdionarPermissaoGrupo.UseVisualStyleBackColor = true;
            this.buttonAdionarPermissaoGrupo.Click += new System.EventHandler(this.buttonAdionarPermissaoGrupo_Click);
            // 
            // buttonExcluirPermissaoGrupo
            // 
            this.buttonExcluirPermissaoGrupo.Location = new System.Drawing.Point(850, 105);
            this.buttonExcluirPermissaoGrupo.Name = "buttonExcluirPermissaoGrupo";
            this.buttonExcluirPermissaoGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirPermissaoGrupo.TabIndex = 8;
            this.buttonExcluirPermissaoGrupo.Text = "Excluir";
            this.buttonExcluirPermissaoGrupo.UseVisualStyleBackColor = true;
            this.buttonExcluirPermissaoGrupo.Click += new System.EventHandler(this.buttonExcluirPermissaoGrupo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 22);
            this.textBox1.TabIndex = 9;
            // 
            // radioButton_BuscarTodasPermissoes
            // 
            this.radioButton_BuscarTodasPermissoes.AutoSize = true;
            this.radioButton_BuscarTodasPermissoes.Checked = true;
            this.radioButton_BuscarTodasPermissoes.Location = new System.Drawing.Point(12, 56);
            this.radioButton_BuscarTodasPermissoes.Name = "radioButton_BuscarTodasPermissoes";
            this.radioButton_BuscarTodasPermissoes.Size = new System.Drawing.Size(107, 20);
            this.radioButton_BuscarTodasPermissoes.TabIndex = 10;
            this.radioButton_BuscarTodasPermissoes.TabStop = true;
            this.radioButton_BuscarTodasPermissoes.Text = "Buscar todos";
            this.radioButton_BuscarTodasPermissoes.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPorNome
            // 
            this.radioButton_BuscarPorNome.AutoSize = true;
            this.radioButton_BuscarPorNome.Location = new System.Drawing.Point(121, 56);
            this.radioButton_BuscarPorNome.Name = "radioButton_BuscarPorNome";
            this.radioButton_BuscarPorNome.Size = new System.Drawing.Size(114, 20);
            this.radioButton_BuscarPorNome.TabIndex = 11;
            this.radioButton_BuscarPorNome.TabStop = true;
            this.radioButton_BuscarPorNome.Text = "Buscar/ Nome";
            this.radioButton_BuscarPorNome.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPorId
            // 
            this.radioButton_BuscarPorId.AutoSize = true;
            this.radioButton_BuscarPorId.Location = new System.Drawing.Point(241, 56);
            this.radioButton_BuscarPorId.Name = "radioButton_BuscarPorId";
            this.radioButton_BuscarPorId.Size = new System.Drawing.Size(93, 20);
            this.radioButton_BuscarPorId.TabIndex = 12;
            this.radioButton_BuscarPorId.TabStop = true;
            this.radioButton_BuscarPorId.Text = "Buscar / ID";
            this.radioButton_BuscarPorId.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn3.HeaderText = "NomeGrupo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // grupoUsuariosBindingSource
            // 
            this.grupoUsuariosBindingSource.DataMember = "GrupoUsuarios";
            this.grupoUsuariosBindingSource.DataSource = this.permissaoBindingSource;
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FormBuscarPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 466);
            this.Controls.Add(this.radioButton_BuscarPorId);
            this.Controls.Add(this.radioButton_BuscarPorNome);
            this.Controls.Add(this.radioButton_BuscarTodasPermissoes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonExcluirPermissaoGrupo);
            this.Controls.Add(this.buttonAdionarPermissaoGrupo);
            this.Controls.Add(this.buttonExcluirPermissao);
            this.Controls.Add(this.buttonAdicionarPermissao);
            this.Controls.Add(this.buttonAlterarPermissao);
            this.Controls.Add(this.buttonBuscarPermissao);
            this.Controls.Add(this.grupoUsuariosDataGridView);
            this.Controls.Add(this.permissaoDataGridView);
            this.Name = "FormBuscarPermissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Permissão";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource grupoUsuariosBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button buttonBuscarPermissao;
        private System.Windows.Forms.Button buttonAlterarPermissao;
        private System.Windows.Forms.Button buttonAdicionarPermissao;
        private System.Windows.Forms.Button buttonExcluirPermissao;
        private System.Windows.Forms.Button buttonAdionarPermissaoGrupo;
        private System.Windows.Forms.Button buttonExcluirPermissaoGrupo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton_BuscarTodasPermissoes;
        private System.Windows.Forms.RadioButton radioButton_BuscarPorNome;
        private System.Windows.Forms.RadioButton radioButton_BuscarPorId;
    }
}