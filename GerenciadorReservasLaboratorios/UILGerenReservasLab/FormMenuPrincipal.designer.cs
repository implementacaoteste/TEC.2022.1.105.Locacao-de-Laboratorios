namespace UILGerenReservasLab
{
    partial class FormMenuPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.labelReservasPendentes = new System.Windows.Forms.Label();
            this.reservaPanelDataGridView = new System.Windows.Forms.DataGridView();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelData = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelLogout = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.PictureBox();
            this.buttonUsuario = new System.Windows.Forms.Button();
            this.buttonSala = new System.Windows.Forms.Button();
            this.buttonPermissao = new System.Windows.Forms.Button();
            this.buttonSaidasAntecipadas = new System.Windows.Forms.Button();
            this.buttonReserva = new System.Windows.Forms.Button();
            this.buttonPredio = new System.Windows.Forms.Button();
            this.buttonGrupoUsuario = new System.Windows.Forms.Button();
            this.buttonDisciplina = new System.Windows.Forms.Button();
            this.buttonCurso = new System.Windows.Forms.Button();
            this.buttonAluno = new System.Windows.Forms.Button();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.ptbProfile = new System.Windows.Forms.PictureBox();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonMinimizar = new System.Windows.Forms.PictureBox();
            this.buttonRestaurar = new System.Windows.Forms.PictureBox();
            this.buttonMaximizar = new System.Windows.Forms.PictureBox();
            this.buttonFechar = new System.Windows.Forms.PictureBox();
            this.timerHoraData = new System.Windows.Forms.Timer(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeSolicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservaDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContainer.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaPanelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLogout)).BeginInit();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProfile)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContainer.Controls.Add(this.panelFormularios);
            this.panelContainer.Controls.Add(this.panelMenu);
            this.panelContainer.Controls.Add(this.panelBarraTitulo);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1600, 850);
            this.panelContainer.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.panelFormularios.Controls.Add(this.labelReservasPendentes);
            this.panelFormularios.Controls.Add(this.reservaPanelDataGridView);
            this.panelFormularios.Controls.Add(this.labelData);
            this.panelFormularios.Controls.Add(this.labelHora);
            this.panelFormularios.Controls.Add(this.pictureBoxLogo);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(300, 50);
            this.panelFormularios.Margin = new System.Windows.Forms.Padding(4);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1300, 800);
            this.panelFormularios.TabIndex = 2;
            // 
            // labelReservasPendentes
            // 
            this.labelReservasPendentes.AutoSize = true;
            this.labelReservasPendentes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservasPendentes.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelReservasPendentes.Location = new System.Drawing.Point(8, 70);
            this.labelReservasPendentes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReservasPendentes.Name = "labelReservasPendentes";
            this.labelReservasPendentes.Size = new System.Drawing.Size(367, 23);
            this.labelReservasPendentes.TabIndex = 41;
            this.labelReservasPendentes.Text = "Reservas pendentes de aprovação:";
            // 
            // reservaPanelDataGridView
            // 
            this.reservaPanelDataGridView.AllowUserToAddRows = false;
            this.reservaPanelDataGridView.AllowUserToDeleteRows = false;
            this.reservaPanelDataGridView.AllowUserToOrderColumns = true;
            this.reservaPanelDataGridView.AutoGenerateColumns = false;
            this.reservaPanelDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.reservaPanelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservaPanelDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.reservaPanelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservaPanelDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.reservaPanelDataGridView.ColumnHeadersHeight = 30;
            this.reservaPanelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.reservaPanelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.NomeSolicitante,
            this.NomeSala,
            this.reservaDataDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn});
            this.reservaPanelDataGridView.DataSource = this.reservaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reservaPanelDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.reservaPanelDataGridView.EnableHeadersVisualStyles = false;
            this.reservaPanelDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reservaPanelDataGridView.Location = new System.Drawing.Point(8, 100);
            this.reservaPanelDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.reservaPanelDataGridView.Name = "reservaPanelDataGridView";
            this.reservaPanelDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservaPanelDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.reservaPanelDataGridView.RowHeadersVisible = false;
            this.reservaPanelDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.reservaPanelDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.reservaPanelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservaPanelDataGridView.Size = new System.Drawing.Size(900, 370);
            this.reservaPanelDataGridView.TabIndex = 40;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // labelData
            // 
            this.labelData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.labelData.Location = new System.Drawing.Point(435, 689);
            this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(721, 51);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Segunda-feira, 07 agosto de  2023";
            // 
            // labelHora
            // 
            this.labelHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHora.AutoSize = true;
            this.labelHora.BackColor = System.Drawing.Color.Transparent;
            this.labelHora.Font = new System.Drawing.Font("Century Gothic", 80F);
            this.labelHora.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelHora.Location = new System.Drawing.Point(575, 528);
            this.labelHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(584, 161);
            this.labelHora.TabIndex = 1;
            this.labelHora.Text = "08:59:58";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::UILGerenReservasLab.Properties.Resources.logo_senai1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1025, 35);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(244, 182);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.panelMenu.Controls.Add(this.labelLogout);
            this.panelMenu.Controls.Add(this.buttonLogout);
            this.panelMenu.Controls.Add(this.buttonUsuario);
            this.panelMenu.Controls.Add(this.buttonSala);
            this.panelMenu.Controls.Add(this.buttonPermissao);
            this.panelMenu.Controls.Add(this.buttonSaidasAntecipadas);
            this.panelMenu.Controls.Add(this.buttonReserva);
            this.panelMenu.Controls.Add(this.buttonPredio);
            this.panelMenu.Controls.Add(this.buttonGrupoUsuario);
            this.panelMenu.Controls.Add(this.buttonDisciplina);
            this.panelMenu.Controls.Add(this.buttonCurso);
            this.panelMenu.Controls.Add(this.buttonAluno);
            this.panelMenu.Controls.Add(this.panelProfile);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 800);
            this.panelMenu.TabIndex = 1;
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLogout.Location = new System.Drawing.Point(91, 732);
            this.labelLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(77, 25);
            this.labelLogout.TabIndex = 19;
            this.labelLogout.Text = "Log out";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.Location = new System.Drawing.Point(15, 708);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(69, 75);
            this.buttonLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonLogout.TabIndex = 18;
            this.buttonLogout.TabStop = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.FlatAppearance.BorderSize = 0;
            this.buttonUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUsuario.Image = global::UILGerenReservasLab.Properties.Resources.calendar__1_1;
            this.buttonUsuario.Location = new System.Drawing.Point(0, 420);
            this.buttonUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Size = new System.Drawing.Size(300, 50);
            this.buttonUsuario.TabIndex = 17;
            this.buttonUsuario.Text = "Usuario";
            this.buttonUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUsuario.UseVisualStyleBackColor = true;
            this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
            // 
            // buttonSala
            // 
            this.buttonSala.FlatAppearance.BorderSize = 0;
            this.buttonSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSala.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSala.Location = new System.Drawing.Point(0, 362);
            this.buttonSala.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSala.Name = "buttonSala";
            this.buttonSala.Size = new System.Drawing.Size(300, 50);
            this.buttonSala.TabIndex = 16;
            this.buttonSala.Text = "Salas";
            this.buttonSala.UseVisualStyleBackColor = true;
            this.buttonSala.Click += new System.EventHandler(this.buttonSala_Click);
            // 
            // buttonPermissao
            // 
            this.buttonPermissao.FlatAppearance.BorderSize = 0;
            this.buttonPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPermissao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPermissao.Location = new System.Drawing.Point(0, 535);
            this.buttonPermissao.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPermissao.Name = "buttonPermissao";
            this.buttonPermissao.Size = new System.Drawing.Size(300, 50);
            this.buttonPermissao.TabIndex = 12;
            this.buttonPermissao.Text = "Permissões";
            this.buttonPermissao.UseVisualStyleBackColor = true;
            this.buttonPermissao.Click += new System.EventHandler(this.buttonPermissao_Click);
            // 
            // buttonSaidasAntecipadas
            // 
            this.buttonSaidasAntecipadas.FlatAppearance.BorderSize = 0;
            this.buttonSaidasAntecipadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaidasAntecipadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaidasAntecipadas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaidasAntecipadas.Location = new System.Drawing.Point(0, 650);
            this.buttonSaidasAntecipadas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaidasAntecipadas.Name = "buttonSaidasAntecipadas";
            this.buttonSaidasAntecipadas.Size = new System.Drawing.Size(300, 50);
            this.buttonSaidasAntecipadas.TabIndex = 15;
            this.buttonSaidasAntecipadas.Text = "Saídas Antecipadas";
            this.buttonSaidasAntecipadas.UseVisualStyleBackColor = true;
            this.buttonSaidasAntecipadas.Click += new System.EventHandler(this.buttonSaidasAntecipadas_Click);
            // 
            // buttonReserva
            // 
            this.buttonReserva.FlatAppearance.BorderSize = 0;
            this.buttonReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReserva.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReserva.Image = global::UILGerenReservasLab.Properties.Resources.calendar__1_1;
            this.buttonReserva.Location = new System.Drawing.Point(0, 132);
            this.buttonReserva.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReserva.Name = "buttonReserva";
            this.buttonReserva.Size = new System.Drawing.Size(300, 50);
            this.buttonReserva.TabIndex = 14;
            this.buttonReserva.Text = "Reservas";
            this.buttonReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReserva.UseVisualStyleBackColor = true;
            this.buttonReserva.Click += new System.EventHandler(this.buttonReserva_Click);
            // 
            // buttonPredio
            // 
            this.buttonPredio.FlatAppearance.BorderSize = 0;
            this.buttonPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPredio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPredio.Location = new System.Drawing.Point(-4, 305);
            this.buttonPredio.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPredio.Name = "buttonPredio";
            this.buttonPredio.Size = new System.Drawing.Size(300, 50);
            this.buttonPredio.TabIndex = 13;
            this.buttonPredio.Text = "Predios";
            this.buttonPredio.UseVisualStyleBackColor = true;
            this.buttonPredio.Click += new System.EventHandler(this.buttonPredio_Click);
            // 
            // buttonGrupoUsuario
            // 
            this.buttonGrupoUsuario.FlatAppearance.BorderSize = 0;
            this.buttonGrupoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrupoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrupoUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGrupoUsuario.Location = new System.Drawing.Point(0, 478);
            this.buttonGrupoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGrupoUsuario.Name = "buttonGrupoUsuario";
            this.buttonGrupoUsuario.Size = new System.Drawing.Size(300, 50);
            this.buttonGrupoUsuario.TabIndex = 11;
            this.buttonGrupoUsuario.Text = "Grupos de Usuário";
            this.buttonGrupoUsuario.UseVisualStyleBackColor = true;
            this.buttonGrupoUsuario.Click += new System.EventHandler(this.buttonGrupoUsuario_Click);
            // 
            // buttonDisciplina
            // 
            this.buttonDisciplina.FlatAppearance.BorderSize = 0;
            this.buttonDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisciplina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDisciplina.Location = new System.Drawing.Point(0, 248);
            this.buttonDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDisciplina.Name = "buttonDisciplina";
            this.buttonDisciplina.Size = new System.Drawing.Size(300, 50);
            this.buttonDisciplina.TabIndex = 10;
            this.buttonDisciplina.Text = "Disciplina";
            this.buttonDisciplina.UseVisualStyleBackColor = true;
            this.buttonDisciplina.Click += new System.EventHandler(this.buttonDisciplina_Click);
            // 
            // buttonCurso
            // 
            this.buttonCurso.FlatAppearance.BorderSize = 0;
            this.buttonCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCurso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCurso.Location = new System.Drawing.Point(0, 190);
            this.buttonCurso.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCurso.Name = "buttonCurso";
            this.buttonCurso.Size = new System.Drawing.Size(300, 50);
            this.buttonCurso.TabIndex = 4;
            this.buttonCurso.Text = "Curso";
            this.buttonCurso.UseVisualStyleBackColor = true;
            this.buttonCurso.Click += new System.EventHandler(this.buttonCurso_Click);
            // 
            // buttonAluno
            // 
            this.buttonAluno.FlatAppearance.BorderSize = 0;
            this.buttonAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAluno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAluno.Location = new System.Drawing.Point(0, 592);
            this.buttonAluno.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAluno.Name = "buttonAluno";
            this.buttonAluno.Size = new System.Drawing.Size(300, 50);
            this.buttonAluno.TabIndex = 3;
            this.buttonAluno.Text = "Aluno";
            this.buttonAluno.UseVisualStyleBackColor = true;
            this.buttonAluno.Click += new System.EventHandler(this.buttonAluno_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.ptbProfile);
            this.panelProfile.Controls.Add(this.labelCargo);
            this.panelProfile.Controls.Add(this.labelMatricula);
            this.panelProfile.Controls.Add(this.labelUserName);
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Margin = new System.Windows.Forms.Padding(4);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(300, 125);
            this.panelProfile.TabIndex = 0;
            // 
            // ptbProfile
            // 
            this.ptbProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbProfile.Image = ((System.Drawing.Image)(resources.GetObject("ptbProfile.Image")));
            this.ptbProfile.Location = new System.Drawing.Point(15, 8);
            this.ptbProfile.Margin = new System.Windows.Forms.Padding(4);
            this.ptbProfile.Name = "ptbProfile";
            this.ptbProfile.Size = new System.Drawing.Size(76, 74);
            this.ptbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProfile.TabIndex = 11;
            this.ptbProfile.TabStop = false;
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargo.ForeColor = System.Drawing.Color.Silver;
            this.labelCargo.Location = new System.Drawing.Point(99, 4);
            this.labelCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(49, 18);
            this.labelCargo.TabIndex = 14;
            this.labelCargo.Text = "Cargo";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricula.ForeColor = System.Drawing.Color.Silver;
            this.labelMatricula.Location = new System.Drawing.Point(99, 62);
            this.labelMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(68, 18);
            this.labelMatricula.TabIndex = 13;
            this.labelMatricula.Text = "Matrícula";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUserName.Location = new System.Drawing.Point(99, 35);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(101, 18);
            this.labelUserName.TabIndex = 12;
            this.labelUserName.Text = "NomeUsuario";
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panelBarraTitulo.Controls.Add(this.labelTitle);
            this.panelBarraTitulo.Controls.Add(this.buttonMinimizar);
            this.panelBarraTitulo.Controls.Add(this.buttonRestaurar);
            this.panelBarraTitulo.Controls.Add(this.buttonMaximizar);
            this.panelBarraTitulo.Controls.Add(this.buttonFechar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1600, 50);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Location = new System.Drawing.Point(4, 10);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(192, 31);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Menu Principal";
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimizar.Image = global::UILGerenReservasLab.Properties.Resources.minimizar;
            this.buttonMinimizar.Location = new System.Drawing.Point(1445, 8);
            this.buttonMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(44, 35);
            this.buttonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMinimizar.TabIndex = 3;
            this.buttonMinimizar.TabStop = false;
            this.buttonMinimizar.Click += new System.EventHandler(this.buttonMinimizar_Click);
            // 
            // buttonRestaurar
            // 
            this.buttonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestaurar.Image = global::UILGerenReservasLab.Properties.Resources.res;
            this.buttonRestaurar.Location = new System.Drawing.Point(1496, 8);
            this.buttonRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRestaurar.Name = "buttonRestaurar";
            this.buttonRestaurar.Size = new System.Drawing.Size(44, 35);
            this.buttonRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonRestaurar.TabIndex = 2;
            this.buttonRestaurar.TabStop = false;
            this.buttonRestaurar.Visible = false;
            this.buttonRestaurar.Click += new System.EventHandler(this.buttonRestaurar_Click);
            // 
            // buttonMaximizar
            // 
            this.buttonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaximizar.Image = global::UILGerenReservasLab.Properties.Resources.maxi;
            this.buttonMaximizar.Location = new System.Drawing.Point(1496, 8);
            this.buttonMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMaximizar.Name = "buttonMaximizar";
            this.buttonMaximizar.Size = new System.Drawing.Size(44, 35);
            this.buttonMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMaximizar.TabIndex = 1;
            this.buttonMaximizar.TabStop = false;
            this.buttonMaximizar.Click += new System.EventHandler(this.buttonMaximizar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFechar.Image = global::UILGerenReservasLab.Properties.Resources.fechar;
            this.buttonFechar.Location = new System.Drawing.Point(1548, 8);
            this.buttonFechar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(44, 35);
            this.buttonFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonFechar.TabIndex = 0;
            this.buttonFechar.TabStop = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // timerHoraData
            // 
            this.timerHoraData.Enabled = true;
            this.timerHoraData.Tick += new System.EventHandler(this.timerHoraData_Tick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 187.353F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // NomeSolicitante
            // 
            this.NomeSolicitante.DataPropertyName = "NomeSolicitante";
            this.NomeSolicitante.FillWeight = 76.9962F;
            this.NomeSolicitante.HeaderText = "Solicitante";
            this.NomeSolicitante.MinimumWidth = 6;
            this.NomeSolicitante.Name = "NomeSolicitante";
            this.NomeSolicitante.ReadOnly = true;
            this.NomeSolicitante.Width = 200;
            // 
            // NomeSala
            // 
            this.NomeSala.DataPropertyName = "NomeSala";
            this.NomeSala.HeaderText = "Sala";
            this.NomeSala.MinimumWidth = 6;
            this.NomeSala.Name = "NomeSala";
            this.NomeSala.ReadOnly = true;
            this.NomeSala.Width = 125;
            // 
            // reservaDataDataGridViewTextBoxColumn
            // 
            this.reservaDataDataGridViewTextBoxColumn.DataPropertyName = "ReservaData";
            this.reservaDataDataGridViewTextBoxColumn.FillWeight = 122.9549F;
            this.reservaDataDataGridViewTextBoxColumn.HeaderText = "Data reservada";
            this.reservaDataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservaDataDataGridViewTextBoxColumn.Name = "reservaDataDataGridViewTextBoxColumn";
            this.reservaDataDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservaDataDataGridViewTextBoxColumn.Width = 180;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.FillWeight = 116.6184F;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 135;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.FillWeight = 197.6373F;
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.turnoDataGridViewTextBoxColumn.Width = 200;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1600, 850);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1600, 850);
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaPanelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLogout)).EndInit();
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProfile)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox buttonFechar;
        private System.Windows.Forms.PictureBox buttonMaximizar;
        private System.Windows.Forms.PictureBox buttonRestaurar;
        private System.Windows.Forms.PictureBox buttonMinimizar;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Button buttonAluno;
        private System.Windows.Forms.Button buttonCurso;
        private System.Windows.Forms.Button buttonSaidasAntecipadas;
        private System.Windows.Forms.Button buttonReserva;
        private System.Windows.Forms.Button buttonPredio;
        private System.Windows.Forms.Button buttonPermissao;
        private System.Windows.Forms.Button buttonGrupoUsuario;
        private System.Windows.Forms.Button buttonDisciplina;
        private System.Windows.Forms.Button buttonSala;
        private System.Windows.Forms.Button buttonUsuario;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timerHoraData;
        private System.Windows.Forms.Label labelReservasPendentes;
        private System.Windows.Forms.DataGridView reservaPanelDataGridView;
        internal System.Windows.Forms.PictureBox ptbProfile;
        internal System.Windows.Forms.Label labelCargo;
        internal System.Windows.Forms.Label labelMatricula;
        internal System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.PictureBox buttonLogout;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeSolicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservaDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
    }
}