namespace UILGerenReservasLab
{
    partial class FormCadastroAluno
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label emailLabel;
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonMinimizar = new System.Windows.Forms.PictureBox();
            this.buttonRestaurar = new System.Windows.Forms.PictureBox();
            this.buttonMaximizar = new System.Windows.Forms.PictureBox();
            this.buttonFechar = new System.Windows.Forms.PictureBox();
            this.pictureBoxAluno = new CodeeloUI.Controls.CodeeloPictureBox();
            this.buttonAdicionarFoto = new CodeeloUI.Controls.CodeeloButton();
            this.buttonSalvar = new CodeeloUI.Controls.CodeeloButton();
            this.buttonCancelar = new CodeeloUI.Controls.CodeeloButton();
            nomeLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.ForeColor = System.Drawing.Color.White;
            nomeLabel.Location = new System.Drawing.Point(88, 88);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(35, 13);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.ForeColor = System.Drawing.Color.White;
            matriculaLabel.Location = new System.Drawing.Point(91, 210);
            matriculaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(50, 13);
            matriculaLabel.TabIndex = 3;
            matriculaLabel.Text = "Matricula";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = System.Drawing.Color.White;
            emailLabel.Location = new System.Drawing.Point(91, 147);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(91, 112);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(437, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(Models.Aluno);
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(94, 234);
            this.matriculaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(168, 20);
            this.matriculaTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(94, 177);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(434, 20);
            this.emailTextBox.TabIndex = 6;
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
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1040, 40);
            this.panelBarraTitulo.TabIndex = 23;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMenu.Location = new System.Drawing.Point(3, 8);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(66, 25);
            this.labelMenu.TabIndex = 4;
            this.labelMenu.Text = "Menu";
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimizar.Enabled = false;
            this.buttonMinimizar.Image = global::UILGerenReservasLab.Properties.Resources.minimizar;
            this.buttonMinimizar.Location = new System.Drawing.Point(916, 6);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(35, 28);
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
            this.buttonRestaurar.Location = new System.Drawing.Point(957, 6);
            this.buttonRestaurar.Name = "buttonRestaurar";
            this.buttonRestaurar.Size = new System.Drawing.Size(35, 28);
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
            this.buttonMaximizar.Location = new System.Drawing.Point(957, 6);
            this.buttonMaximizar.Name = "buttonMaximizar";
            this.buttonMaximizar.Size = new System.Drawing.Size(35, 28);
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
            this.buttonFechar.Location = new System.Drawing.Point(998, 6);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(35, 28);
            this.buttonFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonFechar.TabIndex = 0;
            this.buttonFechar.TabStop = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // pictureBoxAluno
            // 
            this.pictureBoxAluno.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBoxAluno.BorderColorFirst = System.Drawing.Color.RoyalBlue;
            this.pictureBoxAluno.BorderColorSecond = System.Drawing.Color.HotPink;
            this.pictureBoxAluno.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureBoxAluno.BorderSize = 2;
            this.pictureBoxAluno.DrawBorder = false;
            this.pictureBoxAluno.DrawBorderInside = false;
            this.pictureBoxAluno.DrawCircle = false;
            this.pictureBoxAluno.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.pictureBoxAluno.Location = new System.Drawing.Point(779, 112);
            this.pictureBoxAluno.Name = "pictureBoxAluno";
            this.pictureBoxAluno.Size = new System.Drawing.Size(147, 142);
            this.pictureBoxAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAluno.TabIndex = 26;
            this.pictureBoxAluno.TabStop = false;
            this.pictureBoxAluno.UseGradient = false;
            // 
            // buttonAdicionarFoto
            // 
            this.buttonAdicionarFoto.AccessibleRole = null;
            this.buttonAdicionarFoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdicionarFoto.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdicionarFoto.BorderColor_1 = System.Drawing.Color.Transparent;
            this.buttonAdicionarFoto.BorderColor_2 = System.Drawing.Color.Transparent;
            this.buttonAdicionarFoto.BorderRadius = 20;
            this.buttonAdicionarFoto.BorderSize = 3;
            this.buttonAdicionarFoto.CausesValidation = false;
            this.buttonAdicionarFoto.ColorFill_1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonAdicionarFoto.ColorFill_2 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(189)))));
            this.buttonAdicionarFoto.DialogResult = false;
            this.buttonAdicionarFoto.FlatAppearance.BorderSize = 0;
            this.buttonAdicionarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarFoto.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.buttonAdicionarFoto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdicionarFoto.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonAdicionarFoto.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonAdicionarFoto.Location = new System.Drawing.Point(788, 260);
            this.buttonAdicionarFoto.Name = "buttonAdicionarFoto";
            this.buttonAdicionarFoto.OnClick_BorderColor_1 = System.Drawing.Color.Transparent;
            this.buttonAdicionarFoto.OnClick_BorderColor_2 = System.Drawing.Color.Transparent;
            this.buttonAdicionarFoto.OnClick_FillColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(184)))), ((int)(((byte)(216)))));
            this.buttonAdicionarFoto.OnClick_FillColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            this.buttonAdicionarFoto.OnOver_BorderColor_1 = System.Drawing.Color.Transparent;
            this.buttonAdicionarFoto.OnOver_BorderColor_2 = System.Drawing.Color.Transparent;
            this.buttonAdicionarFoto.OnOver_FillColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.buttonAdicionarFoto.OnOver_FillColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.buttonAdicionarFoto.Size = new System.Drawing.Size(128, 33);
            this.buttonAdicionarFoto.TabIndex = 27;
            this.buttonAdicionarFoto.TabStop = false;
            this.buttonAdicionarFoto.Text = "ADD FOTO";
            this.buttonAdicionarFoto.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            this.buttonAdicionarFoto.UseMnemonic = false;
            this.buttonAdicionarFoto.UseVisualStyleBackColor = false;
            this.buttonAdicionarFoto.Click += new System.EventHandler(this.buttonAdicionarFoto_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.AccessibleRole = null;
            this.buttonSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSalvar.BackColor = System.Drawing.Color.Transparent;
            this.buttonSalvar.BorderColor_1 = System.Drawing.Color.Transparent;
            this.buttonSalvar.BorderColor_2 = System.Drawing.Color.Transparent;
            this.buttonSalvar.BorderRadius = 20;
            this.buttonSalvar.BorderSize = 3;
            this.buttonSalvar.CausesValidation = false;
            this.buttonSalvar.ColorFill_1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonSalvar.ColorFill_2 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(189)))));
            this.buttonSalvar.DialogResult = false;
            this.buttonSalvar.FlatAppearance.BorderSize = 0;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.buttonSalvar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSalvar.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonSalvar.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonSalvar.Location = new System.Drawing.Point(687, 393);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.OnClick_BorderColor_1 = System.Drawing.Color.Transparent;
            this.buttonSalvar.OnClick_BorderColor_2 = System.Drawing.Color.Transparent;
            this.buttonSalvar.OnClick_FillColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(184)))), ((int)(((byte)(216)))));
            this.buttonSalvar.OnClick_FillColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            this.buttonSalvar.OnOver_BorderColor_1 = System.Drawing.Color.Transparent;
            this.buttonSalvar.OnOver_BorderColor_2 = System.Drawing.Color.Transparent;
            this.buttonSalvar.OnOver_FillColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.buttonSalvar.OnOver_FillColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.buttonSalvar.Size = new System.Drawing.Size(130, 40);
            this.buttonSalvar.TabIndex = 28;
            this.buttonSalvar.TabStop = false;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            this.buttonSalvar.UseMnemonic = false;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AccessibleRole = null;
            this.buttonCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.BorderColor_1 = System.Drawing.Color.Transparent;
            this.buttonCancelar.BorderColor_2 = System.Drawing.Color.Transparent;
            this.buttonCancelar.BorderRadius = 20;
            this.buttonCancelar.BorderSize = 3;
            this.buttonCancelar.CausesValidation = false;
            this.buttonCancelar.ColorFill_1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.buttonCancelar.ColorFill_2 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(189)))));
            this.buttonCancelar.DialogResult = false;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.buttonCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCancelar.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonCancelar.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttonCancelar.Location = new System.Drawing.Point(874, 393);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.OnClick_BorderColor_1 = System.Drawing.Color.Transparent;
            this.buttonCancelar.OnClick_BorderColor_2 = System.Drawing.Color.Transparent;
            this.buttonCancelar.OnClick_FillColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(184)))), ((int)(((byte)(216)))));
            this.buttonCancelar.OnClick_FillColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            this.buttonCancelar.OnOver_BorderColor_1 = System.Drawing.Color.Transparent;
            this.buttonCancelar.OnOver_BorderColor_2 = System.Drawing.Color.Transparent;
            this.buttonCancelar.OnOver_FillColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.buttonCancelar.OnOver_FillColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.buttonCancelar.Size = new System.Drawing.Size(130, 40);
            this.buttonCancelar.TabIndex = 29;
            this.buttonCancelar.TabStop = false;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            this.buttonCancelar.UseMnemonic = false;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1040, 491);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonAdicionarFoto);
            this.Controls.Add(this.pictureBoxAluno);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCadastroAluno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroAluno";
            this.Load += new System.EventHandler(this.FormCadastroAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.PictureBox buttonMinimizar;
        private System.Windows.Forms.PictureBox buttonRestaurar;
        private System.Windows.Forms.PictureBox buttonMaximizar;
        private System.Windows.Forms.PictureBox buttonFechar;
        private CodeeloUI.Controls.CodeeloPictureBox pictureBoxAluno;
        private CodeeloUI.Controls.CodeeloButton buttonAdicionarFoto;
        private CodeeloUI.Controls.CodeeloButton buttonSalvar;
        private CodeeloUI.Controls.CodeeloButton buttonCancelar;
    }
}