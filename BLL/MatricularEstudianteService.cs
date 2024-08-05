using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class MatricularEstudianteService
    {
        DataBaseRepository database;
        SqlConnection conexion;
        public MatricularEstudianteService()
        {
            conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Escritorio\STECHPROYECT\DAL\DBSchoolTech.mdf;Integrated Security=True");
            database = new DataBaseRepository(conexion);
        }

        public void DatosEstudiante(Estudiante estudiante)
        {
            Datos.DatosTemporales.Estudiante(estudiante);
        }
        public Estudiante DatosEstudiante()
        {
            return Datos.DatosTemporales.Estudiante();
        }
        public void AgregarEstudio(EstudioPrevio estudio)
        {
            Datos.DatosTemporales.AgregarEstudio(estudio);
        }
        public List<EstudioPrevio> EstudiosPrevios()
        {
            return Datos.DatosTemporales.EstudiosPrevios();
        }
        public void QuitarEstudioPrevio(EstudioPrevio estudio)
        {
            Datos.DatosTemporales.QuitarEstudio(estudio);
        }
        public void AgregarAcudiente(Acudiente acudiente)
        {
            Datos.DatosTemporales.AgregarAcudiente(acudiente);
        }
        public void QuitarAcudiente(Acudiente acudiente)
        {
            Datos.DatosTemporales.QuitarAcudiente(acudiente);
        }
        public string GuardarBD(Estudiante estudiante)
        {
            try
            {
                conexion.Open();
                database.GuardarEstudianteBaseDatos(estudiante);
                conexion.Close();
                return "Guardado correctamente";
            }
            catch (Exception)
            {
                conexion.Close();
                return "error en base de datos";
            }
        }
    }
}
