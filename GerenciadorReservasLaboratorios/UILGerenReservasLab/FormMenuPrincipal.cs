using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILGerenReservasLab
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
            //These lines eliminate the flickering of the form or controls in the graphical interface (but not 100%).
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        // RESIZE METHOD TO RESIZE/CHANGE FORM SIZE AT RUNTIME ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DRAW RECTANGLE / EXCLUDE PANEL CORNER 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContainer.Region = region;
            this.Invalidate();
        }
        //----------------COLOR AND GRIP OF BOTTOM RECTANGLE
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Capture position and size before maximizing to restore
        int lx, ly;
        int sw, sh;

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void buttonMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            buttonMaximizar.Visible = false;
            buttonRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void buttonRestaurar_Click(object sender, EventArgs e)
        {
            buttonMaximizar.Visible = true;
            buttonRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // METHOD TO DRAG THE FORM ---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ConfigurarCorBotoes(object sender)
        {
            buttonAluno.BackColor = Color.FromArgb(37, 54, 75);
            buttonCurso.BackColor = Color.FromArgb(37, 54, 75);
            buttonReserva.BackColor = Color.FromArgb(37, 54, 75);
            buttonDisciplina.BackColor = Color.FromArgb(37, 54, 75);
            buttonPredio.BackColor = Color.FromArgb(37, 54, 75);
            buttonSala.BackColor = Color.FromArgb(37, 54, 75);
            buttonUsuario.BackColor = Color.FromArgb(37, 54, 75);
            buttonGrupoUsuario.BackColor = Color.FromArgb(37, 54, 75);
            buttonPermissao.BackColor = Color.FromArgb(37, 54, 75);
            buttonSaidasAntecipadas.BackColor = Color.FromArgb(37, 54, 75);			
            ((Button)sender).BackColor = Color.FromArgb(0, 100, 182);
        }
		
        private void buttonReserva_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormBuscarReserva>();
            //buttonReserva.BackColor = Color.FromArgb(12, 61, 92);
            ConfigurarCorBotoes(sender);			
        }

        private void buttonCurso_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormBuscarCurso>();
            //buttonCurso.BackColor = Color.FromArgb(12, 61, 92);
            ConfigurarCorBotoes(sender);
        }

        private void buttonDisciplina_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormBuscarDisciplina>();
            //buttonDisciplina.BackColor = Color.FromArgb(12, 61, 92);
            ConfigurarCorBotoes(sender);
        }
        private void buttonPredio_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormBuscarPredio>();
            //buttonPredio.BackColor = Color.FromArgb(12, 61, 92);
            ConfigurarCorBotoes(sender);			
        }

        private void buttonSala_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormBuscarSala>();
            //buttonSala.BackColor = Color.FromArgb(12, 61, 92);
            ConfigurarCorBotoes(sender);			
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormBuscarUsuario>();
            //buttonUsuario.BackColor = Color.FromArgb(12, 61, 92);
            ConfigurarCorBotoes(sender);			
        }

        private void buttonGrupoUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormBuscarGrupoUsuario>();
            //buttonGrupoUsuario.BackColor = Color.FromArgb(12, 61, 92);
            ConfigurarCorBotoes(sender);			
        }

        private void buttonPermissao_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormBuscarPermissao>();
            //buttonPermissao.BackColor = Color.FromArgb(12, 61, 92);
            ConfigurarCorBotoes(sender);			
        }

        private void buttonAluno_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormBuscarAluno>();
            //buttonAluno.BackColor = Color.FromArgb(12, 61, 92);
            ConfigurarCorBotoes(sender);
        }

        private void buttonSaidasAntecipadas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormBuscarSaidasAntecipadas>();
            //buttonSaidasAntecipadas.BackColor = Color.FromArgb(12, 61, 92);
            ConfigurarCorBotoes(sender);			
        }
        private void timerHoraData_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss ");
            labelData.Text = DateTime.Now.ToLongDateString();
            labelUserName.Text = string.Empty;
            labelEmail.Text = string.Empty;
            labelCargo.Text = string.Empty;
        }

        // METHOD TO OPEN FORMS WITHIN THE PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();// Search in the collection for the form
                                                                                     // If the form/instance doesn't exist
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            // If the form/instance exists
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FormBuscarReserva"] == null)
                buttonReserva.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FormBuscarCurso"] == null)
                buttonCurso.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FormBuscarDisciplina"] == null)
                buttonDisciplina.BackColor = Color.FromArgb(4, 41, 68);
        }

    }
}
