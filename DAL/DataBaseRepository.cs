using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class DataBaseRepository
    {
        SqlConnection conexion;
        SqlDataReader Reader;

        public DataBaseRepository(SqlConnection conexion)
        {
            this.conexion = conexion;
        }
        public void GuardarEstudianteBaseDatos(Estudiante estudiante)
        {
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "insert into Estudiantes values(@Identificacion," +
                    "@Grado,@PrimerNombre,@SegundoNombre,@PrimerApellido,@SegundoApellido," +
                    "@Sexo,@DiaNacimiento,@MesNacimiento,@YearNacimiento,@LugarNacimiento," +
                    "@DificultadAprendizaje,@DificultadExpresionOral," +
                    "@Enfermedad,@ViveCon)";

                comando.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = estudiante.Datos.Identificacion;
                comando.Parameters.Add("@Grado", SqlDbType.VarChar).Value = estudiante.Grado;
                comando.Parameters.Add("@PrimerNombre", SqlDbType.VarChar).Value = estudiante.Datos.Nombre.PrimerNombre;
                comando.Parameters.Add("@SegundoNombre", SqlDbType.VarChar).Value = estudiante.Datos.Nombre.SegundoNombre;
                comando.Parameters.Add("@PrimerApellido", SqlDbType.VarChar).Value = estudiante.Datos.Nombre.PrimerApellido;
                comando.Parameters.Add("@SegundoApellido", SqlDbType.VarChar).Value = estudiante.Datos.Nombre.SegundoApellido;
                comando.Parameters.Add("@Sexo", SqlDbType.VarChar).Value = estudiante.Datos.Sexo;
                comando.Parameters.Add("@DiaNacimiento", SqlDbType.Int).Value = estudiante.FechaNacimiento.Dia;
                comando.Parameters.Add("@MesNacimiento", SqlDbType.Int).Value = estudiante.FechaNacimiento.Mes;
                comando.Parameters.Add("@YearNacimiento", SqlDbType.Int).Value = estudiante.FechaNacimiento.Year;
                comando.Parameters.Add("@LugarNacimiento", SqlDbType.VarChar).Value = estudiante.LugarNacimiento;
                comando.Parameters.Add("@DificultadAprendizaje", SqlDbType.VarChar).Value = estudiante.DificultadAprendizaje;
                comando.Parameters.Add("@DificultadExpresionOral", SqlDbType.VarChar).Value = estudiante.DificultadExpresionOral;
                comando.Parameters.Add("@Enfermedad", SqlDbType.VarChar).Value = estudiante.Enfermedad;
                comando.Parameters.Add("@viveCon", SqlDbType.VarChar).Value = estudiante.ViveCon;

                comando.ExecuteNonQuery();
            }
        }
        public List<Estudiante> ConsultarEstudiantesBD()
        {
            List<Estudiante> Estudiantes = new List<Estudiante>();
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "select * from Estudiantes";
                Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Estudiante estudiante = MapEstudiante(Reader);
                    Estudiantes.Add(estudiante);
                }
            }
            return Estudiantes;
        }
        private Estudiante MapEstudiante(SqlDataReader reader)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Datos.Identificacion = (string)reader["Identificacion"];
            estudiante.Grado = (string)reader["Grado"];
            estudiante.Datos.Nombre.PrimerNombre = (string)reader["PrimerNombre"];
            estudiante.Datos.Nombre.SegundoNombre = (string)reader["SegundoNombre"];
            estudiante.Datos.Nombre.PrimerApellido = (string)reader["PrimerApellido"];
            estudiante.Datos.Nombre.SegundoApellido = (string)reader["SegundoApellido"];
            estudiante.Datos.Sexo = (string)reader["Sexo"];
            estudiante.Datos.FechaNacimiento.Dia = Convert.ToInt16(reader["DiaNacimiento"]);
            estudiante.Datos.FechaNacimiento.Mes = Convert.ToInt16(reader["MesNacimiento"]);
            estudiante.Datos.FechaNacimiento.Year = Convert.ToInt16(reader["YearNacimiento"]);
            estudiante.LugarNacimiento = (string)reader["LugarNacimiento"];
            estudiante.DificultadAprendizaje = (string)reader["DificultadAprendizaje"];
            estudiante.DificultadExpresionOral = (string)reader["DificultdExpresionOral"];
            estudiante.Enfermedad = (string)reader["Enfermedad"];
            estudiante.ViveCon = (string)reader["viveCon"];
            estudiante.EstudiosPrevios = null;
            estudiante.Acudientes = null;
            return estudiante;
        }


        public void GuardarMateriaDB(Materia materia)
        {
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "insert into Materias values(@Codigo,@Materia,@Grado)";

                comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = materia.NombreMateria + materia.Grado;
                comando.Parameters.Add("@Materia", SqlDbType.VarChar).Value = materia.NombreMateria;
                comando.Parameters.Add("@Grado", SqlDbType.VarChar).Value = materia.Grado;

                comando.ExecuteNonQuery();
            }
        }
        public void ModificarMateriaDB(Materia materia, Materia materiaAntigua)
        {
            EliminarMateriaDB(materiaAntigua);
            GuardarMateriaDB(materia);

        }
        public List<Materia> ConsultarMateriasBD()
        {
            List<Materia> Materias = new List<Materia>();
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "select * from Materias";
                Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Materia materia = MapMateria(Reader);
                    Materias.Add(materia);
                }
            }
            return Materias;
        }
        private Materia MapMateria(SqlDataReader reader)
        {
            Materia materia = new Materia();
            materia.Codigo = (string)reader["Codigo"];
            materia.NombreMateria = (string)reader["Materia"];
            materia.Grado = (string)reader["Grado"];

            return materia;
        }
        public void EliminarMateriaDB(Materia MateriaAntigua)
        {
            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "DELETE FROM Materias WHERE Codigo=@Codigo";
                Comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = MateriaAntigua.NombreMateria + MateriaAntigua.Grado;
                Comando.ExecuteNonQuery();
            }

        }

        public void GuardarLogro(Logro logro)
        {

            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "insert into Logros values(@CodigoMateria,@Materia,@Grado,@MayorNota,@MenorNota,@Calificacion,@LogroObtenido)";

                comando.Parameters.Add("@CodigoMateria", SqlDbType.VarChar).Value = logro.Materia + logro.Grado;
                comando.Parameters.Add("@Materia", SqlDbType.VarChar).Value = logro.Materia;
                comando.Parameters.Add("@Grado", SqlDbType.VarChar).Value = logro.Grado;
                comando.Parameters.Add("@MayorNota", SqlDbType.Float).Value =logro.MayorNota;
                comando.Parameters.Add("@MenorNota", SqlDbType.Float).Value =logro.MenorNota;
                comando.Parameters.Add("@Calificacion", SqlDbType.VarChar).Value = logro.Calificacion;
                comando.Parameters.Add("@LogroObtenido", SqlDbType.VarChar).Value = logro.LogroObtenido;

                comando.ExecuteNonQuery();
            }


        }
        public List<Logro> logros()
        {

            List<Logro> logros = new List<Logro>();

            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "select * from Logros";
                Reader = comando.ExecuteReader();

                while (Reader.Read())
                {
                    Logro logro = MapLogro(Reader);
                    logros.Add(logro);
                }
            }
            return logros;

        } 
        private Logro MapLogro(SqlDataReader reader)
        {
            Logro logro = new Logro();
            logro.Materia = (string)reader["Materia"];
            logro.Grado = (string)reader["Grado"];
            logro.MayorNota = Convert.ToDouble(reader["MayorNota"]);
            logro.MenorNota = Convert.ToDouble(reader["MenorNota"]);
            logro.Calificacion = (string)reader["Calificacion"];
            logro.LogroObtenido = (string)reader["LogroObtenido"];

            return logro;

        }


    }
}
