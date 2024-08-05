using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace STECHPROYECT
{
    public partial class FrmCorreo : Form,IReceptor
    {
        private string ruta;
        List<RutaArchivo> urlruta;
        RutaArchivo u;
        Correo correo;

        public FrmCorreo()
        {
            InitializeComponent();
            urlruta = new List<RutaArchivo>();
            u = new RutaArchivo();
            correo = new Correo();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Enviar();
        }

        private void Enviar()
        {
            Email email = new Email();
            email.Asunto = txtAsunto.Text;
            email.Para = txtPara.Text;
            email.Cuerpo = txtBody.Text;
            email.RutaArchivo = txtRuta.Text;
            if (correo.Enviar(email))
            {
                new ShowMessajeCorrecto(this,"Se ha enviado correctamente",false).Show();
            }
            else
            {
                new ShowMessajeInternalError(this,"Ha ocurrido un error al enviar",false).Show();
            }
            
        }

        private void btnRedactar_Click(object sender, EventArgs e)
        {
            pnlRedactar.Visible = true;
            btnRedactar.Visible = false;
        }

        private void btnCerrarRedactar_Click(object sender, EventArgs e)
        {
            pnlRedactar.Visible = false;
            btnRedactar.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlRedactar.Visible = false;
            btnRedactar.Visible = true;
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            PedirRuta(".", "All Files (*.*)|*.*");
        }

        private void PedirRuta(string defaultE, string filter)
        {
            OpenFileDialog saveFileDialog = new OpenFileDialog();
            saveFileDialog.InitialDirectory = @"D:/Descargas/";
            saveFileDialog.Title = "Abrir Arcivo";
            saveFileDialog.DefaultExt = defaultE;
            saveFileDialog.Filter = filter;
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            string filename = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
            }
            if (filename.Trim() != "")
            {
                ruta = filename;
                txtRuta.Text = filename;
                u.Ruta = filename;
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UNA RUTA", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPara_Enter(object sender, EventArgs e)
        {
            if (txtPara.Text.Trim().Equals("Para:"))
            {
                txtPara.Text = "";
            }
        }

        private void txtPara_Leave(object sender, EventArgs e)
        {
            if (txtPara.Text.Trim().Equals(""))
            {
                txtPara.Text = "Para:";
            }
        }

        private void txtAsunto_Enter(object sender, EventArgs e)
        {
            if (txtAsunto.Text.Trim().Equals("Asunto"))
            {
                txtAsunto.Text = "";
            }
        }

        private void txtAsunto_Leave(object sender, EventArgs e)
        {
            if (txtAsunto.Text.Trim().Equals(""))
            {
                txtAsunto.Text = "Asunto";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PedirRuta(".jpg", "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PedirRuta(".pdf", "pdf files (*.pdf) | *.pdf");
        }

        public void Recibir(bool respuesta)
        {
        }
    }
}
