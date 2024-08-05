using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STECHPROYECT
{
    public partial class ShowMessajeCorrecto : Form
    {
        private IReceptor frmReceptor;

        public ShowMessajeCorrecto()
        {
            InitializeComponent();
        }
        public ShowMessajeCorrecto(IReceptor frmRecibido, string mensaje, bool estadoBtnCancelar)
        {
            InitializeComponent();
            SystemSounds.Beep.Play();
            frmReceptor = frmRecibido;
            lblMensaje.Text = mensaje;
            btnCancelar.Visible = estadoBtnCancelar;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (frmReceptor != null)
            {
                frmReceptor.Recibir(true);
                this.Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (frmReceptor != null)
            {
                frmReceptor.Recibir(false);
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (frmReceptor != null)
            {
                frmReceptor.Recibir(false);
                this.Hide();
            }
        }
    }
}
