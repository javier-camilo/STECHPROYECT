using BLL;
using ENTITY;
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
    public partial class FrmMaterias : Form, IReceptor
    {
        private int tipoOperacion;
        private Materia materia;
        private Materia materiaAntigua;


        public FrmMaterias()
        {
            InitializeComponent();
            tipoOperacion = 1;
            Mostrar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (tipoOperacion)
            {
                case 1: Agregar(); break;
                case 2: Modificar(); break;
            }
        }

        private void Agregar()
        {
            if (new ValidacionesService().VerificarCampoMateria(comboGrado.Text,txtMateria.Text.Trim()))
            {
                MostraMensaje(new ValidacionesService().MensajeValidar);
            }
            else
            {
                materia = LlenarMateria();
                string mensaje = new MateriaService().GuardarBD(materia);
                MostraMensaje(mensaje);
                Mostrar();
                Limpiar();
            }

        }
        private void Modificar()
        {
            if (new ValidacionesService().VerificarCampoMateria(comboGrado.Text, txtMateria.Text.Trim()))
            {
                MostraMensaje(new ValidacionesService().MensajeValidar);
            }
            else
            {
                materia = LlenarMateria();
                string mensaje = new MateriaService().Modificar(materia, materiaAntigua);
                MostraMensaje(mensaje);
                Mostrar();
                tipoOperacion = 1;
                Limpiar();
            }
        } 

        private void Mostrar()
        {
            MateriaService materia = new MateriaService();
            dgvMaterias.DataSource = materia.Materias();
        }
        private Materia LlenarMateria()
        {
            Materia materia = new Materia();
            materia.NombreMateria = txtMateria.Text.ToUpper();
            materia.Grado = comboGrado.Text.ToString();

            return materia;
        }
        private void MostraMensaje(string mensaje)
        {
            if (mensaje.Equals("Guardado correctamente") || mensaje.Equals("Eliminado correctamente"))
            {
                new ShowMessajeCorrecto(this, mensaje, false).Show();
                dgvMaterias.DataSource = new MateriaService().Materias();

            }
            else
            {
                new ShowMessajeError(this, mensaje, false).Show();
            }

        }
       
        public void Recibir(bool respuesta)
        {
            
        }

        private void FrmMaterias_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
            Materia materia = (Materia)dgvMaterias.CurrentRow.DataBoundItem;
            txtMateria.Text = materia.NombreMateria.ToUpper();
            comboGrado.Text = materia.Grado;
            materiaAntigua = LlenarMateria();
        }

        private void dgvMaterias_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                MostrarSeleccion();
                Eliminar();
            }
            catch (Exception)
            {


                string mensaje = "debe seleccionar una fila a  eliminar";
                new ShowMessajeError(this, mensaje, false).Show();
            }
        }

        private void Eliminar()
        {
            string mensaje = new MateriaService().Eliminar(materiaAntigua);
            MostraMensaje(mensaje);
            Limpiar();
        }

        private void Limpiar()
        {
            txtMateria.Text = "";
            comboGrado.Text = "";
        }
    }
}
