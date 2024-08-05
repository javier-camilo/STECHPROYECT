using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
     public class LogroService
    {
        DataBaseRepository database;
        SqlConnection conexion;

        public LogroService()
        {
            conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\camil\Desktop\STECHPROYECT\DAL\DBSchoolTech.mdf;Integrated Security=True");
            database = new DataBaseRepository(conexion);
        }

        public string GuardarDB(Logro logro)
        {
            try
            {
                conexion.Open();
                logro = AsginarNota(logro);
                database.GuardarLogro(logro);
                conexion.Close();
                return "Guardado correctamente";
            }
            catch (Exception)
            {
                conexion.Close();

                return "Error al guardar";
            }
        }

        private Logro AsginarNota(Logro logro)
        {

            AsignarCalificacion asignacion = new AsignarCalificacion();
            asignacion.CalcularNota(logro.Calificacion);
            logro.MayorNota = asignacion.NotaMayor;
            logro.MenorNota = asignacion.NotaMenor;
            return logro;

        }

        public List<Logro> Logros()
        {
            List<Logro> listado = new List<Logro>();

            try
            {
                conexion.Open();
                listado=database.logros();
                conexion.Close();
                return listado;
            }
            catch (Exception)
            {
                conexion.Close();
                return null;
            }
        }

    }
}
