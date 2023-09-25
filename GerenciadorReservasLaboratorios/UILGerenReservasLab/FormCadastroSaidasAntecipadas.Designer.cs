using Models;

namespace UILGerenReservasLab
{
    partial class FormCadastroSaidasAntecipadas
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
            System.Windows.Forms.Label dataHoraSaidaLabel;
            System.Windows.Forms.Label idAlunoLabel;
            System.Windows.Forms.Label idCoordenacaoLabel;
            System.Windows.Forms.Label idProfessorLabel;
            System.Windows.Forms.Label motivoLabel;
            System.Windows.Forms.Label statusLabel;
            this.dataHoraSaidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saidasAntecipadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTextBox = new System.Windows.Forms.TextBox();
            this.motivoTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBuscarAluno = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxProfessor = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCoordenador = new System.Windows.Forms.ComboBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonMinimizar = new System.Windows.Forms.PictureBox();
            this.buttonRestaurar = new System.Windows.Forms.PictureBox();
            this.buttonMaximizar = new System.Windows.Forms.PictureBox();
            this.buttonFechar = new System.Windows.Forms.PictureBox();
            dataHoraSaidaLabel = new System.Windows.Forms.Label();
            idAlunoLabel = new System.Windows.Forms.Label();
            idCoordenacaoLabel = new System.Windows.Forms.Label();
            idProfessorLabel = new System.Windows.Forms.Label();
            motivoLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.saidasAntecipadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHoraSaidaLabel
            // 
            dataHoraSaidaLabel.AutoSize = true;
            dataHoraSaidaLabel.Location = new System.Drawing.Point(859, 290);
            dataHoraSaidaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataHoraSaidaLabel.Name = "dataHoraSaidaLabel";
            dataHoraSaidaLabel.Size = new System.Drawing.Size(173, 16);
            dataHoraSaidaLabel.TabIndex = 1;
            dataHoraSaidaLabel.Text = "Data e Hora da Autorização";
            // 
            // idAlunoLabel
            // 
            idAlunoLabel.AutoSize = true;
            idAlunoLabel.Location = new System.Drawing.Point(12, 214);
            idAlunoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idAlunoLabel.Name = "idAlunoLabel";
            idAlunoLabel.Size = new System.Drawing.Size(41, 16);
            idAlunoLabel.TabIndex = 3;
            idAlunoLabel.Text = "Aluno";
            // 
            // idCoordenacaoLabel
            // 
            idCoordenacaoLabel.AutoSize = true;
            idCoordenacaoLabel.Location = new System.Drawing.Point(429, 286);
            idCoordenacaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idCoordenacaoLabel.Name = "idCoordenacaoLabel";
            idCoordenacaoLabel.Size = new System.Drawing.Size(90, 16);
            idCoordenacaoLabel.TabIndex = 5;
            idCoordenacaoLabel.Text = "Coordenacao";
            // 
            // idProfessorLabel
            // 
            idProfessorLabel.AutoSize = true;
            idProfessorLabel.Location = new System.Drawing.Point(429, 217);
            idProfessorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idProfessorLabel.Name = "idProfessorLabel";
            idProfessorLabel.Size = new System.Drawing.Size(65, 16);
            idProfessorLabel.TabIndex = 7;
            idProfessorLabel.Text = "Professor";
            // 
            // motivoLabel
            // 
            motivoLabel.AutoSize = true;
            motivoLabel.Location = new System.Drawing.Point(14, 354);
            motivoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            motivoLabel.Name = "motivoLabel";
            motivoLabel.Size = new System.Drawing.Size(50, 16);
            motivoLabel.TabIndex = 9;
            motivoLabel.Text = "Motivo:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(11, 282);
            statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(47, 16);
            statusLabel.TabIndex = 11;
            statusLabel.Text = "Status:";
            // 
            // dataHoraSaidaDateTimePicker
            // 
            this.dataHoraSaidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.saidasAntecipadasBindingSource, "DataHoraSaida", true));
            this.dataHoraSaidaDateTimePicker.Location = new System.Drawing.Point(859, 306);
            this.dataHoraSaidaDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dataHoraSaidaDateTimePicker.Name = "dataHoraSaidaDateTimePicker";
            this.dataHoraSaidaDateTimePicker.Size = new System.Drawing.Size(348, 22);
            this.dataHoraSaidaDateTimePicker.TabIndex = 2;
            // 
            // saidasAntecipadasBindingSource
            // 
            this.saidasAntecipadasBindingSource.DataSource = typeof(Models.SaidasAntecipadas);
            // 
            // alunoTextBox
            // 
            this.alunoTextBox.Location = new System.Drawing.Point(11, 235);
            this.alunoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.alunoTextBox.Name = "alunoTextBox";
            this.alunoTextBox.Size = new System.Drawing.Size(405, 22);
            this.alunoTextBox.TabIndex = 4;
            // 
            // motivoTextBox
            // 
            this.motivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saidasAntecipadasBindingSource, "Motivo", true));
            this.motivoTextBox.Location = new System.Drawing.Point(11, 372);
            this.motivoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.motivoTextBox.Multiline = true;
            this.motivoTextBox.Name = "motivoTextBox";
            this.motivoTextBox.Size = new System.Drawing.Size(405, 89);
            this.motivoTextBox.TabIndex = 10;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSalvar.Location = new System.Drawing.Point(796, 486);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(146, 52);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelar.Location = new System.Drawing.Point(980, 486);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(146, 52);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonBuscarAluno
            // 
            this.buttonBuscarAluno.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBuscarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarAluno.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarAluno.Location = new System.Drawing.Point(322, 200);
            this.buttonBuscarAluno.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscarAluno.Name = "buttonBuscarAluno";
            this.buttonBuscarAluno.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscarAluno.TabIndex = 16;
            this.buttonBuscarAluno.Text = "&Buscar";
            this.buttonBuscarAluno.UseVisualStyleBackColor = false;
            this.buttonBuscarAluno.Click += new System.EventHandler(this.buttonBuscarAluno_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Em Análise",
            "Autorizada",
            "Negada"});
            this.comboBoxStatus.Location = new System.Drawing.Point(11, 302);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(283, 24);
            this.comboBoxStatus.TabIndex = 18;
            // 
            // comboBoxProfessor
            // 
            this.comboBoxProfessor.FormattingEnabled = true;
            this.comboBoxProfessor.Location = new System.Drawing.Point(432, 235);
            this.comboBoxProfessor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProfessor.Name = "comboBoxProfessor";
            this.comboBoxProfessor.Size = new System.Drawing.Size(405, 24);
            this.comboBoxProfessor.TabIndex = 20;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.saidasAntecipadasBindingSource;
            // 
            // comboBoxCoordenador
            // 
            this.comboBoxCoordenador.FormattingEnabled = true;
            this.comboBoxCoordenador.Location = new System.Drawing.Point(432, 306);
            this.comboBoxCoordenador.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCoordenador.Name = "comboBoxCoordenador";
            this.comboBoxCoordenador.Size = new System.Drawing.Size(405, 24);
            this.comboBoxCoordenador.TabIndex = 21;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panelBarraTitulo.Controls.Add(this.labelMenu);
            this.panelBarraTitulo.Controls.Add(this.buttonMinimizar);
            this.panelBarraTitulo.Controls.Add(this.buttonRestaurar);
            this.panelBarraTitulo.Controls.Add(this.buttonMaximizar);
            this.panelBarraTitulo.Controls.Add(this.buttonFechar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1300, 50);
            this.panelBarraTitulo.TabIndex = 22;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMenu.Location = new System.Drawing.Point(4, 10);
            this.labelMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(81, 31);
            this.labelMenu.TabIndex = 4;
            this.labelMenu.Text = "Menu";
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimizar.Enabled = false;
            this.buttonMinimizar.Image = global::UILGerenReservasLab.Properties.Resources.minimizar;
            this.buttonMinimizar.Location = new System.Drawing.Point(1145, 8);
            this.buttonMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(44, 35);
            this.buttonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMinimizar.TabIndex = 3;
            this.buttonMinimizar.TabStop = false;
            this.buttonMinimizar.Visible = false;
            // 
            // buttonRestaurar
            // 
            this.buttonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestaurar.Enabled = false;
            this.buttonRestaurar.Image = global::UILGerenReservasLab.Properties.Resources.res;
            this.buttonRestaurar.Location = new System.Drawing.Point(1196, 8);
            this.buttonRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRestaurar.Name = "buttonRestaurar";
            this.buttonRestaurar.Size = new System.Drawing.Size(44, 35);
            this.buttonRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonRestaurar.TabIndex = 2;
            this.buttonRestaurar.TabStop = false;
            this.buttonRestaurar.Visible = false;
            // 
            // buttonMaximizar
            // 
            this.buttonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaximizar.Enabled = false;
            this.buttonMaximizar.Image = global::UILGerenReservasLab.Properties.Resources.maxi;
            this.buttonMaximizar.Location = new System.Drawing.Point(1196, 8);
            this.buttonMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMaximizar.Name = "buttonMaximizar";
            this.buttonMaximizar.Size = new System.Drawing.Size(44, 35);
            this.buttonMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMaximizar.TabIndex = 1;
            this.buttonMaximizar.TabStop = false;
            this.buttonMaximizar.Visible = false;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFechar.Image = global::UILGerenReservasLab.Properties.Resources.fechar;
            this.buttonFechar.Location = new System.Drawing.Point(1248, 8);
            this.buttonFechar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(44, 35);
            this.buttonFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonFechar.TabIndex = 0;
            this.buttonFechar.TabStop = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormCadastroSaidasAntecipadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1300, 614);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.comboBoxCoordenador);
            this.Controls.Add(this.comboBoxProfessor);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonBuscarAluno);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(statusLabel);
            this.Controls.Add(motivoLabel);
            this.Controls.Add(this.motivoTextBox);
            this.Controls.Add(idProfessorLabel);
            this.Controls.Add(idCoordenacaoLabel);
            this.Controls.Add(idAlunoLabel);
            this.Controls.Add(this.alunoTextBox);
            this.Controls.Add(dataHoraSaidaLabel);
            this.Controls.Add(this.dataHoraSaidaDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCadastroSaidasAntecipadas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Saidas Antecipadas";
            this.Load += new System.EventHandler(this.FormCadastroSaidasAntecipadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saidasAntecipadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource saidasAntecipadasBindingSource;
        private System.Windows.Forms.DateTimePicker dataHoraSaidaDateTimePicker;
        private System.Windows.Forms.TextBox alunoTextBox;
        private System.Windows.Forms.TextBox motivoTextBox;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBuscarAluno;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxProfessor;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox comboBoxCoordenador;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.PictureBox buttonMinimizar;
        private System.Windows.Forms.PictureBox buttonRestaurar;
        private System.Windows.Forms.PictureBox buttonMaximizar;
        private System.Windows.Forms.PictureBox buttonFechar;
    }
}