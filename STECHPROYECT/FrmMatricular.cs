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
    public partial class FrmMatricular : Form,IReceptor
    {
        private Estudiante estudiante;
        int invocadoDesde;
        private IReceptor frmReceptor;

        public FrmMatricular()
        {
            InitializeComponent();
            estudiante = new Estudiante();
        }
        public FrmMatricular(IReceptor frmRecibido)
        {
            InitializeComponent();
            estudiante = new Estudiante();
            frmReceptor = frmRecibido;

        }

        public void Recibir(bool respuesta)
        {
            cargarRespuesta(respuesta);
        }

        private void cargarRespuesta(bool r)
        {
            switch (invocadoDesde)
            {
                case 4: PasarToCinco(r); break;
                case 5: EliminarDgvEstudiosPrevios(r); break;
                case 6: EliminarDeTablaAcudientes(r); break;
            }
        }

        private void LlenarComboDia()
        {
            
            try
            {
                comboDia.Items.Clear();
                int dias = DateTime.DaysInMonth(Convert.ToInt32(comboYear.Text.ToString()), Convert.ToInt32(comboMes.Text.ToString()));
                for (int i = 1; i <= dias; i++)
                {
                    comboDia.Items.Add($"{i}");
                }
            }
            catch (Exception)
            {
                
            }
        }
        private void LlenarComboYear(ComboBox combo)
        {
            int yearActual = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            for (int i = yearActual; i >= 2000; i--)
            {
                combo.Items.Add($"{i}");
            }
        }
        private void LlenarComboMes()
        {
            for (int i = 1; i <= 12; i++)
            {
                comboMes.Items.Add($"{i}");
            }
        }
        private void comboDia_MouseDown(object sender, MouseEventArgs e)
        {
            LlenarComboDia();
        }
        private void comboMes_MouseDown(object sender, MouseEventArgs e)
        {
            LlenarComboDia();
            comboDia.Text = "DD";
        }

        private void txtIDEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtPNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtSNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtPApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtSApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtParentesco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void comboViveCon_MouseDown(object sender, MouseEventArgs e)
        {
            if (comboViveCon.Text.ToString().Equals("OTROS") || comboViveCon.Text.ToString().Trim().Equals(""))
            {
                txtParentesco.Enabled = false;
            }
            else
            {
                txtParentesco.Enabled = true;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DatosMatricula();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DatosEstudiante();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DatosEstudiante2();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            EscuelasAnteriores();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string m = new MatricularEstudianteService().GuardarBD(estudiante);
            if (m.Equals("Guardado correctamente"))
            {
                new ShowMessajeCorrecto(this, m, false).Show();
                frmReceptor.Recibir(true);
            }
            else
            {
                new ShowMessajeError(this, m, false).Show();
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EstudiosPrevios();
            Limpiartab4();
        }
        private void Limpiartab4()
        {
            txtEstudios.Text = "ESTUDIOS CURSADOS";
            comboyear2.Text = " ";
            txtInstitucion.Text = "INSTITUCIÓN";
            txtCiudad.Text = "CIUDAD";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Verificartab5();
        }
        private void dgvAcudientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new ShowMessajeConfirmacion(this, "¿Seguro que desea quitar este campo de la lista?", true).Show();
            invocadoDesde = 6;
        }

        private void EstudiosPrevios()
        {
            try
            {
                EstudioPrevio estudio = new EstudioPrevio();
                ValidacionesService validar = new ValidacionesService();
                estudio.Identificacion = estudiante.Datos.Identificacion;
                estudio.GradoCursado = txtEstudios.Text;
                estudio.Year = Convert.ToInt16(validar.VerificarStringVacio(comboyear2.Text.ToString()));
                estudio.EstablecimientoEducativo = txtInstitucion.Text;
                estudio.Ciudad = txtCiudad.Text;
                new MatricularEstudianteService().AgregarEstudio(estudio);
                dgvEscuelasAnteriores.DataSource = new MatricularEstudianteService().EstudiosPrevios();
            }
            catch (Exception)
            {
                new ShowMessajeError(this, "VERIFIQUE QUE TODOS LOS CAMPOS ESTEN LLENOS CORRECTAMENTE ", false).Show();
            }

        }
        private void LlenarDgvEstudiosPrevios()
        {
            dgvEscuelasAnteriores.Rows.Clear();
            //List<EstudioPrevio> EstudiosPrevios = matricular.VerEstudiosPrevios();

            //foreach (var item in EstudiosPrevios)
            //{
            //    int fila = dgvEscuelasAnteriores.Rows.Count - 1;
            //    dgvEscuelasAnteriores.Rows.Add();

            //    dgvEscuelasAnteriores.Rows[fila].Cells[0].Value = item.GradoCursado;
            //    dgvEscuelasAnteriores.Rows[fila].Cells[1].Value = item.Year;
            //    dgvEscuelasAnteriores.Rows[fila].Cells[2].Value = item.EstablecimientoEducativo;
            //    dgvEscuelasAnteriores.Rows[fila].Cells[3].Value = item.Ciudad;
            //}
            
        }
        private void dgvEscuelasAnteriores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new ShowMessajeConfirmacion(this, "¿Seguro que desea quitar este campo de la lista?", true).Show();
            invocadoDesde = 5;

        }
        private void EliminarDgvEstudiosPrevios(bool r)
        {
            if (r)
            {
                EstudioPrevio estudio = new EstudioPrevio();
                
                estudio.Identificacion = estudiante.Datos.Identificacion;
                estudio.GradoCursado = dgvEscuelasAnteriores.Rows[dgvEscuelasAnteriores.CurrentRow.Index].Cells[0].Value.ToString();
                estudio.Year = Convert.ToInt32(dgvEscuelasAnteriores.Rows[dgvEscuelasAnteriores.CurrentRow.Index].Cells[1].Value.ToString());
                estudio.Codigo = estudiante.Datos.Identificacion + estudio.Year;
                estudio.EstablecimientoEducativo= dgvEscuelasAnteriores.Rows[dgvEscuelasAnteriores.CurrentRow.Index].Cells[2].Value.ToString();
                estudio.Ciudad = dgvEscuelasAnteriores.Rows[dgvEscuelasAnteriores.CurrentRow.Index].Cells[3].Value.ToString();
                //matricular.QuitarEstudio(estudio);
                LlenarDgvEstudiosPrevios();
            }
        }
        private void EliminarDeTablaAcudientes(bool r)
        {
            if (r)
            {
                dgvAcudientes.Rows.RemoveAt(dgvAcudientes.CurrentRow.Index);
            }
        }

        private void DatosMatricula()
        {
            string grado = comboGrado.Text.ToString().Trim();
            if (grado.Equals(""))
            {
                new ShowMessajeError(this, "DEBE SELECCIONAR UN GRADO", false).Show();
            }
            else
            {
                LlenarComboYear(comboYear);
                LlenarComboMes();
                estudiante.Grado = grado;
                tabMatriculas.SelectedTab = PasoDos;
            }
        }
        private void DatosEstudiante()
        {
            
            try
            {
                ValidacionesService validar = new ValidacionesService();
                estudiante.Datos.Identificacion = validar.VerificarStringVacio(txtIDEstudiante.Text.Trim());
                estudiante.Datos.Nombre.PrimerNombre = validar.VerificarStringVacio(txtPNombre.Text.Trim().ToUpper());
                estudiante.Datos.Nombre.SegundoNombre = validar.VerificarStringVacio(txtSNombre.Text.Trim().ToUpper());
                estudiante.Datos.Nombre.PrimerApellido = validar.VerificarStringVacio(txtPApellido.Text.Trim().ToUpper());
                estudiante.Datos.Nombre.SegundoApellido = validar.VerificarStringVacio(txtSApellido.Text.Trim().ToUpper());
                estudiante.Datos.Sexo = validar.VerificarStringVacio(comboSexo.Text.ToString());
                estudiante.Datos.FechaNacimiento.Dia = Convert.ToInt16(validar.VerificarStringVacio(comboDia.Text.ToString()));
                estudiante.Datos.FechaNacimiento.Mes = Convert.ToInt16(validar.VerificarStringVacio(comboMes.Text.ToString()));
                estudiante.Datos.FechaNacimiento.Year = Convert.ToInt16(validar.VerificarStringVacio(comboYear.Text.ToString()));
                estudiante.LugarNacimiento = validar.VerificarStringVacio(txtLugar.Text.Trim().ToUpper());
                tabMatriculas.SelectedTab = PasoTres;
            }
            catch (Exception)
            {
                new ShowMessajeError(this, "VERIFIQUE QUE TODOS LOS CAMPOS ESTEN LLENOS CORRECTAMENTE", false).Show();
            }

        }
        private void DatosEstudiante2()
        {
            try
            {
                ValidacionesService validar = new ValidacionesService();
                estudiante.DificultadAprendizaje = validar.VerificarStringVacio(comboDAprendizaje.Text.ToString().Trim());
                estudiante.DificultadExpresionOral = validar.VerificarStringVacio(comboDEOral.Text.ToString().Trim());
                estudiante.Enfermedad = txtEnfermedad.Text.ToString().Trim();
                estudiante.ViveCon = comboViveCon.Text.Equals("OTROS") ? txtParentesco.Text.Trim() : comboViveCon.Text.ToString();
                validar.VerificarStringVacio(estudiante.ViveCon);
                tabMatriculas.SelectedTab = PasoCuatro;
                LlenarComboYear(comboyear2);
            }
            catch (Exception)
            {
                new ShowMessajeError(this, "VERIFIQUE QUE TODOS LOS CAMPOS ESTEN LLENOS CORRECTAMENTE ", false).Show();
            }
        }
        private void EscuelasAnteriores()
        {
            if (txtEstudios.Text.Trim().Equals("ESTUDIOS CURSADOS") && txtInstitucion.Text.Trim().Equals("INSTITUCIÓN") && txtCiudad.Text.Trim().Equals("CIUDAD"))
            {
                PasarToCinco(true);
            }
            else
            {
                new ShowMessajeError(this, "¿Seguro que desea descartar estos datos?", true).Show();
                invocadoDesde = 4;
            }
            
        }
        private void PasarToCinco(bool r)
        {
            if (r)
            {
                tabMatriculas.SelectedTab = PasoCinco;
            }
        }
        private void Verificartab5()
        {
            try
            {
                int fila = dgvAcudientes.Rows.Count - 1;
                dgvAcudientes.Rows.Add();
                dgvAcudientes.Rows[fila].Cells[0].Value = comboTipoAccudiente.Text.Trim();
                dgvAcudientes.Rows[fila].Cells[1].Value = txtIdentificacionAcudiente.Text.ToString();
                dgvAcudientes.Rows[fila].Cells[2].Value = txtNombreAcudiente.Text.Trim();
                dgvAcudientes.Rows[fila].Cells[3].Value = txtCorreoAcudiente.Text.Trim();
                dgvAcudientes.Rows[fila].Cells[4].Value = txtTelefonoAcudiente.Text.Trim();
                dgvAcudientes.Rows[fila].Cells[5].Value = txtDireccionAcudiente.Text.Trim();
                dgvAcudientes.Rows[fila].Cells[6].Value = txtOcupacionAcudiente.Text.Trim();
            }
            catch (Exception)
            {
                new ShowMessajeError(this, "Verifique los datos", false).Show();
            }
        }
        
    }
}
