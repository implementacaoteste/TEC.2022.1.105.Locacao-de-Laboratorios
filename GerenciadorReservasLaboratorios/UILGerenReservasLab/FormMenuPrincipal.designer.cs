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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.labelReservasPendentes = new System.Windows.Forms.Label();
            this.TablaProductos = new System.Windows.Forms.DataGridView();
            this.labelData = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMinimizar = new System.Windows.Forms.PictureBox();
            this.buttonRestaurar = new System.Windows.Forms.PictureBox();
            this.buttonMaximizar = new System.Windows.Forms.PictureBox();
            this.buttonFechar = new System.Windows.Forms.PictureBox();
            this.timerHoraData = new System.Windows.Forms.Timer(this.components);
            this.ptbProfile = new System.Windows.Forms.PictureBox();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProfile)).BeginInit();
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
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1280, 680);
            this.panelContainer.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.SystemColors.Control;
            this.panelFormularios.Controls.Add(this.labelReservasPendentes);
            this.panelFormularios.Controls.Add(this.TablaProductos);
            this.panelFormularios.Controls.Add(this.labelData);
            this.panelFormularios.Controls.Add(this.labelHora);
            this.panelFormularios.Controls.Add(this.pictureBox1);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(240, 40);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1040, 640);
            this.panelFormularios.TabIndex = 2;
            // 
            // labelReservasPendentes
            // 
            this.labelReservasPendentes.AutoSize = true;
            this.labelReservasPendentes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservasPendentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelReservasPendentes.Location = new System.Drawing.Point(6, 56);
            this.labelReservasPendentes.Name = "labelReservasPendentes";
            this.labelReservasPendentes.Size = new System.Drawing.Size(289, 21);
            this.labelReservasPendentes.TabIndex = 41;
            this.labelReservasPendentes.Text = "Reservas pendentes de aprovação:";
            // 
            // TablaProductos
            // 
            this.TablaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaProductos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.TablaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TablaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaProductos.ColumnHeadersHeight = 30;
            this.TablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablaProductos.EnableHeadersVisualStyles = false;
            this.TablaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TablaProductos.Location = new System.Drawing.Point(6, 80);
            this.TablaProductos.Name = "TablaProductos";
            this.TablaProductos.RowHeadersVisible = false;
            this.TablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaProductos.Size = new System.Drawing.Size(464, 330);
            this.TablaProductos.TabIndex = 40;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.labelData.Location = new System.Drawing.Point(348, 551);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(579, 40);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Segunda-feira, 07 agosto de  2023";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.BackColor = System.Drawing.Color.Transparent;
            this.labelHora.Font = new System.Drawing.Font("Century Gothic", 80F);
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelHora.Location = new System.Drawing.Point(460, 422);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(467, 129);
            this.labelHora.TabIndex = 1;
            this.labelHora.Text = "08:59:58";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UILGerenReservasLab.Properties.Resources.logo_senai1;
            this.pictureBox1.Location = new System.Drawing.Point(553, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
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
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 640);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.FlatAppearance.BorderSize = 0;
            this.buttonUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUsuario.Location = new System.Drawing.Point(0, 336);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Size = new System.Drawing.Size(240, 40);
            this.buttonUsuario.TabIndex = 17;
            this.buttonUsuario.Text = "Usuario";
            this.buttonUsuario.UseVisualStyleBackColor = true;
            this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
            // 
            // buttonSala
            // 
            this.buttonSala.FlatAppearance.BorderSize = 0;
            this.buttonSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSala.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSala.Location = new System.Drawing.Point(0, 290);
            this.buttonSala.Name = "buttonSala";
            this.buttonSala.Size = new System.Drawing.Size(240, 40);
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
            this.buttonPermissao.Location = new System.Drawing.Point(0, 428);
            this.buttonPermissao.Name = "buttonPermissao";
            this.buttonPermissao.Size = new System.Drawing.Size(240, 40);
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
            this.buttonSaidasAntecipadas.Location = new System.Drawing.Point(0, 520);
            this.buttonSaidasAntecipadas.Name = "buttonSaidasAntecipadas";
            this.buttonSaidasAntecipadas.Size = new System.Drawing.Size(240, 40);
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
            this.buttonReserva.Location = new System.Drawing.Point(0, 106);
            this.buttonReserva.Name = "buttonReserva";
            this.buttonReserva.Size = new System.Drawing.Size(240, 40);
            this.buttonReserva.TabIndex = 14;
            this.buttonReserva.Text = "Reservas";
            this.buttonReserva.UseVisualStyleBackColor = true;
            this.buttonReserva.Click += new System.EventHandler(this.buttonReserva_Click);
            // 
            // buttonPredio
            // 
            this.buttonPredio.FlatAppearance.BorderSize = 0;
            this.buttonPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPredio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPredio.Location = new System.Drawing.Point(-3, 244);
            this.buttonPredio.Name = "buttonPredio";
            this.buttonPredio.Size = new System.Drawing.Size(240, 40);
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
            this.buttonGrupoUsuario.Location = new System.Drawing.Point(0, 382);
            this.buttonGrupoUsuario.Name = "buttonGrupoUsuario";
            this.buttonGrupoUsuario.Size = new System.Drawing.Size(240, 40);
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
            this.buttonDisciplina.Location = new System.Drawing.Point(0, 198);
            this.buttonDisciplina.Name = "buttonDisciplina";
            this.buttonDisciplina.Size = new System.Drawing.Size(240, 40);
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
            this.buttonCurso.Location = new System.Drawing.Point(0, 152);
            this.buttonCurso.Name = "buttonCurso";
            this.buttonCurso.Size = new System.Drawing.Size(240, 40);
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
            this.buttonAluno.Location = new System.Drawing.Point(0, 474);
            this.buttonAluno.Name = "buttonAluno";
            this.buttonAluno.Size = new System.Drawing.Size(240, 40);
            this.buttonAluno.TabIndex = 3;
            this.buttonAluno.Text = "Aluno";
            this.buttonAluno.UseVisualStyleBackColor = true;
            this.buttonAluno.Click += new System.EventHandler(this.buttonAluno_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbProfile);
            this.panel1.Controls.Add(this.labelCargo);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.labelUserName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 100);
            this.panel1.TabIndex = 0;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panelBarraTitulo.Controls.Add(this.label1);
            this.panelBarraTitulo.Controls.Add(this.buttonMinimizar);
            this.panelBarraTitulo.Controls.Add(this.buttonRestaurar);
            this.panelBarraTitulo.Controls.Add(this.buttonMaximizar);
            this.panelBarraTitulo.Controls.Add(this.buttonFechar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1280, 40);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu Principal";
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimizar.Image = global::UILGerenReservasLab.Properties.Resources.minimizar;
            this.buttonMinimizar.Location = new System.Drawing.Point(1156, 6);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(35, 28);
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
            this.buttonRestaurar.Location = new System.Drawing.Point(1197, 6);
            this.buttonRestaurar.Name = "buttonRestaurar";
            this.buttonRestaurar.Size = new System.Drawing.Size(35, 28);
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
            this.buttonMaximizar.Location = new System.Drawing.Point(1197, 6);
            this.buttonMaximizar.Name = "buttonMaximizar";
            this.buttonMaximizar.Size = new System.Drawing.Size(35, 28);
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
            this.buttonFechar.Location = new System.Drawing.Point(1238, 6);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(35, 28);
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
            // ptbProfile
            // 
            this.ptbProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbProfile.Image = ((System.Drawing.Image)(resources.GetObject("ptbProfile.Image")));
            this.ptbProfile.Location = new System.Drawing.Point(16, 18);
            this.ptbProfile.Name = "ptbProfile";
            this.ptbProfile.Size = new System.Drawing.Size(64, 64);
            this.ptbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbProfile.TabIndex = 11;
            this.ptbProfile.TabStop = false;
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargo.ForeColor = System.Drawing.Color.Silver;
            this.labelCargo.Location = new System.Drawing.Point(82, 62);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(46, 17);
            this.labelCargo.TabIndex = 14;
            this.labelCargo.Text = "Cargo";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Silver;
            this.labelEmail.Location = new System.Drawing.Point(82, 40);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUserName.Location = new System.Drawing.Point(82, 18);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(94, 17);
            this.labelUserName.TabIndex = 12;
            this.labelUserName.Text = "NomeUsuario";
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1280, 680);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.panelContainer.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProfile)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timerHoraData;
        private System.Windows.Forms.Label labelReservasPendentes;
        private System.Windows.Forms.DataGridView TablaProductos;
        internal System.Windows.Forms.PictureBox ptbProfile;
        internal System.Windows.Forms.Label labelCargo;
        internal System.Windows.Forms.Label labelEmail;
        internal System.Windows.Forms.Label labelUserName;
    }
}