using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STECHPROYECT
{
    public partial class FrmExportarBoletin : Form,IReceptor
    {
        public FrmExportarBoletin()
        {
            InitializeComponent();
        }
        private void PedirRuta()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"D:/Descargas/";
            saveFileDialog.Title = "Guardar Boletines";
            saveFileDialog.DefaultExt = "pdf";
            saveFileDialog.Filter = "All Files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            string filename = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
            }
            if (filename.Trim() != "")
            {
                string ruta = filename;
                txtRuta.Text = filename;
            }
            else
            {
                new ShowMessajeError(this,"DEBE SELECCIONAR UNA RUTA",false).Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PedirRuta();
        }

        public void Recibir(bool respuesta)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "All Files (*.*)|*.*";
            file.FileName = "";
            if (file.ShowDialog() == DialogResult.OK)
            {

            }
            string txtUrl = file.FileName;
        }
    }
}
