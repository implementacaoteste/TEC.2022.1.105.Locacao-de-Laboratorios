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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.labelData = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonPermissao = new System.Windows.Forms.Button();
            this.buttonGrupoUsuario = new System.Windows.Forms.Button();
            this.buttonUsuario = new System.Windows.Forms.Button();
            this.buttonSala = new System.Windows.Forms.Button();
            this.buttonPredio = new System.Windows.Forms.Button();
            this.buttonDisciplina = new System.Windows.Forms.Button();
            this.buttonCurso = new System.Windows.Forms.Button();
            this.buttonSaidasAntecipadas = new System.Windows.Forms.Button();
            this.buttonAluno = new System.Windows.Forms.Button();
            this.buttonReserva = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelContainer.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProfile)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
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
            this.panelContainer.Size = new System.Drawing.Size(1500, 850);
            this.panelContainer.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.panelFormularios.Controls.Add(this.labelData);
            this.panelFormularios.Controls.Add(this.labelHora);
            this.panelFormularios.Controls.Add(this.pictureBoxLogo);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(300, 50);
            this.panelFormularios.Margin = new System.Windows.Forms.Padding(4);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1200, 800);
            this.panelFormularios.TabIndex = 2;
            // 
            // labelData
            // 
            this.labelData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.labelData.Location = new System.Drawing.Point(224, 662);
            this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(721, 51);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Segunda-feira, 07 agosto de  2023";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHora
            // 
            this.labelHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHora.AutoSize = true;
            this.labelHora.BackColor = System.Drawing.Color.Transparent;
            this.labelHora.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelHora.Location = new System.Drawing.Point(328, 502);
            this.labelHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(509, 159);
            this.labelHora.TabIndex = 1;
            this.labelHora.Text = "08:59:58";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::UILGerenReservasLab.Properties.Resources.logo_sisglab;
            this.pictureBoxLogo.Location = new System.Drawing.Point(232, 12);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(694, 462);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.panelMenu.Controls.Add(this.buttonPermissao);
            this.panelMenu.Controls.Add(this.buttonGrupoUsuario);
            this.panelMenu.Controls.Add(this.buttonUsuario);
            this.panelMenu.Controls.Add(this.buttonSala);
            this.panelMenu.Controls.Add(this.buttonPredio);
            this.panelMenu.Controls.Add(this.buttonDisciplina);
            this.panelMenu.Controls.Add(this.buttonCurso);
            this.panelMenu.Controls.Add(this.buttonSaidasAntecipadas);
            this.panelMenu.Controls.Add(this.buttonAluno);
            this.panelMenu.Controls.Add(this.buttonReserva);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Controls.Add(this.buttonLogout);
            this.panelMenu.Controls.Add(this.panelProfile);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 800);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonPermissao
            // 
            this.buttonPermissao.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPermissao.FlatAppearance.BorderSize = 0;
            this.buttonPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPermissao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPermissao.Image = global::UILGerenReservasLab.Properties.Resources.user_permission;
            this.buttonPermissao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPermissao.Location = new System.Drawing.Point(0, 615);
            this.buttonPermissao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPermissao.Name = "buttonPermissao";
            this.buttonPermissao.Size = new System.Drawing.Size(300, 50);
            this.buttonPermissao.TabIndex = 9;
            this.buttonPermissao.Text = "Permissões";
            this.buttonPermissao.UseVisualStyleBackColor = true;
            this.buttonPermissao.Click += new System.EventHandler(this.buttonPermissao_Click);
            // 
            // buttonGrupoUsuario
            // 
            this.buttonGrupoUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGrupoUsuario.FlatAppearance.BorderSize = 0;
            this.buttonGrupoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrupoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrupoUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGrupoUsuario.Image = global::UILGerenReservasLab.Properties.Resources.usuarios;
            this.buttonGrupoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGrupoUsuario.Location = new System.Drawing.Point(0, 565);
            this.buttonGrupoUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonGrupoUsuario.Name = "buttonGrupoUsuario";
            this.buttonGrupoUsuario.Size = new System.Drawing.Size(300, 50);
            this.buttonGrupoUsuario.TabIndex = 11;
            this.buttonGrupoUsuario.Text = "Grupos de Usuário";
            this.buttonGrupoUsuario.UseVisualStyleBackColor = true;
            this.buttonGrupoUsuario.Click += new System.EventHandler(this.buttonGrupoUsuario_Click);
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUsuario.FlatAppearance.BorderSize = 0;
            this.buttonUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUsuario.Image = global::UILGerenReservasLab.Properties.Resources.usuario;
            this.buttonUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsuario.Location = new System.Drawing.Point(0, 515);
            this.buttonUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Size = new System.Drawing.Size(300, 50);
            this.buttonUsuario.TabIndex = 8;
            this.buttonUsuario.Text = "Usuario";
            this.buttonUsuario.UseVisualStyleBackColor = true;
            this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
            // 
            // buttonSala
            // 
            this.buttonSala.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSala.FlatAppearance.BorderSize = 0;
            this.buttonSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSala.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSala.Image = global::UILGerenReservasLab.Properties.Resources.classroom2_ico;
            this.buttonSala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSala.Location = new System.Drawing.Point(0, 465);
            this.buttonSala.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSala.Name = "buttonSala";
            this.buttonSala.Size = new System.Drawing.Size(300, 50);
            this.buttonSala.TabIndex = 7;
            this.buttonSala.Text = "Salas";
            this.buttonSala.UseVisualStyleBackColor = true;
            this.buttonSala.Click += new System.EventHandler(this.buttonSala_Click);
            // 
            // buttonPredio
            // 
            this.buttonPredio.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPredio.FlatAppearance.BorderSize = 0;
            this.buttonPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPredio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPredio.Image = global::UILGerenReservasLab.Properties.Resources.predio01_ico;
            this.buttonPredio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPredio.Location = new System.Drawing.Point(0, 415);
            this.buttonPredio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPredio.Name = "buttonPredio";
            this.buttonPredio.Size = new System.Drawing.Size(300, 50);
            this.buttonPredio.TabIndex = 6;
            this.buttonPredio.Text = "Predios";
            this.buttonPredio.UseVisualStyleBackColor = true;
            this.buttonPredio.Click += new System.EventHandler(this.buttonPredio_Click);
            // 
            // buttonDisciplina
            // 
            this.buttonDisciplina.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDisciplina.FlatAppearance.BorderSize = 0;
            this.buttonDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisciplina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDisciplina.Image = global::UILGerenReservasLab.Properties.Resources.Disciplina_ico;
            this.buttonDisciplina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDisciplina.Location = new System.Drawing.Point(0, 365);
            this.buttonDisciplina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDisciplina.Name = "buttonDisciplina";
            this.buttonDisciplina.Size = new System.Drawing.Size(300, 50);
            this.buttonDisciplina.TabIndex = 5;
            this.buttonDisciplina.Text = "Disciplina";
            this.buttonDisciplina.UseVisualStyleBackColor = true;
            this.buttonDisciplina.Click += new System.EventHandler(this.buttonDisciplina_Click);
            // 
            // buttonCurso
            // 
            this.buttonCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCurso.FlatAppearance.BorderSize = 0;
            this.buttonCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCurso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCurso.Image = global::UILGerenReservasLab.Properties.Resources.cursos1;
            this.buttonCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCurso.Location = new System.Drawing.Point(0, 315);
            this.buttonCurso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonCurso.Name = "buttonCurso";
            this.buttonCurso.Size = new System.Drawing.Size(300, 50);
            this.buttonCurso.TabIndex = 4;
            this.buttonCurso.Text = "Curso";
            this.buttonCurso.UseVisualStyleBackColor = true;
            this.buttonCurso.Click += new System.EventHandler(this.buttonCurso_Click);
            // 
            // buttonSaidasAntecipadas
            // 
            this.buttonSaidasAntecipadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSaidasAntecipadas.FlatAppearance.BorderSize = 0;
            this.buttonSaidasAntecipadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaidasAntecipadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaidasAntecipadas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaidasAntecipadas.Image = global::UILGerenReservasLab.Properties.Resources.saida_01;
            this.buttonSaidasAntecipadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaidasAntecipadas.Location = new System.Drawing.Point(0, 265);
            this.buttonSaidasAntecipadas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSaidasAntecipadas.Name = "buttonSaidasAntecipadas";
            this.buttonSaidasAntecipadas.Size = new System.Drawing.Size(300, 50);
            this.buttonSaidasAntecipadas.TabIndex = 3;
            this.buttonSaidasAntecipadas.Text = "Saídas Antecipadas";
            this.buttonSaidasAntecipadas.UseVisualStyleBackColor = true;
            this.buttonSaidasAntecipadas.Click += new System.EventHandler(this.buttonSaidasAntecipadas_Click);
            // 
            // buttonAluno
            // 
            this.buttonAluno.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAluno.FlatAppearance.BorderSize = 0;
            this.buttonAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAluno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAluno.Image = global::UILGerenReservasLab.Properties.Resources.estudante;
            this.buttonAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAluno.Location = new System.Drawing.Point(0, 215);
            this.buttonAluno.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAluno.Name = "buttonAluno";
            this.buttonAluno.Size = new System.Drawing.Size(300, 50);
            this.buttonAluno.TabIndex = 1;
            this.buttonAluno.Text = "Aluno";
            this.buttonAluno.UseVisualStyleBackColor = true;
            this.buttonAluno.Click += new System.EventHandler(this.buttonAluno_Click);
            // 
            // buttonReserva
            // 
            this.buttonReserva.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReserva.FlatAppearance.BorderSize = 0;
            this.buttonReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReserva.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReserva.Image = global::UILGerenReservasLab.Properties.Resources.calendar_ico;
            this.buttonReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReserva.Location = new System.Drawing.Point(0, 165);
            this.buttonReserva.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonReserva.Name = "buttonReserva";
            this.buttonReserva.Size = new System.Drawing.Size(300, 50);
            this.buttonReserva.TabIndex = 2;
            this.buttonReserva.Text = "Reservas";
            this.buttonReserva.UseVisualStyleBackColor = true;
            this.buttonReserva.Click += new System.EventHandler(this.buttonReserva_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHome.Image = global::UILGerenReservasLab.Properties.Resources.Dashboard;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 115);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(300, 50);
            this.buttonHome.TabIndex = 31;
            this.buttonHome.Text = "Dashboard";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogout.Image = global::UILGerenReservasLab.Properties.Resources.logoutx1;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, 718);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(300, 50);
            this.buttonLogout.TabIndex = 15;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.ptbProfile);
            this.panelProfile.Controls.Add(this.labelCargo);
            this.panelProfile.Controls.Add(this.labelMatricula);
            this.panelProfile.Controls.Add(this.labelUserName);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Margin = new System.Windows.Forms.Padding(4);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(300, 115);
            this.panelProfile.TabIndex = 30;
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
            this.panelBarraTitulo.Size = new System.Drawing.Size(1500, 50);
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
            this.buttonMinimizar.Location = new System.Drawing.Point(1345, 8);
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
            this.buttonRestaurar.Location = new System.Drawing.Point(1396, 8);
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
            this.buttonMaximizar.Location = new System.Drawing.Point(1396, 8);
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
            this.buttonFechar.Location = new System.Drawing.Point(1448, 8);
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
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSaidasAntecipadas_Click);
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1500, 850);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProfile)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
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
        internal System.Windows.Forms.PictureBox ptbProfile;
        internal System.Windows.Forms.Label labelCargo;
        internal System.Windows.Forms.Label labelMatricula;
        internal System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonHome;
    }
}