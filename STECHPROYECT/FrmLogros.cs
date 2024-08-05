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
    public partial class FrmLogros : Form,IReceptor
    {
        private Logro logro;
        private int tipoOperacion;

        public FrmLogros()
        {
            InitializeComponent();
            logro = new Logro();
            tipoOperacion = 1;
            MostrarLogros();
        }

        private void dgvLogro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LlenarComboMateria()
        {
            List<Materia> Materias = new MateriaService().Materias();
            CmbMateria.Items.Clear();
            foreach (var item in Materias)
            {
                if (item.Grado.Equals(CmbGrado.Text))
                {
                    CmbMateria.Items.Add(item.NombreMateria);
                }
            }
        }
        
        
        private void CmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboMateria();
        }



        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (new ValidacionesService().VerificarCamposLogros(CmbGrado.Text,CmbMateria.Text,CmbCalificacion.Text,TxtLogro.Text.Trim()))
            {
                new ShowMessajeError(this,new ValidacionesService().MensajeValidar,false).Show();
            }
            else
            {
                switch (tipoOperacion)
                {
                    case 1:Guardar();break;
                    case 2:Editar();break;
                }
            }

        }


        private void Guardar()
        {
            logro = LlenarLogro();
            string mensaje = new LogroService().GuardarDB(logro);
            mostrarMesaje(mensaje);
            MostrarLogros();
        }

        private void Editar()
        {

        }
   
        private void mostrarMesaje(string mensaje)
        {

            if (mensaje.Equals("Guardado correctamente") || mensaje.Equals("Eliminado correctamente"))
            {
                new ShowMessajeCorrecto(this, mensaje, false).Show();

            }
            else
            {
                new ShowMessajeError(this, mensaje, false).Show();
            }



        }

        private Logro LlenarLogro()
        {
            Logro logroUsuario = new Logro();
            logroUsuario.Materia = CmbMateria.Text;
            logroUsuario.Grado = CmbGrado.Text;
            logroUsuario.LogroObtenido = TxtLogro.Text.Trim().ToUpper();
            logroUsuario.Calificacion = CmbCalificacion.Text;

            return logroUsuario;
            
        }

        public void Recibir(bool respuesta)
        {

        }

        private void MostrarLogros()
        {
            dgvLogro.DataSource = new LogroService().Logros();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            try
            {

                tipoOperacion = 2;
                MostrarSeleccion();
            }
            catch (Exception)
            {

                string mensaje = "debe seleccionar una fila a modificar ";
                new ShowMessajeError(this, mensaje, false).Show();
            }
        }

        private void MostrarSeleccion()
        {

            Logro logroMostrar = (Logro)dgvLogro.CurrentRow.DataBoundItem;
            CmbGrado.Text =logro.Grado;
            CmbMateria.Text = logro.Materia;
            CmbCalificacion.Text = logroMostrar.Calificacion;
            TxtLogro.Text = logro.LogroObtenido;

        }
    }
}
