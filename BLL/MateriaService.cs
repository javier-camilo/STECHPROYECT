using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MateriaService
    {
        DataBaseRepository database;
        SqlConnection conexion;

        public MateriaService()
        {
            conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documentos\STECHPROYECT\DAL\DBSchoolTech.mdf;Integrated Security=True");
            database = new DataBaseRepository(conexion);
        }
        public string GuardarBD(Materia materia)
        {
            try
            {
                conexion.Open();
                database.GuardarMateriaDB(materia);
                conexion.Close();
                return "Guardado correctamente";
            }
            catch (Exception)
            {
                conexion.Close();
                return "error al guardar";
            }
        }

        public List<Materia> Materias()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                conexion.Open();
                materias = database.ConsultarMateriasBD();
                conexion.Close();
                return materias;
            }
            catch (Exception e)
            {
                conexion.Close();
                return null;
            }
        }


        public string Modificar(Materia materia, Materia materiaAntigua)
        {
            try
            {
                conexion.Open();
                database.ModificarMateriaDB(materia,materiaAntigua);
                conexion.Close();
                return "Guardado correctamente";
            }
            catch (Exception)
            {
                conexion.Close();
                return "error  al modificar";
            }

        }

        public string Eliminar(Materia materiaAntigua)
        {
            try
            {
                conexion.Open();
                database.EliminarMateriaDB(materiaAntigua);
                conexion.Close();
                return "Eliminado correctamente";
            }
            catch (Exception)
            {
                conexion.Close();
                return "error  al Eliminar";
            }

        }
    }
}
