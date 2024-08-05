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
    public class StechService
    {
        DataBaseRepository database;
        SqlConnection conexion;
        public StechService()
        {
            conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Escritorio\STECHPROYECT\DAL\DBSchoolTech.mdf;Integrated Security=True");
            database = new DataBaseRepository(conexion);
        }
        public List<Estudiante> Estudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            try
            {
                conexion.Open();
                estudiantes = database.ConsultarEstudiantesBD();
                conexion.Close();
                return estudiantes;
            }
            catch (Exception)
            {
                conexion.Close();
                return null;
            }
        }
    }
}
