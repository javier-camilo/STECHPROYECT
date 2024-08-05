using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace STECHPROYECT
{
    public partial class FrmMatriculas : Form,IReceptor
    {
        private IReceptor frmReceptor;
        public FrmMatriculas()
        {
            InitializeComponent();
            LlenarTabla();
        }
        public FrmMatriculas(IReceptor frmRecibido)
        {
            InitializeComponent();
            frmReceptor = frmRecibido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FrmMatricular(this));
        }
        public void AbrirEnPanel(object formulario)
        {
            if (this.panelVer.Controls.Count > 0)
            {
                this.panelVer.Controls.RemoveAt(0);
            }
            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelVer.Controls.Add(fh);
            this.panelVer.Tag = fh;
            fh.Show();
        }

        public void Recibir(bool respuesta)
        {
            LlenarTabla();
        }
        private void LlenarTabla()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            estudiantes = new StechService().Estudiantes();
            if (estudiantes!=null)
            {
                foreach (var item in estudiantes)
                {
                    int fila = dgvMatriculados.Rows.Count - 1;
                    dgvMatriculados.Rows.Add();

                    dgvMatriculados.Rows[fila].Cells[0].Value = item.Datos.Identificacion;
                    dgvMatriculados.Rows[fila].Cells[1].Value = item.Datos.Nombre.PrimerNombre + " " + item.Datos.Nombre.PrimerApellido;
                    dgvMatriculados.Rows[fila].Cells[2].Value = item.Grado;
                }
            }
            
        }
    }
}
