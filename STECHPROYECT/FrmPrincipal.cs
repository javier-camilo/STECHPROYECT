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

namespace STECHPROYECT
{
    public partial class FrmPrincipal : Form
    {

        private int LX, LY;
        private object formActual;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FrmPrincipal()
        {
            InitializeComponent();
            pnlOpciones.Width = 0;
            Restaurar();
            AbrirEnPanel(new FrmPresentacion());
            formActual = new object();
            MaximizarMinimizar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Botones(bool e,bool c,bool m,bool n)
        {
            picExportar.Visible = e;
            picCorreo.Visible = c;
            picNotas.Visible = n;
            picMatricular.Visible = m;
        }
        private void BotonesActivar(Label b)
        {
            b.BackColor = Color.OrangeRed;
            b.ForeColor = Color.White;
        }
        private void BotonesDesactivar(Label b)
        {
            b.BackColor = Color.White;
            b.ForeColor = Color.Black;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FrmExportarBoletin());
            pnlOpciones.Width = 0;
            BotonesActivar(lblExportar);
            BotonesDesactivar(lblCorreo);
            BotonesDesactivar(lblMatricular);
            BotonesDesactivar(lblNotas);
            Botones(true,false,false,false);
        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {
            pnlOpciones.Width = 0;
            AbrirEnPanel(new FrmCorreo());
            BotonesActivar(lblCorreo);
            BotonesDesactivar(lblExportar);
            BotonesDesactivar(lblMatricular);
            BotonesDesactivar(lblNotas);
            Botones(false, true, false, false);
        }

        private void lblNotas_Click(object sender, EventArgs e)
        {
            pnlOpciones.Width = 0;
            BotonesActivar(lblNotas);
            BotonesDesactivar(lblExportar);
            BotonesDesactivar(lblMatricular);
            BotonesDesactivar(lblCorreo);
            Botones(false, false, false, true);
        }

        private void lblMatricular_Click(object sender, EventArgs e)
        {
            pnlOpciones.Width = 0;
            AbrirEnPanel(new FrmMatriculas());
            BotonesActivar(lblMatricular);
            BotonesDesactivar(lblExportar);
            BotonesDesactivar(lblNotas);
            BotonesDesactivar(lblCorreo);
            Botones(false, false, true, false);
        }

        private void lblInicio_Click(object sender, EventArgs e)
        {
            pnlOpciones.Width = 0;
            Restaurar();
            AbrirEnPanel(new FrmPresentacion());
        }
        private void Restaurar()
        {
            Botones(false, false, false, false);
            BotonesDesactivar(lblCorreo);
            BotonesDesactivar(lblExportar);
            BotonesDesactivar(lblMatricular);
            BotonesDesactivar(lblNotas);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Restaurar();
            AbrirEnPanel(new FrmPresentacion());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblFecha.Text = DateTime.Now.ToString("dd/mm/yyyy");
            lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pnlOpciones.Width == 0)
            {
                pnlOpciones.Width = 250;
            }
            else
            {
                pnlOpciones.Width = 0;
            }
        }
        public void AbrirEnPanel(object formulario)
        {
            if(formActual != formulario)
            {
                formActual = formulario;
                if (this.pnlVisualizar.Controls.Count > 0)
                {
                    this.pnlVisualizar.Controls.RemoveAt(0);
                }
                Form fh = formulario as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.pnlVisualizar.Controls.Add(fh);
                this.pnlVisualizar.Tag = fh;
                fh.Show();
            }
            
        }

        private void pnlHead_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MaximizarMinimizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Close();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            pnlOpciones.Width = 0;
        }

        private void panel3_MouseMove_1(object sender, MouseEventArgs e)
        {
            pnlOpciones.Width = 0;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            pnlOpciones.Width = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FrmMaterias());
        }

        private void BtnLogro_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FrmLogros());
        }

        private void MaximizarMinimizar()
        {
            if (this.Size != Screen.PrimaryScreen.WorkingArea.Size)
            {
                LX = this.Location.X;
                LY = this.Location.Y;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }
            else
            {
                this.Location = new Point(LX, LY);
                this.Size = new Size(800, 500);
            }
        }
    }
}
